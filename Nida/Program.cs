using System;

//Namespace matches up with the project name in this case the project name is Nida(namespace Nida and project name is Nida) 
namespace Nida
{
    //A class is a container which holds a bunch code. 
    class Program
    {
        //container which holds all the code and leads to excecution.
        static void Main(string[] args)
        {
            ///Telling C# to write out Hello World to the console(which is essentialy just a window). Always end lines of code with  a semicolon. 
            Console.WriteLine("Hello World!");
            //keeps console window up until I hit any button from my keyboard which terminates the program :) 
            Console.ReadLine();
        }
    }
}
