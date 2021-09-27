//Patrik Österljung 2021-01-23
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement1Part1
{
    class Album
    {
        #region Input variables
        //Variables for storing input data
        private string albumName;
        private string artistName;
        private int numberOfTracks;
        #endregion

        #region Start
        //Starts class and calls necessary methods
        public void Start()
        {
            //Follows the same model as Pet class for consistency
            Console.WriteLine("******************************************************");
            Console.WriteLine("Welcome the your album registration app!");
            Console.WriteLine("Please follow the instructions to register a new album");
            Console.WriteLine("******************************************************");
            Console.WriteLine();
            ReadInput();
            DisplayData();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue to exit");
            Console.ReadLine();
        }
        #endregion

        #region Input method and parts
        public void ReadInput()// public "just in case"
        {// Calls the methods for storing data on album name, artist and nr. of tracks
            ReadAlbumName();
            ReadArtistName();
            ReadNumberOfTracks();
        }

        void ReadAlbumName()
        {//Stores name of album in the string variable albumName
            Console.WriteLine("What is the name of the album? ");
            albumName = Console.ReadLine();
        }

        void ReadArtistName()
        {//Stores name of artist in the string variable atistName
            Console.WriteLine($"Name the artist/band who made {albumName}: ");
            artistName = Console.ReadLine();
        }

        void ReadNumberOfTracks()
        {//Converts the input string to integer and stores in int varibale numberOfTracks
            Console.WriteLine($"How many tracks does {albumName} have? ");
            string strNumOfTracks = Console.ReadLine();
            numberOfTracks = int.Parse(strNumOfTracks);
        }
        #endregion

        #region Display data
        public void DisplayData()//public "just in case"
        {//Calls methods for displaying data
            Console.WriteLine("---------------------------------------");//creates a box-like structure
            DisplayAlbumName();
            DisplayArtistName();
            DisplayNumberOfTracks();
            Console.WriteLine("---------------------------------------");//same structer as Pet class for consistency
        }

        void DisplayAlbumName()//Display album name, aligned to match artist
        {
            Console.WriteLine($"Album name:       {albumName,20}");
        }

        void DisplayArtistName()
        {
            Console.WriteLine($"Artist name:      {artistName,20}");
        }

        void DisplayNumberOfTracks()
        {
            Console.WriteLine($"Number of tracks: {numberOfTracks,20}");
        }
        #endregion
    }
}
