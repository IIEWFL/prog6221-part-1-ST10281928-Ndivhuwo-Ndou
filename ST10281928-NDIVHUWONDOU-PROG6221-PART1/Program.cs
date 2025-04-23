using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ST10281928_NDIVHUWONDOU_PROG6221_PART1
{
    
    class Program
    {
        //Code attribution
        //The code to display the ASCII art was taken from stackoverflow
        //https://stackoverflow.com/questions/3436132/producing-ascii-art-via-c-sharp
        //YT_GraphiX
        //https://stackoverflow.com/users/17660250/yt-graphix

        public static void Display_Art()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string art = @"                                                                                                                                                                      
                                                                 .:.                                
                                   +-        .=-.              .:+-.   =-                           
                                   +-         .-+-.          .:+-.     ==                           
                                   +-           .=-.        :+-.       ==                           
                                   +-           .==.     ..*+.         ==                           
                                   +-           .==.     -+.           ==                           
                           :=-.    -:        .-:.==.     -=.           ==                           
                          :*:+:         :+.  .+-:++:.    -=.+.         ..                           
                .:----:.   .*:          :+:=**+-::::-+**===:*.                                      
                 ......     *:       .:++===++=-:..:-=++===+#-.                                     
                            *:     :++-=*+-..          ..-+*=-++:                                   
                            *:    -*.*=.                    .=*.*-         :+=.                     
                            *:    -*-+.     .-+######+-.     .+-*-        .*-+-.                    
                            *:.:::=*-+.  .:*#-:*.==.*:-#*:.  .+-*-       .-*:..                     
                            #:....-*-+. .++#:.+=.==.=+.:#++. .+-*-      .=+.                        
                            -=====+*-+..*+**=+*==**==*+=**+*..+-*-.... .++-*+.                      
                                  -*-+.++:*. -+..==..+- .*:++.+-****+:.*=:++-.                      
                .-++++++++=.      -*-+.#--*::=+::++::+=::*--#.+-**+++**:   .:.                      
                ............      -*-+.#--*:.=+::==::+=.:*--#.+-*-...-+.                            
                   :#**:::::::::::=*-+.++:*. -+..==..+- .*:++.+-*-   -+.                            
                   .+*=.=+....:---=*-+..*=*+-=*=-++-=*=-+*=*..+-*-   -+.                            
                        =+   .::::-#:*. .*+#-:+=:++:=+:-#+*. .*:#:   -+.                            
                        =+         *=*:  .-%#::#.==.#::#%-.  -+=*    ::. :*#######=.                
                        --         :#=*:    :+*#****#*+:    :*=#:                                   
                                    :*=#=.                .=#=*=*-.                                 
                                   .+*#=-#-.            .-#-=*+#-:.                                 
                                ..=#:..##--#*:..    ..:*#--#=*. +*:.                                
                                .=-..++..-*+:-**+--+*+-:+*#=:*. .::.                                
                                  .+*:.    .-+*+----+*+-. +=:*.       :=                            
                                .=*:.         ..:++:..    =-:%%%#.    -*                            
                .-+++++++=.     .*-     ...     .==.    ....:*.       -*                            
                                .*-     .+-     .==.    -+++**.       -*                            
                          :*######-     .+-     .==.       :#*+.      -*                            
                                .*-     .+-     .==.       .%%+.      -#                            
                               .%*#:    .+-     .==.                  -#                            
                                =*=.    .+-     .==.                  -#                            
                                        .::     .::.                  :-                            
                                                                                         
                                                                                                    
                                                                                                    ";
            Console.WriteLine(art);
            Console.ResetColor();
        }

        //Code Attribution
        //This method to play an audion file was taken from stackoverflow
        //https://stackoverflow.com/questions/4125698/how-to-play-wav-audio-file-from-resources
        //Cuty Boy
        //https://stackoverflow.com/users/6075331/cuty-boy
        public static void Play_Audio()
        {
            //This is a SoundPlayer object which will be used to call the wav audio
            //The audio is located in the bin> Debug
            SoundPlayer welcome = new SoundPlayer(@"IntroAudio.wav");
            welcome.Load();
            welcome.Play();
        }

        public static void Greeting()
        {
            typingEffect("Hi your I am a cyber security chatbot.\nI am here to assist you with learning more\n" +
                "about cyber security and being safe online.\n" +
                "Why don't we start off by you telling me your name?"
            );


            //Code Attribution
            //This code is to change the colour of the text and I got it from geeksforgeeks
            //https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/
            //Geeksforgeeks


            Console.ForegroundColor = ConsoleColor.Green;
            string userName = Console.ReadLine();
            Console.ResetColor();
            //This will check if the name variable is empty or not
            while (string.IsNullOrEmpty(userName))
            {
                
                typingEffect("Please re-enter your name");
                Console.ForegroundColor = ConsoleColor.Green;
                userName = Console.ReadLine();
                Console.ResetColor();
            }

            typingEffect($"{userName} nice to meet you. Welcome, I hope I will be of great help to you\nAsk me anything\n" +
                $"Type 'exit' to stop the chatbot\n");
           
            Response.Basic_Response();
        }
        //This method will check if the userName is empty or not 
        public static string Get_Name(string name)
        {
            if (name == "")
            {
                return "empty";
            }
            return "filled";
        }
        static void Main(string[] args)
        {
            Display_Art();
            newLine();
            Play_Audio();
            Greeting();
            
        }

        public static void newLine()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n" + new string('=', 90) + "\n");
            Console.ResetColor();
        }

        //Code Attribution
        //This is the method for the typewriter effect
        //joshschmelzle
        //https://gist.github.com/joshschmelzle/610451c749dd14bb777a?utm

        /*This method is to create a type writing effect where the messages will be
        printed out leter by letter with a delay*/
        public static void typingEffect(string message, int delay = 30)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //A for-loop to store the message and break it down by its characters
            foreach(char ch in message)
            {
                Console.Write(ch);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
