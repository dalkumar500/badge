using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHALLENGE_3BADGE
{
    class ProgramUI
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();


        //Method that Runs/Start the Application
        public void Run()
        {
            SeedItemsList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display our option to the user
                Console.WriteLine("Select a Menu option:\n" +
                   "1. Create a new badge\n" +
                   "2. Update doors on an existing badge\n" +
                   "3. Delete all doors from an existing badge\n" +
                   "4. Show a list with all badge numbers and door access\n" +
                   "5.Exit");
                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act acoordingly
                switch (input)
                {
                    case "1":
                        //Create A new Badge
                        CreateNewBadge();
                        break;
                    case "2":
                        //Update doors on an existing badge
                        UpdateExicitingdoor();
                        break;

                    case "3":
                        //Delete all doors from an existing badge
                        DeleteAllExistingDoors();
                        break;
                    case "4":
                        //Show a list with all badge numbers and door access
                        ShowAList();
                        break;

                    case "5":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("please enter a valid number");
                        break;
                }
                Console.WriteLine("please press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // create new MenuContent
        private void CreateNewBadge()
        {

            Console.Clear();
            Badge name = new Badge();


            //Badge
            Console.WriteLine("Enter the badgeid:");
            string badgeidASString = Console.ReadLine();
            name.BadgeID = int.Parse(badgeidASString);


            //DoorNames
            Console.WriteLine("Enter the doornames seprated by space: ");
            string doorNames = Console.ReadLine();
            name.DoorNames = doorNames.Split(' ').ToList();

            //A name for the Badge
            Console.WriteLine("Enter the name for the badge:");
            name.Anameforthebadge = Console.ReadLine();

           
          _badgeRepo.Add(name);


        }
        


        //Update doors on an existing badge
        private void UpdateExicitingdoor()
        {

        }

        //Delete all doors from an existing badge
        private void DeleteAllExistingDoors()
        {
            // Get the meal they want to remove
                Console.WriteLine("\nEnter the BadgeID Number you'd like to remove:");

                int input = int.Parse(Console.ReadLine());

                // call  the delete method
                bool wasDeleted = _badgeRepo.RemoveAllDoors(input);

                //If the BadgeID was deleated, say so
                // Otherwise say it could not be deleated
                if (wasDeleted)
                {
                    Console.WriteLine("The BadgeId was successfully deleated");
                }
                else
                {
                    Console.WriteLine("The BadgeId Could not be delated.");

                }

            }
        
        //Show a list with all badge numbers and door access 
        private void ShowAList()
        {
            
        }



        private void SeedItemsList()
        {
            Badge badgeid1 = new Badge(1222, new List <string>{"A4"}, "Steve" );
            Badge badgeid2 = new Badge(1235, new List<string> { "A5" }, "john");
            Badge badgeid3 = new Badge(1240, new List<string> { "B2" }, "Amy");
            Badge badgeid4 = new Badge(1245, new List<string> { "B6" }, "April");
            Badge badgeid5 = new Badge(1250, new List<string> { "A7" }, "Mike");
            _badgeRepo.Add(badgeid1);
            _badgeRepo.Add(badgeid2);
            _badgeRepo.Add(badgeid3);
            _badgeRepo.Add(badgeid4);
            _badgeRepo.Add(badgeid5);
        }

    }
}


