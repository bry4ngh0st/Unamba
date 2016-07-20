using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghost.Business.Demo01
{
    public class FileMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message + " - File");
        }
    }
}
