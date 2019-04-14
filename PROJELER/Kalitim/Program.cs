using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.ReadKey();
        }
    }



    public class A : B
    {
        public string averisi;

        public A()
        {
            Console.WriteLine("A Klasım oluştu");
        }
    }


    public class B : C
    {

        public string bverisi;
        public B()
        {
            Console.WriteLine("B Klasım oluştu");
        }
    }

    public class C:D
    {
        public C()
        {
            Console.WriteLine("C Klass Oluştu");
        }

        public C(string c)
        {
            Console.WriteLine("C parametreli cons. oluştu oluştu {0}", c);

        }
    }

    public  class D
    {

    }




}
