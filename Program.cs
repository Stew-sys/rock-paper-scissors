using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace rock_paper_scissors
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //user input/output

            Console.WriteLine("Please enter your name");
            String Name = Console.ReadLine();
            Console.WriteLine("Hi, " + Name + ". Lets play rock paper scissors I will let you go first, please enter one of rock, paper or scissors now!");
            string input1 = Console.ReadLine();


            //random move from computer (computermove)

            string[] computersgo = ["Rock", "Paper", "Scissors"];
            Random computersgo1 = new Random();
            int randomnumber = computersgo1.Next(3);
            string compmove = computersgo[randomnumber];           

            {
                if (compmove == input1)

                    Console.WriteLine("A draw try again to beat me");

                else if (compmove == "Rock" && input1 == "Scissors" || compmove == "Scissors" && input1 == "Paper" || compmove == "Paper" && input1 == "Rock") 
               
                    Console.WriteLine("Computer Wins");


                else if (input1 == "Rock" && compmove == "Scissors" || input1 == "Scissors" && compmove == "Paper" || input1 == "Paper" && compmove == "Rock")


                    Console.WriteLine("Human Wins");

            }


    Console.WriteLine();    

            // replay if there is a draw

            // use objects if you can

            //extra marks if anything cool
            
        }
    }
}


