using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PR5___Task_1
{
    internal class Program
    {
        public string[] SplitText(string text)
        {
            char[] separators = new char[] {' ', '.'};
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return subs;
        }
        public void OutputText(string[] subs)
        {
            foreach (string sub in subs)
            {
                Console.WriteLine($"{sub}");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            var mc = new Program();
            Console.WriteLine("Введите свое предложение");
            string text = Console.ReadLine();
            mc.SplitText(text);
            mc.OutputText(mc.SplitText(text));
        }
    }
}
