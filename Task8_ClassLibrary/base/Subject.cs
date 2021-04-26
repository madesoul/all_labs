using System;
using System.Threading;
using System.Timers;

namespace Task8
{
    public abstract class Subject
    {
        public string Name { get; protected set; }
        public virtual string Type { get { return this.GetType().Name; } }

        public event Action<string> SubjectEvent;

        public Thread runner;

        public bool IsBusy { get; private set; }

        private uint Interval { get; }

        protected Subject(string name, uint ms)
        {
            this.Name = name;
            this.Interval = ms;
            this.runner = new Thread(Runner)
            {
                IsBackground = true
            };
        }

        public void Start()
        {
            if (this.runner.ThreadState.HasFlag(ThreadState.Unstarted))
            {
                this.runner.Start();
            }
        }

        private void Runner()
        {
            while (true)
            {
                if (!IsBusy)
                {
                    Tick();
                }
                Thread.Sleep((int)this.Interval);
            }
        }

        protected void Suspend(bool suspend)
        {
            this.IsBusy = suspend;
        }

        protected abstract void Tick();

        protected void RaiseEvent(string eventDesc)
        {
            SubjectEvent?.Invoke(eventDesc);
        }
    }
}
