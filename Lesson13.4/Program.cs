using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._4
{
    /*4.Mobil telefon mentigi uzerinden  abstraction,encapsulation,polymorpishm ve lnheritance conceptkerini
        tetbig edib yazmaga caliwin.yeni Mobile classiniz olacag ve ona uygun ferqli markalar olacag(samsung,nokia ve s)*/

    //encapsulation
    internal class Program
    {
        static void Main(string[] args)
        {
            //polymorpishm,inheritance
            Marka marka = new Marka();
            marka.print("nokia","samsung");
            Console.ReadLine();

            //abstract class
            Samsung sam = new Samsung();
            String descb = sam.Describe();
            Console.WriteLine(descb);
            Console.ReadLine();

        }
    }
    //polymorpishm Runtime,Dynamic
     class Mobile
    {
        public void print()
        {
            Console.WriteLine("Printing from class Mobile:");
            Console.ReadLine();
        }
    }
    //inheritance
    class Marka :Mobile
    {
        public void print(string a,string b)
        {
            Console.WriteLine("Printing from class Marka:" + (a + "," + b));
            Console.ReadLine();
        }
    }
    //abstract class
    abstract class _Mobile
    {
        public virtual string Describe()
        {
            return "Description of the Mobile:";
        }
    }
    class Samsung : _Mobile
    {
        public override string Describe()
        {
            return "Description of the Mobile2 is now Samsung";
        }
    }
}
