using System;

class Response
    {
    public static void Basic_Response()
    {
        
        string run = "yes";

        while (run == "yes")
        {

            string userinput = Console.ReadLine();
            
                
                switch (userinput)
                {
                    case "What is your purpose":
                        Console.WriteLine("I am a chat bot that specialises in cyber security.\n" +
                            "I am here to assist you in understanding cyber security and give you tips on\n" +
                            "how to keep yourself safe and prevent any attacks from happening while on the internet.\n");
                        break;
                    case "How are you":
                        Console.WriteLine("I am great. How are you?");
                        Console.ReadLine();
                        break;
                    case "What can I ask you about":
                        Console.WriteLine("The topics I currently have knowledge on are:" +
                        "\n--Password Safety" +
                        "\n--Phishing" +
                        "\n--Safe browsing\n");
                        userinput = Console.ReadLine();
                        break;
                    case string x when x.Contains("password"):
                        Topic_Information(x);
                        break;
                    case string x when x.Contains("phishing"):
                        Topic_Information(x);
                        break;
                    case string x when x.Contains("browsing"):
                        Topic_Information(x);
                        break;
                default:
                        Console.WriteLine( new Exception("Sorry I did not get the request please enter again"));
                    break;    
                }
                
                if (userinput == "exit")
                {
                    run = "no";
                }

            
        }

        
    }

    public static void Topic_Information(string topic)
    {
        switch (topic)
        {
            //Code Attribution
            //This method to use a string in a swicth-case was taken from stackoverflow
            //https://stackoverflow.com/questions/3853700/c-sharp-switch-case-string-starting-with
            //Raul Bojalil
            //https://stackoverflow.com/users/7550948/ra%c3%bal-bojalil
            case string j when j.Contains("password"):
                Console.WriteLine("======================================= PASSWORD SAFETY =========================================\n" +
                    "Password safety is how secure your password is. The more secure your password\n" +
                    "is the more difficult it is to crack. Your password is the protector of you private\n" +
                    "information if it gets cracked then everything will be stolen by the attackers. In a work\n" +
                    "environment having a secure password is very crucial because if you do not you could be the\n" +
                    "reason why attackers gain information to comapny information and that is very valuable information.\n" +
                    "======================================= PASSWORD ATTACKS =========================================\n" +
                    "*Brute Force Attack - This is where the attacker will try every possible combination\n" +
                    "   for your password until they get it right.\n" +
                    "*Phishing - The attacker send you an email or text message pretending to be a trusted source\n" +
                    "   and then asks you to enter you login details.\n" +
                    "======================================= PASSWORD SAFETY TIPS =========================================\n" +
                    "*Create a complex password, a password that invloves special characters, numbers and different letters.\n" +
                    "  e.g. $ND1VH4w@I$7h3B3#7\n" +
                    "Change your password regurlarly.\n" +
                    "  e.g. Every month or twice a year\n" +
                    "*Do not click suspicious links \n" +
                    "  e.g. http://Amazonisgood.com \n");
                break;

            case string j when j.Contains("phishing"):
                Console.WriteLine("======================================= PHISHING =========================================\n" +
                    "Phishing is the act of sending fauls communication to someone\n" +
                    "and making it look like it comes from a trustworthy source such as a corporation or\n" +
                    "someone you know in order to gain access to sensitive information or financial gain.\n" +
                    "Phishing is usually done through emails or text messages. For know we are going to focus\n" +
                    "on Email Phishing. Just like I explained what phishing is, email phing is the same thing\n" +
                    "but done via emails. With email phishing you will be getting fraudulent emails thinking they are\n" +
                    "coming from a trusted source.\n" +
                    "======================================= HOW THE ATTACK WORKS =========================================\n" +
                    "*You will get an email that uses a fear, curiosity, greed ,or ugency tactics\n" +
                    "   to get you to open the email.\n" +
                    "*You the email thinking it is safe and looks legitimate.\n" +
                    "*There will be a link in the email that you are urged to click\n" +
                    "*Once you click the link it will ask ou to perform an action such as login\n" +
                    "or download a file. once the action is performed the attackers have gained information.\n" +
                    "======================================= HOW TO PREVENT THE ATTACKS =========================================\n" +
                    "*Look at the link before you click it\n" +
                    "*Do not give out personal information on email\n" +
                    "*Monitor your online accounts.\n");
                break;

            case string j when j.Contains("browsing"):
                Console.WriteLine("======================================= SAFE BROWSING =========================================\n" +
                    "Safe browsing is a service run by Google and is offerd on many browsers, this service is to\n" +
                    "find out if the website is safe or risky. The web browsers such as Chrome, FireFox, and Safari\n" +
                    "run this service so that they can alert you if the website that you are currently on is safe or dangerous\n" +
                    "======================================= TYPES OF RISKY WEBSITES =========================================\n" +
                    "*Phishing - This is when a website will mimick a real and legitimate website in hopes of getting\n" +
                    "   users to enter their personal information and it will be taken by the attackers.\n" +
                    "*Malware - These are sites that will try to get users to download malicious software\n" +
                    "   which will steal the users information or delete the information or hold the information\n" +
                    "   ransom until the user pays the ransom.\n" +
                    "======================================= PROTECTION FROM RISKY WEBSITES =========================================\n" +
                    "*Look at the URL link of the website, if the link starts with https then that is a secure\n" +
                    "   website because the 's' at teh end stands for secure and it shows that the website is legitimate.\n" +
                    "*Download a anti-virus software that offers protection against online attacks.\n");
                break;
        }
    }
}

