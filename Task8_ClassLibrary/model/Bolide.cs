using System;

namespace Task8
{
    public class Bolide : Subject
    {
        private static readonly Random random = new Random();

        private bool running = true;

        private readonly Mechanic worker;

        public Bolide(string modelName) : base(modelName, 100)
        {
            this.worker = new Mechanic();
            this.worker.ProgressEvent += (owner) =>
            {
                if (owner != this)
                {
                    return;
                }
                this.RaiseEvent($"Смена колес({worker.Progress}%)");
                if (worker.Progress == 100)
                {
                    this.running = true;
                }
            };
            this.worker.Start();
        }

        protected override void Tick()
        {
            if (!this.running)
            {
                return;
            }

            var random = Bolide.random.NextDouble();
            if (random < 0.006)
            {
                this.running = false;
                if (random < 0.003)
                {
                    var @interface = InterfaceContainer.GetRandomInterface();
                    this.RaiseEvent($"Произошла авария. Ожидаем погрузчика.");
                    @interface.ProgressEvent += (owner) =>
                    {
                        if (owner != this)
                        {
                            return;
                        }
                        this.running = true;
                    };
                    @interface.Request(this);
                }
                else
                {
                    worker.Request(this);
                }
            }

            if (this.running)
            {
                this.RaiseEvent("Учавствует в гонке");
                return;
            }
        }
    }
}
