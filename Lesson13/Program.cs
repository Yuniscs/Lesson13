using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    /*1.Public delegate yaradin adi OperationDelegate olsun hansi ki float tipinde iki deyer
      qebul edecek ve geriye float deyer qaytarir.
      4 eded static public metod yaradin.Adlari Add,Subtract,Multiply,Divide.Her biri iki float 
      deyer qebul edecek ve geriye float deyer qaytaracag.
      Apply operation metodu yaradin hansi ki float tipinde iki deyer qebul edir ve bir delegate
      qebul edir.Yuxarida sadalanan metodlari o deyerler uzerinde tetbig edir. */
    internal class Program
    {
        public delegate void OperationDelegate(float param1, float param2);


        static void Main(string[] args)
        {
            OperationDelegate account = new OperationDelegate(Add);
            account += Substract;
            account += Multiply;
            account +=Divide;
            account += ApplyOperation;

            account(5.2f,6.5f);//account.Invoke(5.2f,6.5f);
        }

        public static void Add(float x, float y)
        {
            Console.WriteLine(x+y);
            Console.ReadLine();
        }
        public static void Substract(float x,float y)
        {
            Console.WriteLine(x-y);
            Console.ReadLine();
        }
        public static void Multiply(float x,float y)
        {
            Console.WriteLine(x*y);
            Console.ReadLine();
        }
        public static void Divide(float x,float y)
        {
            Console.WriteLine(x/y);
            Console.ReadLine();
        }
        public static void ApplyOperation(float x, float y)//,OperationDelegate z)
        {
            Console.WriteLine(x/((x+y)*y));
            Console.ReadLine();
        }


    }
}
