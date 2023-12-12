namespace MathGame
{
    internal class Program
    {
        static int WrongAnswer = 1;
        static int numberofquestion = 1;
        static int Score = 0;
        static List<int> TopScores = new List<int>() { 0};
        static Dictionary<string, int> ScoresOfEachGame = new Dictionary<string, int>();
        static int resultOfRandomGames = 0;
        static void Main(string[] args)
        {
            //Variables of the program
            int ChoosenOperation, Score = 0;

            
        BackToInputAnotherOperation: Console.Write("Choose From The Following Operations:" +
                "\n1- Addition\t\t" +
                "2- Substraction" +
                "\n3- Division\t\t" +
                "4- Multiplication" +
                "\n5- Random Operations\t" +
                "6- History\n»» ");
            var inputOperation = int.TryParse(Console.ReadLine(),out ChoosenOperation );

            
            //Check if the operation input is valid [integers number only]
            if (inputOperation)
            {
                //Check if the Choosen Operation is valid [integers number in range (1-5) ]
                if (ChoosenOperation >= 1 && ChoosenOperation <= 6)
                {
                    #region Addition Operation
                    if (ChoosenOperation == 1)
                    {
                       
                        Console.Clear();
                        int result, numberofquestion = 1;
                        do
                        {
                            Random rnd1 = new Random();
                            var R1 = rnd1.Next(0, 100);
                            var R2 = rnd1.Next(0, 100);
                           

                        BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} + {R2} ] = ");
                            var inputResult = int.TryParse(Console.ReadLine(), out result);

                            if (inputResult)
                            {
                                if (Addition(R1, R2) == result)
                                {
                                    Console.WriteLine("Excellent ");
                                    Console.WriteLine("Your Current Score {0}", ++Score);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    numberofquestion++;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Wrong Answer." +
                                        $"The Correct Answer is {Addition(R1,R2)}"+
                                        "\nYour Score is {0} ", Score);
                                    TopScores.Add(Score);
                                    ScoresOfEachGame["Addition"] = Score;
                                backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                                    var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                                    if(backtomenu&&(MenuInput==1||MenuInput==2))
                                    {
                                        if (MenuInput == 1)
                                        {
                                            Console.Clear();
                                            Score = 0;
                                            goto BackToInputAnotherOperation;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Thank you.. Good Bye\tTop Score »» {TopScores.Max()} ");
                                            Thread.Sleep(1500);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                        Thread.Sleep(1500);
                                        goto backToMenu;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto BackToresult;
                            }
                        } while (true);
                    }
                    #endregion

                    #region Substraction Operation 
                    if (ChoosenOperation == 2)
                    {
                        Console.Clear();
                        int result, numberofquestion = 1;
                        do
                        {
                            Random rnd1 = new Random();
                            var R1 = rnd1.Next(0, 100);
                            var R2 = rnd1.Next(0, 100);

                        BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} - {R2} ] = ");
                            var inputResult = int.TryParse(Console.ReadLine(), out result);

                            if (inputResult)
                            {
                                if (Substraction(R1, R2) == result)
                                {
                                    Console.WriteLine("Excellent ");
                                    Console.WriteLine("Your Current Score {0}", ++Score);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    numberofquestion++;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Wrong Answer." +
                                         $"The Correct Answer is {Substraction(R1, R2)}" +
                                         "\nYour Score is {0} ", Score);
                                    TopScores.Add(Score);
                                    ScoresOfEachGame["Substraction"] = Score;
                                backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                                    var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                                    if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                                    {

                                        if (MenuInput == 1)
                                        {
                                            Console.Clear();
                                            Score = 0;
                                            goto BackToInputAnotherOperation;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Thank you.. Good Bye\tTop Score »» {TopScores.Max()} ");
                                            Thread.Sleep(1500);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                        Thread.Sleep(1500);
                                        goto backToMenu;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto BackToresult;
                            }
                        } while (true);

                    }
                    #endregion

                    #region Division Operation
                    if (ChoosenOperation == 3)
                    {
                        Console.Clear();
                        int result, numberofquestion = 1;
                        do
                        {
                            Random rnd1 = new Random();
                            PlayAgain: var R1 = rnd1.Next(0, 200);
                            var R2 = rnd1.Next(1, 200);
                            if(R1%R2==0)
                            {
                            BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} / {R2} ] = ");
                                var inputResult = int.TryParse(Console.ReadLine(), out result);

                                if (inputResult)
                                {
                                    if (Division(R1, R2) == result)
                                    {
                                        Console.WriteLine("Excellent ");
                                        Console.WriteLine("Your Current Score {0}", ++Score);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        numberofquestion++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry Wrong Answer." +
                                            $"The Correct Answer is {Division(R1, R2)}" +
                                            "\nYour Score is {0} ", Score);
                                        TopScores.Add(Score);
                                        ScoresOfEachGame["Division"] = Score;
                                    backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                                        var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                                        if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                                        {

                                            if (MenuInput == 1)
                                            {
                                                Console.Clear();
                                                Score = 0;
                                                goto BackToInputAnotherOperation;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Thank you.. Good Bye\tTop Score »» {TopScores.Max()} ");
                                                Thread.Sleep(1500);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                            Thread.Sleep(1500);
                                            goto backToMenu;
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    goto BackToresult;
                                }
                            }
                            else
                            {
                                goto PlayAgain;
                            }

                       
                        } while (true);

                    }
                    #endregion

                    #region Multiplication Operation
                    if (ChoosenOperation == 4)
                    {
                        Console.Clear();
                        int result, numberofquestion = 1;
                        do
                        {
                            Random rnd1 = new Random();
                            var R1 = rnd1.Next(0, 20);
                            var R2 = rnd1.Next(0, 20);
                        BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} * {R2} ] = ");
                            var inputResult = int.TryParse(Console.ReadLine(), out result);

                            if (inputResult)
                            {
                                if (Multiplication(R1, R2) == result)
                                {
                                    Console.WriteLine("Excellent ");
                                    Console.WriteLine("Your Current Score {0}", ++Score);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    numberofquestion++;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Wrong Answer." +
                                        $"The Correct Answer is {Multiplication(R1, R2)}" +
                                        "\nYour Score is {0} ", Score);
                                    TopScores.Add(Score);
                                    ScoresOfEachGame["Multiplication"] = Score;
                                backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                                    var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                                    if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                                    {
                                        if (MenuInput == 1)
                                        {
                                            Console.Clear();
                                            Score = 0;
                                            goto BackToInputAnotherOperation;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Thank you.. Good Bye\tTop Score »» {TopScores.Max()} ");
                                            Thread.Sleep(1500);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                        Thread.Sleep(1500);
                                        goto backToMenu;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto BackToresult;
                            }
                        } while (true);
                    }
                    #endregion

                    #region Random Oprations of The Previous 4 Operation
                    if (ChoosenOperation == 5)
                    {
                        Random Rnd1 = new Random();
                        List<string> ListOfOperations = new List<string> { "Addition","Multiplication","Substraction","Division"};
                        do
                        {
                            var RandomOperations = Rnd1.Next(0,4);
                            if (ListOfOperations[RandomOperations] =="Addition")
                            {
                                GenerateRandomAdditionQuestion();   
                            }
                            if (ListOfOperations[RandomOperations] =="Multiplication")
                            {
                                GenerateRandomMultiplicationQuestion();
                            }
                            if (ListOfOperations[RandomOperations] == "Substraction")
                            {
                                GenerateRandomSubstractionQuestion();
                            }
                            if (ListOfOperations[RandomOperations] == "Division")
                            {
                                GenerateRandomDivisionQuestion();
                            }
                        }while (WrongAnswer==1) ;
                        ScoresOfEachGame["Random Operations"] = resultOfRandomGames;
                        if(WrongAnswer==0)
                        {
                        backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                            var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                            if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                            {
                                if (MenuInput == 1)
                                {
                                    Console.Clear();
                                    Score = 0;
                                    goto BackToInputAnotherOperation;
                                }
                                else
                                {
                                    Console.WriteLine($"Thank you.. Good Bye\tTop Score »» {TopScores.Max()} ");
                                    Thread.Sleep(1500);
                                    return;
                                }
                                    
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                Thread.Sleep(1500);
                                goto backToMenu;
                            }
                        }
                    }
                    #endregion

                    #region History Of Games
                    if(ChoosenOperation==6)
                    {
                        Console.Clear();
                        if (ScoresOfEachGame.Count != 0)
                        {
                            Console.WriteLine($"The Previous Games:\n");
                            foreach (var item in ScoresOfEachGame)
                            {
                                if (item.Key == "Addition")
                                {
                                    Console.WriteLine($"Addition    \t\tScores » {item.Value}");
                                }
                                if (item.Key == "Multiplication")
                                {
                                    Console.WriteLine($"Multiplication    \tScores » {item.Value}");
                                }
                                if (item.Key == "Division")
                                {
                                    Console.WriteLine($"Division    \t\tScores » {item.Value}");
                                }
                                if (item.Key == "Substraction")
                                {
                                    Console.WriteLine($"Substraction    \tScores » {item.Value}");
                                }
                                if(item.Key=="Random Operations")
                                {
                                    Console.WriteLine($"Random Operations    \tScores » {item.Value}");
                                }
                            }
                        backToMenu: Console.WriteLine("\n[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                            var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                            if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                            {

                                if (MenuInput == 1)
                                {
                                    Console.Clear();
                                    Score = 0;
                                    goto BackToInputAnotherOperation;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Thank you.. Good Bye");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                Thread.Sleep(1500);
                                goto backToMenu;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is No History");
                        backToMenu: Console.WriteLine("[ 1 ] For Menu \t\t\t [ 2 ] For Exit ");
                            var backtomenu = int.TryParse(Console.ReadLine(), out int MenuInput);
                            if (backtomenu && (MenuInput == 1 || MenuInput == 2))
                            {

                                if (MenuInput == 1)
                                {
                                    Console.Clear();
                                    Score = 0;
                                    goto BackToInputAnotherOperation;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Thank you.. Good Bye");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input.. Please Enter [ 1 ] for Menu of [ 2 ] for Exit");
                                Thread.Sleep(1500);
                                goto backToMenu;
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("You Enter Out of Range number, you should choose only numbers from 1 To 5");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto BackToInputAnotherOperation;
                }
            }
            else
            {
                Console.WriteLine("You Enter Invalid input, you should choose only numbers from 1 To 5");
                Thread.Sleep(1500);
                Console.Clear();
                goto BackToInputAnotherOperation;
            }


        }
        //lambda Method To Sum Two Integers 
        static int Addition(int n1, int n2) => n1 + n2;

        //lambda Method To Minus Two Integers 
        static int Substraction(int n1, int n2) => n1 - n2;

        //lambda Method To Multiplicate Two Integers 
        static int Multiplication(int n1, int n2) => n1 * n2;

        //lambda Method To Divide Two Integers 
        static int Division(int n1, int n2) => n1 / n2;

        //Method to generate random question of Multiplication operation
        static void GenerateRandomMultiplicationQuestion()
        {
            Console.Clear();
            int result;
            Random rnd1 = new Random();
            var R1 = rnd1.Next(0, 20);
            var R2 = rnd1.Next(0, 20);
            BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} * {R2} ] = ");
                var inputResult = int.TryParse(Console.ReadLine(), out result);

                if (inputResult)
                {
                    if (Multiplication(R1, R2) == result)
                    {
                        Console.WriteLine("Excellent ");
                        Console.WriteLine("Your Current Score {0}", ++Score);
                        Thread.Sleep(1000);
                        Console.Clear();
                        numberofquestion++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry Wrong Answer." +
                            $"The Correct Answer is {Multiplication(R1, R2)}" +
                            "\nYour Score is {0} ", Score);
                        TopScores.Add(Score);
                        resultOfRandomGames += Score;
                        WrongAnswer = 0;
                    }

                }
                else
                {
                    Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto BackToresult;
                }

        }

        //Method to generate random question of Addition operation
        static void GenerateRandomAdditionQuestion()
        {
            Console.Clear();
            int result;
           
                Random rnd1 = new Random();
                var R1 = rnd1.Next(0, 100);
                var R2 = rnd1.Next(0, 100);

            BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} + {R2} ] = ");
                var inputResult = int.TryParse(Console.ReadLine(), out result);

                if (inputResult)
                {
                    if (Addition(R1, R2) == result)
                    {
                        Console.WriteLine("Excellent ");

                        Console.WriteLine("Your Current Score {0}", ++Score);
                        Thread.Sleep(1000);
                        Console.Clear();
                        numberofquestion++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry Wrong Answer." +
                            $"The Correct Answer is {Addition(R1, R2)}" +
                            "\nYour Score is {0} ", Score);
                            TopScores.Add(Score);
                            resultOfRandomGames += Score;
                            WrongAnswer = 0;

                    }

                }
                else
                {
                    Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto BackToresult;
                }

        }

        //Method to generate random question of Substraction operation
        static void GenerateRandomSubstractionQuestion()
        {
            Console.Clear();
            
            int result;
 
            
                Random rnd1 = new Random();
                var R1 = rnd1.Next(0, 100);
                var R2 = rnd1.Next(0, 100);

            BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} - {R2} ] = ");
                var inputResult = int.TryParse(Console.ReadLine(), out result);

                if (inputResult)
                {
                    if (Substraction(R1, R2) == result)
                    {
                        Console.WriteLine("Excellent ");

                        Console.WriteLine("Your Current Score {0}", ++Score);
                        Thread.Sleep(1000);
                        Console.Clear();
                        numberofquestion++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry Wrong Answer." +
                            $"The Correct Answer is {Substraction(R1, R2)}" +
                            "\nYour Score is {0} ", Score);
                        WrongAnswer = 0;
                        resultOfRandomGames += Score;
                        TopScores.Add(Score);

                    }

                }
                else
                {
                    Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto BackToresult;
                }

        }

        //Method to generate random question of Division operation
        static void GenerateRandomDivisionQuestion()
        {
            Console.Clear();
            int result;

            Random rnd1 = new Random();
            PlayAgain: var R1 = rnd1.Next(0, 200);
            var R2 = rnd1.Next(1, 20);
            if (R1 % R2 == 0)
            {
            BackToresult: Console.Write($"Q{numberofquestion} : [ {R1} / {R2} ] = ");
                var inputResult = int.TryParse(Console.ReadLine(), out result);

                if (inputResult)
                {
                    if (Division(R1, R2) == result)
                    {
                        Console.WriteLine("Excellent ");

                        Console.WriteLine("Your Current Score {0}", ++Score);
                        Thread.Sleep(1000);
                        Console.Clear();
                        numberofquestion++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry Wrong Answer." +
                            $"The Correct Answer is {Division(R1, R2)}" +
                            "\nYour Score is {0} ", Score);
                        WrongAnswer = 0;
                        TopScores.Add(Score);
                        resultOfRandomGames += Score;
                    }

                }
                else
                {
                    Console.WriteLine("You can enter only integer numbers, please wait for 2 sec to write your result");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto BackToresult;
                }

            
            }
            else
            {
                goto PlayAgain;
            }
        }
    }
}