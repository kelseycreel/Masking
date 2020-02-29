using System;

namespace Masking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a secret...");
            var secrets = Console.ReadLine();

            var outputSecrets = secrets.Substring(secrets.Length - 4).PadLeft(secrets.Length, '*');

            Console.WriteLine(outputSecrets);
            Console.ReadKey();
        }
    }
}
