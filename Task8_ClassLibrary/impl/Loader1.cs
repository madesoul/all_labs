using System.Threading;

namespace Task8
{
    public class Loader1 : ILoader
    {
        public void Dispatch()
        {
            Thread.Sleep(11000);
        }
    }
}
