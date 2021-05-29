using System;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = SerialPortParser.ParsePort("COM1");
            Console.WriteLine($"Port: {port}");
        }
    }
}
