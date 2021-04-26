using System.Threading;

namespace Task8
{
    public class Loader2 : ILoader
    {
        public void Dispatch()
        {
            Thread.Sleep(10000);
        }
    }
}
