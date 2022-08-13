using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Intro....... */


            Console.WriteLine("This is the InfoSec Common Words Quiz Game \n");

            /* Asking user their name and surname */

            Console.Write("What is your Name : ");
            string name = Console.ReadLine();   
            Console.WriteLine("What's your Surname: ");
            string lastname = Console.ReadLine();   

            Console.WriteLine("Welcome :)  " + " " + name  + " " +  lastname  );


            Console.WriteLine("=============================================== \n");

            /* Console.Write("Do you want to play Game ? : \n");*/

            /* Asking user if they want to Play the Quiz Game , if yes then quiz begin... if not then the quiz end*/

            string playing = name + " " + "Do yo want to Play ? ";  
            string quiz = "Quiz Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(playing, quiz, buttons);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine(" Okay , Lets Play .......Goodluck :) \n");
            }

            else
            {
                System.Environment.Exit(0);

            }

            Console.WriteLine("================================================ \n");

            /* This is Number 1 Question and Expected Answer */

            int Score = 0;

            Console.Write("1. What's DoS Stand For ? \n");
            string answer1 = Console.ReadLine();
                 if(answer1 == "Denail of Service" )
            {
                Console.WriteLine("It's Correct");
                Score +=1;
            }
          
            
            else
            {
                Console.WriteLine("Incorrect");
            } 
                     
            /* This is Number 2 Question and Expected Answer */

            Console.Write("2. What's HTTP Stand For ? \n");
             string answer2 = Console.ReadLine();
            if (answer2 == "HyperText Transfer Protocol")
            {
                Console.WriteLine("It's Correct");
                Score +=1;

            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            /* This is Number 3 Question and Expected Answer */
            Console.Write("3. What's SSL Stand For ? \n");
            string answer3 = Console.ReadLine();
            if (answer3 == "Secure Sockets Layer")
            {
                Console.WriteLine("It's Correct");
                Score +=1;

            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            /* This is Number 4 Question and Expected Answer */
            Console.Write("4. What's ARP Stand For ? \n");
            string answer4 =Console.ReadLine();
            if (answer4 == "Address Resolution Protocol")
            {
                Console.WriteLine("It's Correct");
                Score +=1;

            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            /* This is Number 5 Question and Expected Answer */
            Console.Write("5. What's RAT Stand For ? \n");
            string answer5 =Console.ReadLine();
            if (answer5 == "Remote Access Trojan")
            {
                Console.WriteLine("It's Correct");
                Score +=1;

            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.ReadLine();

            Console.WriteLine("=============================================== \n");

            Console.WriteLine("You Got "  + Score + "/5 " + " Questions Correct !!!");
            Console.WriteLine("=============================================== \n");

            Console.ReadLine();

        }
    }
}
