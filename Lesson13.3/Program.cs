using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._3
{
    /*3.Person classiiniz olsun.Icinde firstname ve lastname fieldleri ve her birinci 
        ayriligda console yazan iki metod.Surname ucun ayri metod ve firstname ucun ayri.
        Bu metodlara uygun delegate olsun.Main metodunda classin bir debe obyektin yaradin.
        Ve delegate uzerinden obeyktin  bu iki metodunu iwe salin.*/

    internal class Program
    {
        public delegate void Method1(string frstnm);
        public delegate void Method2(string lstnm);


        static void Main(string[] args)
        {
            Person person=new Person();

            Method1 del_method1 = new Method1(person.method1);
            Method2 del_method2=new Method2(person.method2);

            del_method1("Yunis");
            del_method2("Balakishiyev");
            
        }

    }
    public class Person
    {
        public string Firstname;
        public string Lastname;




        public  void method1(string firstname)
        {
           
            Console.WriteLine(firstname);
            Console.ReadLine();
        }

        public  void method2(string lastname)
        {
            
            Console.WriteLine(lastname);
            Console.ReadLine();
        }
    }
}
