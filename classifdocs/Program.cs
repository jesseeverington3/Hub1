using System;
using System.Threading;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            string[] countries = { "Uzbekistan", "Canada", "Brazil", "Australia", "Japan",
                                   "Germany", "South Africa", "Egypt", "Italy", "Mexico" };
            Random random = new Random();

            while (keepPlaying)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose (R)ock, (P)aper, or (S)cissors, or enter Q to quit:");
                Console.ResetColor();
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "q")
                {
                    keepPlaying = false;
                    Console.WriteLine("Thanks for playing!");
                }
                else if (userChoice == "pass1234")
                {
                    Thread.Sleep(2000);
                    {
                        Console.Clear();
                        Thread.Sleep(3000);
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("-------------------------------------" +
                        "\n >Security Clearance Alpha Accepted<\n" +
                        "-------------------------------------\n\n\n\n\n\n\n" +
                        "\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Thread.Sleep(2000);
                    {
                        string classifiedText = ("You are now being redirected....\n");
                        foreach (char c in classifiedText)
                        {
                            Console.Write(c);
                            Thread.Sleep(25); // Adjust the delay as desired
                        }
                        {
                            Thread.Sleep(2000);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\n" +
                     "------------------------" +
                     "\n      CLASSIFIED\n" +
                     "------------------------");
                            {
                                Thread.Sleep(2000);
                                string classifiedText1 = ("FOR OFFICIALUSE-ONLY\r\n\r\nATZL-CG\r\nSUBJECT: AR 15-6 Report- Compromise of Classified Information to Wikileaks\r\n\r\n2. (W//FOUO) Accession into the Army.\r\na. (U//FOUO) As part of PFC Manning's accession into the Army, he reported to the\r\nFort Meade Military Entrance Processing Station (MEPS) on or about 31 August 2007.\r\nThe MEPS processing includes a medical examination which is documented on a DD\r\nForm 2807-1 (Encl O23), Report of Medical History. The form includes a series of\r\nquestions covering behavioral health issues. b) (8). (b) (7XC]\r\n\r\nb. (U//FOUO) The enlistment criteria are set out in AR 601-210, Active and Reserve\r\nComponents Enlistment Program, 7 June 2007 and AR 40-501, Standards of Medical\r\nFitness, 29 May 2007. Paragraph D) (6).\r\nb) (6). (5) [7XC) would disqualify an individual from military service. Specifically, it\r\nstates b) (5) (b) (7)C)\r\n\r\n(Enc (54)).\r\nc. (U//FOUO) Despite the behavioral health issues identified in paragraphs 1.b.(1).\r\nand 1.c.(3). above, PFC Manning answered b) (6), (b) (7) in the negative. There is no\r\nother indication of behavioral health review or screening in PFC Manning's enlistment\r\ndocuments. (PFC Manning's DD Form 2807-1, Report of Medical History, 31 August\r\n2007 (Encl J1)).\r\n\r\nd. (U/FOUO) On 26 September 2007, PFC Manning began his four year enlistment\r\nin the Active Army. (Enlistment Docs (Encl J1)).\r\n3. (U//FOUO) MOS Classification. PFC Manning's enlistment was for service as a\r\nMilitary Occupational Specialty (MOS) 35F, Intelligence Analyst. (See DA Form 3286\r\n(Annex A), dated 26 Sep 2007, U.S. Army Delayed Enlistment Program (Encl J1); DA\r\nForm 3286 (Annex B), dated 2 Oct 2007, United States Army Enlistment Program (Encl\r\nJ1)). In order to be granted the MOS of 35F, PFC Manning needed to meet the\r\nrequirements set out in Department of the Army (DA) Pam 611-21. The requirements\r\nincluded: a score of 101 or higher on the ST (skilled technical) portion of the Armed\r\nServices Vocational Aptitude Battery (ASVAB); eligibility for a Top Secret/Sensitive\r\nCompartmented Information (TS/SCI) security clearance; a high school or equivalent\r\ndegree; no criminal conviction for anything other than minor traffic violations; U.S.\r\ncitizenship; and the absence of any no close ties to foreign countries within whose\r\nboundaries physical or mental coercion is known to be common. PFC Manning met all\r\nthe requirements and had an ST score of 128. (ERB, 29 May 2010 (Encl J1)).\r\n4. (U//FQUO) Basic Training. PFC Manning attended basic training at Fort Leonard\r\nWood, MO from 5 October 2007 until 6 April 2007. His training lasted six months for a\r\n\r\n7\r\nCLASSIFIED//FOR-OFFICIALUSE-ONLY\r\n\r\nof AR 40-501 lists the criteria for which\r\n\r\nAR 40-501, paragraph b) (6).\r\n\r\n29 May 2007");

                                foreach (char c1 in classifiedText1)
                                {
                                    Console.Write(c1);
                                    Thread.Sleep(5); // Adjust the delay as desired
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }


                    }
                    //remember to change to false
                    keepPlaying = true;
                }
                else
                {
                    string userChoiceFull;
                    switch (userChoice)
                    {
                        case "r":
                        case "rock":
                            userChoiceFull = "rock";
                            break;
                        case "p":
                        case "paper":
                            userChoiceFull = "paper";
                            break;
                        case "s":
                        case "scissors":
                            userChoiceFull = "scissors";
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t>>>Invalid input<<<");
                            Console.WriteLine("\t>>>Please choose (R)ock, (P)aper, or (S)cissors<<<\n\n\n");
                            Console.ResetColor();
                            {
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey(); // Wait for the user to press a key
                                Console.Clear(); // Clear the screen after a key is pressed

                            }
                            continue;
                    }

                    int computerChoice = random.Next(3);
                    string[] choices = { "rock", "paper", "scissors" };
                    string computerChoiceText = choices[computerChoice];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\t>The computer chose {computerChoiceText}<");
                    Console.ResetColor();

                    if (userChoiceFull == computerChoiceText)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t>It's a tie!\n\n\n");
                        Console.ResetColor();
                    }
                    else if ((userChoiceFull == "rock" && computerChoiceText == "scissors") ||
                             (userChoiceFull == "paper" && computerChoiceText == "rock") ||
                             (userChoiceFull == "scissors" && computerChoiceText == "paper"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t>You win!\n\n\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t>Computer wins!\n\n\n");
                        Console.ResetColor();
                    }
                    {
                        // Your existing code for the secret mission...

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey(); // Wait for the user to press a key

                        Console.Clear(); // Clear the screen after a key is pressed
                                         // Continue with the rest of your code...
                    }
                }
            }
        }
    }
}