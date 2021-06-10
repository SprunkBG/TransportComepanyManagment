using System;

namespace TransportComepanyManagementConsoleVersion
{
    class Program
    {
        static void Main(string[] args)
        {

            TollPass tollPass = new TollPass(6, 300);

            Console.WriteLine(tollPass);

        }
    }
}
