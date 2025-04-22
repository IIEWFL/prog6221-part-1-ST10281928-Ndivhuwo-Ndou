using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        //Code Attribution
        //This method to play an audion file was taken from stackoverflow
        //https://stackoverflow.com/questions/4125698/how-to-play-wav-audio-file-from-resources
        //Cuty Boy
        //https://stackoverflow.com/users/6075331/cuty-boy
        public static void Play_Audio()
        {
            SoundPlayer welcome = new SoundPlayer(@"IntroAudio.wav");
            welcome.Load();
            welcome.Play();
        }

        public static void Greeting()
        {
            Console.WriteLine("Hi I am Cyfie, I am a cyber security chatbot. What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName} nice to meet you. Welcome, I hope I will be of great help to you\n Ask me anything");
            Response.Basic_Response();
        }
        static void Main(string[] args)
        {
            Display_Art();
            Play_Audio();
            Greeting();
            
        }
    }
}
