using System;

namespace Ghost.Business.Demo01
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message + " - Console");
        }
    }
}
