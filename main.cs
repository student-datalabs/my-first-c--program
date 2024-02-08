using System;
using System.Collections.Gemeric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
   {
      class Programm
      { 
           static void Main(string[] args)
           {
              string message = "Hello World!!  This is me!";

                Console.WriteLine(message);
                
                for( int i = 0; i< 10; i++)
                {
                   Console.WriteLine("Value of i: {0)", i);
                }
           }
      }
}
