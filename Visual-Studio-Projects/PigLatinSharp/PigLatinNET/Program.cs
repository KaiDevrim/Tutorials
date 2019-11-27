using System;

namespace PigLatinNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repeat the program
            bool on = true;
            while(on == true) {
            
            //Get the user input and store it
            Console.WriteLine("Type what you want to convert, say stop to stop the program");
            string userText = Console.ReadLine();
            

            //Make each word seperate and save them to a list
            string[] userSplice = userText.Split(' ');

                //Loop over each word in user input
                foreach (var word in userSplice)
                {
                    //Get the first letters of each word
                    string letters = word.Substring(0, 1);
                    //Remove the first letter of each word
                    string newWords = word.Remove(0, 1);
                    
                    //Print the finalized Pig Latin statement
                    Console.WriteLine(newWords + letters + "ay");
                }

                //Turn the program off
                if(userText == "stop")
                {
                    on = false;
                }
            }
        }
    }
}

//Get user input - DONE
//Store user input - DONE
//Make each word seperate - DONE
//Save the words to a list - DONE
//Save the first letter of each item to a list - DONE
//Remove the first letter - DONE
//Make a different string without the first letter - DONE
//Add the letter to the end of the word - DONE
//Add -ay to the end of each word - DONE