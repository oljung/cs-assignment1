//Patrik Österljung 2021-01-23
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1Part2
{
    class Bed
    {
        #region Instance variables
        //Variables for input date and time
        private string room;
        private int size;
        private double hight;
        private string currentTime;
        private bool isOccupied;
        #endregion

        #region Start
        //Inforamation displayed at start up and method to call necessary methods
        public void Start()//Method to call input and display methods and get current time
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("Welcome the your bed organizer!");
            Console.WriteLine("Please follow the instructions to register a bed.");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            ReadInput();
            GetCurrentTime();
            DisplayData();
            Console.WriteLine();
            Console.WriteLine("Press enter to exit the application");
            Console.ReadLine();
        }
        #endregion

        #region Input and time
        //Handles all input and gets current time
        public void ReadInput()
        {
            ReadRoom();
            ReadSize();
            ReadHight();
        }

        void ReadRoom()//Stores name of the room in string variable room
        {
            Console.WriteLine("In what room is the bed located?");
            room = Console.ReadLine();
        }

        void ReadSize()//Converts string input to integer and stores it in int variable size
        {
            Console.WriteLine($"How large is the bed in {room}? (cm)");
            size = int.Parse(Console.ReadLine());//Feel confident enough to use this way now
        }

        void ReadHight()//Converts srting input to decimal number and stores it in double variable hight
        {
            Console.WriteLine("How high is the bed? (m)");
            hight = double.Parse(Console.ReadLine());
        }

        void GetCurrentTime()
        {
            currentTime = DateTime.Now.ToString("t");
        }
        #endregion

        #region Display data
        //Methods for displaying information about the bed
        public void DisplayData()
        {
            Console.WriteLine("---------------------------------------");//creates a box-like structure
            DisplayRoom();
            DisplaySize();
            DisplayHight();
            DisplayStatus();
            Console.WriteLine("---------------------------------------");//creates a box-like structure
        }

        void DisplayRoom()//Display room with proper alignment
        {
            Console.WriteLine($"Room:  {room,15}");
        }

        void DisplaySize()
        {
            Console.WriteLine($"Size:  {size,15}");
        }

        void DisplayHight()
        {
            Console.WriteLine($"Hight: {hight,15}");
        }

        void DisplayStatus()
        {
            SetStatus();
            string toText;
            if (isOccupied)
                toText = "The bed is occupied.";
            else
                toText = "The bed is empty.";
            Console.WriteLine("The current time is " + currentTime);
            Console.WriteLine(toText);
        }

        void SetStatus()//Checks the current hour and sets bed status accordingly
        {
            string strHour = currentTime.Remove(2);//extracts the first two chars representing hour
            int hour = int.Parse(strHour);
            if (hour >= 6 && hour < 22)//Checks if bed should be occupied or not
                isOccupied = false;
            else
                isOccupied = true;
        }
        #endregion
    }
}
