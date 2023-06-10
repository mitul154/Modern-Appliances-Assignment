﻿using System.Globalization;
using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {

        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            long item_number;
            // Get user input as string and assign to variable.
            string itemNumberTemp = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            item_number = long.Parse(itemNumberTemp);
            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance? foundAppliance;
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;
            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            // Break out of loop (since we found what need to)
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == item_number)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            if (foundAppliance!=null)
            {
                if (foundAppliance.IsAvailable)
                {
                    Console.WriteLine($"Appliance \"{foundAppliance.ItemNumber}\" has been checked out.");
                    foundAppliance.Checkout();
                }

                // Write "Appliance has been checked out."
                // Otherwise (appliance isn't available)
                // Write "The appliance is not available to be checked out."
                if (!foundAppliance.IsAvailable)
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");
            // Create string variable to hold entered brand
            string enteredBrand;
            // Get user input as string and assign to variable.
            enteredBrand = Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand == enteredBrand)
                {
                    foundAppliances.Add(appliance);
                }
            }


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);

        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int numOfDoors;
            // Get user input as string and assign to variable
            string? numOfDoorsTemp = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            numOfDoors = int.Parse(numOfDoorsTemp);
            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            foreach (var appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numOfDoors == 0)
                        foundAppliances.Add(refrigerator);
                    else
                    {
                        if (refrigerator.Doors == numOfDoors)
                        {
                            foundAppliances.Add(refrigerator);
                        }
                    }
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any\n1 - Residential\n2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");
            // Get user input as string and assign to variable
            string gradeTemp = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            switch (gradeTemp)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }


            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any\n1 - 18 Volt\n2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");
            // Get user input as string
            string voltTemp = Console.ReadLine();
            // Create variable to hold voltage
            int volt;
            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            switch (voltTemp)
            {
                case "0":
                    volt = 0; 
                    break;
                case "1":
                    volt = 18;
                    break;
                case "2":
                    volt = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach (var appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (grade == "Any" && volt == 0)
                    {
                        found.Add(vacuum);
                    }
                    else if (grade == vacuum.Grade && volt == vacuum.BatteryVoltage) 
                    {
                            found.Add(vacuum);
                    }
                    else if (grade == "Any" && volt ==  vacuum.BatteryVoltage) { found.Add(vacuum); }
                    else if (grade == vacuum.Grade && volt == 0) { found.Add(vacuum); }
                }
            }
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any\n1 - Kitchen\n2 - Work site");
            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string roomTypeTemp = Console.ReadLine();
            // Create character variable that holds room type
            char ch;
            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            switch (roomTypeTemp)
            {
                case "0":
                    ch = 'A'; 
                    break;
                case "1":
                    ch = 'K';
                    break;
                case "2":
                    ch = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            foreach (var appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (ch == 'A')
                    {
                        foundAppliances.Add(microwave);
                    }
                    else if (microwave.RoomType == ch) foundAppliances.Add(microwave);
                }
            }

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any\n1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string dishWasherTypeTemp = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;
            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            switch (dishWasherTypeTemp)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            // Create variable that holds list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            foreach (var appliance in Appliances)
            {
                if (appliance.Type == Appliance.ApplianceTypes.Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any")
                        foundAppliances.Add(dishwasher);
                    else if (soundRating == dishwasher.SoundRating)
                        foundAppliances.Add(dishwasher);
                }
            }
            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("0 - Any\n1 – Refrigerators\n2 – Vacuums\n3 – Microwaves\n4 – Dishwashers");
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances");
            // Get user input as string and assign to variable
            string numTemp = Console.ReadLine();
            // Convert user input from string to int
            int num = Int32.Parse(numTemp);
            // Create variable to hold list of found appliances
            List<Appliance> foundAppliances = new List<Appliance>();
            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            foreach (var appliance in Appliances)
            {
                if (applianceType == "0")
                {
                    foundAppliances.Add(appliance);
                }

                if (applianceType == "1")
                {
                    if (appliance.Type == Appliance.ApplianceTypes.Refrigerator)
                    {
                        foundAppliances.Add(appliance);
                    }
                }

                if (applianceType == "2")
                {
                    if (appliance.Type == Appliance.ApplianceTypes.Vacuum)
                        foundAppliances.Add(appliance);
                }
                if (applianceType == "3")
                {
                    if (appliance.Type == Appliance.ApplianceTypes.Microwave)
                        foundAppliances.Add(appliance);
                }
                if (applianceType == "4")
                {
                    if (appliance.Type == Appliance.ApplianceTypes.Dishwasher)
                        foundAppliances.Add(appliance);
                }


            }
            // Randomize list of found appliances
            // found.Sort(new RandomComparer());
            foundAppliances.Sort(new RandomComparer());
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            DisplayAppliancesFromList(foundAppliances, num);
        }
    }
}
