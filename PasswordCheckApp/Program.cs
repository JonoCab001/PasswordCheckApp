using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheckApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool uppercase = true;
            bool symbols = false;

            bool passwordValid = (uppercase && !symbols);

            Console.WriteLine(passwordValid);
            Console.ReadKey();
        }
    }
}
