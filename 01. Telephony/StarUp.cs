using System;
using Telephony.Core;

namespace Telephony
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
