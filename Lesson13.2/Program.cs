using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._2
{
    /*2.Cat classiniz olsun.Ichinde onun mood,hungry,energy deye fieldleriniz olsun.
      Lakin bu fieldlerinkenardan modifybetmek mumkun olmur.Sadece Play(), Feed(),Sleep() 
      metodlari vasitesile o fieldleri deyiwmek olsun.Hansi metodlar hansi fieldler nece
      deyiwecek onu siz fikirleshin zehmet olmasa.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat play=new Cat();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class Cat
    {
       private string  mood;
       private string hungry;
       private string energy;

        static void Play(string _energy)
        {               
            _energy = "ball";
        }
        static void Feed(string _hungry)
        {
            _hungry = "fish";
        }
        static void Sleep(string _mood)
        {
            _mood = "active";
        }
    }
}
