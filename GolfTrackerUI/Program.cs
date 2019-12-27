using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfTrackerLibrary.Models;


namespace GolfTrackerUI
{
    class Program
    {
        /* 
         * Record Stats
         */
        static void Main(string[] args)
        {
            //TODO: Ask if Player has an account
            //TODO: Enter the golf course
            //TODO: Player enter holes
            //TODO: Fill class and save to Json


            // Models sending to data Layer using Json



            PlayerModel tim = new PlayerModel("Tim Taylor",51,4);

            Console.WriteLine("golfer's First Name {0}",tim.golfName);
            Console.WriteLine("golfer's age {0}", tim.age);
            Console.WriteLine("golfer's handicap {0}", tim.handicap);
            List<string> players = new List<string>();

            do
            {
                players.Add(GetName());

            } while (!players.Contains(GetName()));

            Console.WriteLine("Your name has already been added to the app");

            GetNumHoles();

            Console.ReadLine();
            Console.Read("test");
        }

        private static string GetName()
        {
            Console.WriteLine("What is your name: ");
            string output = Console.ReadLine();
            return output;
        }

        private static int GetNumHoles()
        {
            Console.WriteLine("How many holes did you play : ");
            string ghole = Console.ReadLine();
            bool isValidHole = int.TryParse(ghole, out int output);
            return output;
        }

        
    }   
}
