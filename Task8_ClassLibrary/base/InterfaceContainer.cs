using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task8
{
    public class InterfaceContainer : ProgressingEntity
    {
        private static readonly List<InterfaceContainer> instances = new List<InterfaceContainer>();

        private readonly ILoader @interface;
        private readonly SemaphoreSlim semaphore;
        public override string Type { get { return this.@interface?.GetType().Name; } }

        public static InterfaceContainer GetRandomInterface()
        {
            var instance = instances.Where(x => !x.IsBusy).FirstOrDefault();
            if (instance == null)
            {
                return instances.FirstOrDefault();
            }
            return instance;
        }

        public InterfaceContainer(ILoader loader, string name)
        {
            this.Name = name;
            this.@interface = loader;
            this.semaphore = new SemaphoreSlim(1);
            instances.Add(this);
        }

        protected override void Work()
        {
            this.Suspend(true);
            this.RaiseEvent("Работает");
            this.@interface.Dispatch();
            Interlocked.Add(ref this.progress, -100);
            this.RaiseEvent("Простаивает");
            this.Suspend(false);
            this.semaphore.Release();
        }

        public virtual void Request(Bolide model)
        {
            this.semaphore.Wait();
            this.Request((object)model);
            Interlocked.Add(ref this.progress, 100);
        }
    }
}
