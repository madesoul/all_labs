using System.Threading;

namespace Task8
{
    public class Mechanic : ProgressingEntity
    {
        protected override void Work()
        {
            Interlocked.Add(ref this.progress, -1);
        }

        public override void Request(object owner)
        {
            base.Request(owner);
            Interlocked.Add(ref this.progress, 100);
        }
    }
}
