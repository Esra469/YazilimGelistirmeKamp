using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();//T olarak belirtildiği için bir type verilmeli

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

        }
    }
}
