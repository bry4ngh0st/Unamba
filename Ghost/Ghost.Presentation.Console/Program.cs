using Ghost.Business.Demo01;
using System;
using System.Configuration;

namespace Ghost.Presentation.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var typeName = ConfigurationManager.AppSettings["messageWriter"];
            var alternativeTypeName = ConfigurationManager.AppSettings["alternativeMessageWriter"];

            var writer = (IMessageWriter)Activator.CreateInstance(Type.GetType(typeName));
            var alternativeWriter = (IMessageWriter)Activator.CreateInstance(Type.GetType(alternativeTypeName));

            var salutation = new Salutation(writer);
            salutation.Exclaim();

            var _salutation = new Salutation(alternativeWriter);
            _salutation.Exclaim();

            System.Console.ReadLine();
        }
    }
}
