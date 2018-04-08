using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello                                 //namespaces prevent similarly named classes from being 
{                                                   //confused with each other, project name will = top level
                                                    //top level namespace
    class Greeting
    {
       
    }
    class Program                                   //defines a class called program and contains a method
                                                    //called Main
    {
        static void Main(string[] args)             //The main method designates the program's entry point   
        {
            Console.WriteLine("Hello World!");      //console is a built in class and writeline is a method
                                                    //within that class that displays the quoted content
        }
    }
}
