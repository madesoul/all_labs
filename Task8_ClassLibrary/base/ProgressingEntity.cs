using System;
using System.Threading;

namespace Task8
{
    public abstract class ProgressingEntity : Subject
    {
        protected long progress = 0;
        private object owner;

        public int Progress { get { return (int)Math.Max(0, 100 - progress); } }

        public event Action<object> ProgressEvent;

        public ProgressingEntity() : base("", 100)
        {

        }

        protected override void Tick()
        {
            if (Interlocked.Read(ref this.progress) != 0)
            {
                this.Work();
                this.ProgressEvent?.Invoke(owner);
            }
        }

        public virtual void Request(object owner)
        {
            this.owner = owner;
        }

        protected abstract void Work();
    }
}
