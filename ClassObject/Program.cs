using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Humanbeing Hb = new Humanbeing(); // create object of humanbeing class  memory allocated in heap and address of object stored in Stack memory
            // Humanbeing hb;
            // Hb.Human();

            //  Console.ReadKey();
            // imobile objim = new imobile();
            //  objim.simslot();


            //  Evenodd ed = new Evenodd();
            //  Console.WriteLine("Please  enter the  number");
            //   int first = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Enter Second number");
            //  int Second = int.Parse(Console.ReadLine());
            //   ed.checknumber(first);

            Test tcobj = new Test();
            tcobj.PrintDay();

            Console.ReadKey();


        }
    }

    class Humanbeing
    {
        public void Human() // it class method
        {
            Console.WriteLine("i am calling Humanbeing class method using class object"); 
        }
    }

    class Evenodd
    {
        public void checknumber(int a)
        {
           // int c = a%2 ;
            if ( a%2 == 0)
            {
                Console.WriteLine("it a even number {0}", a);
            }
            else
            {

                Console.WriteLine("it a odd number {0}",a);
            }
            
           // Console.WriteLine("sum", c);
           // Console.WriteLine("{0}+{1}={2}", a,c);

        }

    }

    interface imobile

    {
         void simslot();

    }

    //CP child an Parent
    //Test is child or drived class
    //Employe is parent or base class


    public class Test : Employe
    {

        public void PrintDay()
        {
            GetDay();
          //  base.GetDay();
           // this.GetDay();

        }

    }
         
}
