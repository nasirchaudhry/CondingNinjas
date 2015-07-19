using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// start namespace CodingNinjas
namespace CondingNinjas
{
    /// <summary>
    /// This program will create classes that model a group of coding ninjas from beginner to expert.
    /// </summary>

    // start class Program
    class Program
    {
        // start main method
        static void Main(string[] args)
        {
            string str = "";
            List<Ninjas> squad = new List<Ninjas>();
            
            // do-while statement to get the student names
            do
            {
                // prompt user to enter a student name
                Console.WriteLine("Please enter the name of a student.");                
                squad.Add(new Ninjas(Console.ReadLine()));

                // prompt if user want to add more student
                Console.WriteLine("Press enter to add another student or press any key then enter to move forward.");
                str = Console.ReadLine();
            } while (string.IsNullOrEmpty(str));

            // calculate the level and rank of a student based on programs completed and people helped
            foreach (Ninjas n in squad)
            {
                // prompt user for number of programs completed
                Console.WriteLine("{0} Please enter the number of programs you've completed.", n.Name);                
                int prog = int.Parse(Console.ReadLine());                
                n.levelUp(prog);

                // prompt user for number of people helped
                Console.WriteLine("{0} Please enter the number of people you've helped.", n.Name);                
                prog = int.Parse(Console.ReadLine()) * 2;               
                n.levelUp(prog);
            }//end foreach loop

            // print out the result
            foreach (Ninjas n in squad)
            {
                n.print();
            }
        }// end main Method
    }// end class Program

    // start class Ninjas
    class Ninjas
    {
        //Initialize variables
        public string Name { get; private set; }
        int Level { get; set; }
        string Rank { get; set; }

        public Ninjas(string n)
        {
            Rank = "Beginner";
            Level = 0;
            Name = n;
        }

        //Level up ninja
        public void levelUp(int c)
        {
            //Increase levels by c
            Level += c;
            getRank(Level);
        }
        //Change ninja's rank based on amount of levels
        private void getRank(int lvl)
        {
            if (lvl > 0 && lvl < 5)
            {
                Rank = "Beginner";
            }
            else if (lvl >= 5 && lvl < 10)
            {
                Rank = "Grasshopper";
            }
            else if (lvl >= 10 && lvl < 15)
            {
                Rank = "Journeyman";
            }
            else if (lvl >= 15 && lvl < 20)
            {
                Rank = "RockStar";
            }
            else if (lvl >= 20 && lvl < 25)
            {
                Rank = "Ninja";
            }
            else if (lvl >= 25)
            {
                Rank = "Jedi";
            }
        }

        //Print out ninja's name, level and rank
        public void print()
        {
            Console.WriteLine("Name: {0} Level: {1} Rank: {2}", Name, Level, Rank);
        }
    }// end class Ninjas
}// end namespace CodingNinjas