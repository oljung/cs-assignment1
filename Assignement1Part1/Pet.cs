//Patrik Österljung 2021-01-23
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement1Part1
{
    class Pet
    {
        #region Input variables
        //Variables for storing input data
        private string name;
        private int age;
        private bool isFemale; //After some consideration I opted to follow your lead on this one
        #endregion
        //Method for starting the class
        #region Start
        public void Start()
        // I liked the structure you provided with handling all other methods with a start method
        {
            //Nice to have some sort of welcome phrase
            Console.WriteLine("******************************************************");
            Console.WriteLine("Welcome the your pet handling service!");
            Console.WriteLine("Please follow the instructions to register your pet");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            ReadInput();
            DisplayData();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue to next object");
            Console.ReadLine();
            //The class would usually end with another object beeing addad, either a new pet or other
            //class. Exiting program would be called with another method corresponding to a different key
        }
        #endregion

        #region Input method and parts
        public void ReadInput()//Method that calls the methods for reading name, age and gender
        {
            ReadName();
            ReadAge();
            ReadGender();
        }

        void ReadName()//Reads user input and stores name as a string in "name" variable
        {
            Console.WriteLine("Please enter the name of your pet: ");
            name = Console.ReadLine();
        }

        void ReadAge()//Reads user input and converts the string into integer and stores in age
        {
            Console.WriteLine($"How old is {name}?  ");
            string strAge = Console.ReadLine(); //Variable for storing input string
            age = int.Parse(strAge);
        }

        void ReadGender()//Reads user input of char and translates that into a boolean value true/false
        {
            Console.WriteLine($"Is {name} a female? (y/n) ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim();//Make sure string starts with a letter and not whitespace
            char answer = strGender[0];
            //I decided to follow the structure of the example on this one, but why not just check 
            //for a one letter string, like "y" or "Y" and save the trouble of converting to a char?
            //Is there any performance benefit to this? Technically, it would do the same thing, no?
            //Is it purely to protect from a user input of more letters?
            
            if (answer == 'y' || answer == 'Y')//Translates user input to a boolean value
                isFemale = true;
            else
                isFemale = false;
        }
        #endregion

        #region Display data
        public void DisplayData()
        {
            Console.WriteLine("--------------------------");//creates a box-like structure
            DisplayName();
            DisplayAge();
            DisplayGender();
            Console.WriteLine("--------------------------");//creates a box-like structure
        }

        void DisplayName()//Displays name, aligned to match age
        {
            Console.WriteLine($"Pet name: {name, 15}");
        }

        void DisplayAge()//Displays age, aligned to match name
        {
            Console.WriteLine($"Age:      {age, 15}");
        }

        void DisplayGender()
        {
            string toText;
            if (isFemale)
                toText = $"{name} is a good girl!";
            else
                toText = $"{name} is a good boy!";
            Console.WriteLine(toText);
        }
        #endregion
    }
}
