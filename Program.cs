

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine(GetDay(2));


        //     Console.Write("Enter number: ");
        //     double num1 = Convert.ToDouble(Console.ReadLine());
        //          Console.Write("Enter operator: ");
        //         string op = Console.ReadLine();

        //     Console.Write("Enter number: ");
        //     double num2 = Convert.ToDouble(Console.ReadLine());
        // if (op == "+") 
        // {
        //     Console.WriteLine(num1 + num2);
        // }
        //else if (op == "-")
        // {
        //     Console.WriteLine(num1 - num2);
        // }
        // else if(op == "*")
        // {
        //     Console.WriteLine(num1 * num2);
        // }
        // else if ((op == "/"))
        //     {
        //     Console.WriteLine(num1 / num2);
        // }
        // else
        // {
        //     Console.WriteLine("operator jest nieprawidlowy! ");
        // }

        string secretWord = "giraffe";
        string guess = "";
        int guessNumber = 0;
        string[] podpowiedzi = { "Jest to zwierze", "Mieszka na sawannie", "Je liście drzew", "Ma długą szyję","Angielska nazwa żyrafy" };

        while (guess != secretWord)
        {
            Console.WriteLine(podpowiedzi[guessNumber]);
            Console.Write("Enter guess: ");
            guess = Console.ReadLine();
            guessNumber++;
          
        }


        Console.WriteLine("You win!");



    }

    //static string GetDay(int dayNum)
    //{
    //    string dayName;

    //    switch (dayNum)
    //    {
    //                        case 0:
    //            dayName = "pn";
    //            break;
    //                        case 1:
    //            dayName = "wt";
    //            break;
    //                        case 2:
    //            dayName = "sr";
    //            break;
    //                         case 3:
    //            dayName = "czw";
    //            break;
    //                         case 4:
    //            dayName = "pt";
    //            break;
    //                         case 5:
    //            dayName = "sb";
    //            break;
    //                         case 6:
    //            dayName = "nd";
    //            break;
    //        default:
    //            dayName = "invalid number";
    //            break;
                
    //    }
    //    return dayName;
    //}




}