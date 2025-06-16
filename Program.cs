using System.Runtime.InteropServices;
string userInput = "";
UserInput();

#region User Input Manager.
void UserInput()
{
    Console.WriteLine("Select your desired function:");
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("'1' ");
    Console.ResetColor();
    Console.WriteLine("for Dice Game.");

    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("'2' ");
    Console.ResetColor();
    Console.WriteLine("for Subscription Exercise.");

    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("'3' ");
    Console.ResetColor();
    Console.WriteLine("for Fraudulent Orders Exercise.");

    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("'4' ");
    Console.ResetColor();
    Console.WriteLine("for Student Grading Exercise.");
    Console.WriteLine("");

    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("'exit ' ");
    Console.ResetColor();
    Console.WriteLine("to exit the program.");
    Console.WriteLine("");

    userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.Write("You've selected ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The dice game.");
        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(2000);
        DiceGame();
    }
    else if (userInput == "2")
    {
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.Write("You've selected ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Subscription Exercise.");
        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(2000);
        SubscriptionEx();
    }
    else if (userInput == "3")
    {
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.Write("You've selected ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Fraudulent Orders Exercise");
        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(2000);
        FraudOrdersEx();
    }
    else if (userInput == "4")
    {
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.Write("You've selected ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Student Grading Exercise");
        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(1000);
        StudentGradingEx();
    }
    else if (userInput == "exit")
    {
        Console.WriteLine();
        Console.WriteLine("You have chosen to exit the program. Have a nice day!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select one of the three choices.");
        Console.WriteLine("");
        UserInput();
    }
}
#endregion

#region Dice Game.
void DiceGame()
{
    Random dice = new Random();
    int roll1 = dice.Next();
    int roll2 = dice.Next(21);
    int roll3 = dice.Next(50, 101);

    Console.WriteLine($"First Roll: {roll1}");
    Console.WriteLine($"Second Roll: {roll2}");
    Console.WriteLine($"ThirdRoll: {roll3}");

    Console.WriteLine("");

    Console.WriteLine("Math Challenge");

    int firstValue = 500;
    int secondValue = 600;
    int largerValue;

    largerValue = Math.Max(firstValue, secondValue);

    Console.WriteLine(largerValue);

    Console.WriteLine("");
    Console.WriteLine("Dice Rolling game: Get over 14.");
    Console.WriteLine("");

    Console.WriteLine("You roll the dice three times..");

    roll1 = dice.Next(1, 7);
    roll2 = dice.Next(1, 7);
    roll3 = dice.Next(1, 7);

    Console.Write($"First Roll: ");
    if (roll1 == 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (roll1 == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.WriteLine(roll1);
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.Write($"Second Roll: ");
    if (roll2 == 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (roll2 == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.WriteLine(roll2);
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.Write($"ThirdRoll: ");
    if (roll3 == 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (roll3 == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.WriteLine(roll3);
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.WriteLine("");

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!! +6 to your total!");
        total += 6;
        Console.WriteLine($" Your total is now: {total}.");

    }
    else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    {
        Console.Write("You rolled doubles! +2 to your total roll!");
        total += 2;
        Console.WriteLine($" Your total is now: {total}.");
    }

    if (total >= 16)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("You've won a fully furnished mansion!");
        Console.ResetColor();
    }
    else if (total >= 14)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You've won a Ford Tipex!");
        Console.ResetColor();
    }
    else if (total >= 11)
    {
        Console.WriteLine("You've won a Fountain Pen!");
    }
    else if (total == 6)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 6 ");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry m8! Get rekt, you lose! :D");
        Console.ResetColor();
    }

    Console.WriteLine("");
    UserInput();
}
#endregion

#region Subscription Exercise.
void SubscriptionEx()
{
    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("Code Exercise: Retain Software Subscriptions.");
    Thread.Sleep(2000);
    Console.WriteLine("");

    Random DaysLeft = new Random();
    int daysUntilExpiration = DaysLeft.Next(12);
    int discountPercent = 0;

    if (daysUntilExpiration <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your sub has expired M8.");
        Console.ResetColor();
    }
    else if (daysUntilExpiration == 1)
    {
        discountPercent = 50;
        Console.Write("Your sub expires tomorrow! ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Consider renewing!!!!!!");
        Console.ResetColor();
    }
    else if (daysUntilExpiration <= 3)
    {
        discountPercent = 30;
        Console.WriteLine($"You only have {daysUntilExpiration} days left of your sub!");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercent = 20;
        Console.WriteLine($"You only have {daysUntilExpiration} days left of your sub!");
    }
    else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine($"You only have {daysUntilExpiration} days left of your sub. Consider re-subbing yo.");

    }
    else
    {
        Console.WriteLine("You got sub :)");
    }

    if (discountPercent > 0)
    {
        Console.WriteLine($"Renew now for a {discountPercent}% Discount!");
    }

    Console.WriteLine("");
    UserInput();
}
#endregion

#region Fraud order Exercise.
void FraudOrdersEx()
{
    // string[] fraudOrderIDs = new string[3];

    // fraudOrderIDs[0] = "A123";
    // fraudOrderIDs[1] = "B123";
    // fraudOrderIDs[2] = "C123";

    string[] fraudOrderIDs = ["A69", "B69", "C69"];

    Console.WriteLine($"There are {fraudOrderIDs.Length} fraudulent orders to process.");
    Thread.Sleep(1000);

    Console.WriteLine($"First: {fraudOrderIDs[0]}");
    Console.WriteLine($"First: {fraudOrderIDs[1]}");
    Console.WriteLine($"First: {fraudOrderIDs[2]}");

    fraudOrderIDs[0] = "F000";
    Console.WriteLine($"reassign First: {fraudOrderIDs[0]}");
    Console.WriteLine("");

    string[] names = ["Billy", "Bobby", "Clint", "Crimpy", "Dave", "Dinkle"];
    foreach (string name in names)
    {
        Thread.Sleep(200);
        Console.WriteLine(name);
    }

    Console.WriteLine("");
    int[] inventory = [100, 200, 300, 400, 500, 666];

    int sum = 0;

    int bin = 0;

    foreach (int item in inventory)
    {
        sum += item;
        bin++;
        Console.WriteLine($"Bin {bin} = {item} items (Running Total: {sum})");
    }

    Console.WriteLine($"We have {sum} items in inventory.");

    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("Code Exercise: Nested iteration and selection statements.");
    Thread.Sleep(2000);
    Console.WriteLine("");

    string[] ExFraudIDs = [
    "B341", "R74", "A303", "M5219", "H879", "D55", "K1974", "G689", "B420", "N930",
    "Y20", "E384", "P149", "W22", "C340", "L783", "V201", "S9012", "Q661", "F72",
    "J480", "T352", "U541", "X39", "Z1112", "A561", "B998", "C777", "D1234", "E800",
    "F66", "G105", "H2002", "I301", "J92", "K4738", "L284", "M33", "N574", "O444",
    "P2311", "Q88", "R905", "S613", "T499", "U70", "V809", "W1456", "X120", "Y311",
    "Z772", "A133", "B255", "C322", "D412", "E901", "F62", "G90", "H787", "I808",
    "J234", "K560", "L9001", "M110", "N432", "O679", "P5000", "Q310", "R95", "S220",
    "T789", "U455", "V303", "W601", "X777", "Y2020", "Z611", "A404", "B818", "C1209",
    "D888", "E112", "F304", "G500", "H123", "I77", "J90", "K2888", "L303", "M448",
    "N913", "O123", "P789", "Q4321", "R222", "S654", "T1000", "U331", "V89", "W787",
    "X223", "Y444", "Z989", "A212", "B333", "C878", "D4545", "E345", "F2121", "G3333", "H456",
    "I989", "J777", "K666", "L555", "M444", "N111", "O222", "P333", "Q444", "R555",
    "S666", "T777", "U888", "V999", "W1001", "X101", "Y202", "Z303", "A4040", "B505",
    "C606", "D707", "E808", "F909", "G1111", "H1212", "I1313", "J1414", "K1515", "L1616",
    "M1717", "N1818", "O1919", "P2020", "Q2121", "R2222", "S2323", "T2424", "U2525", "V2626",
    "W2727", "X2828", "Y2929", "Z3030", "A3131", "B3232", "C3333", "D3434", "E3535", "F3636",
    "G3737", "H3838", "I3939", "J4040", "K4141", "L4242", "M4343", "N4444", "O4545", "P4646",
    "Q4747", "R4848", "S4949", "T5050", "U5151", "V5252", "W5353", "X5454", "Y5555", "Z5656",
    "A5757", "B5858", "C5959", "D6060", "E6161", "F6262", "G6363", "H6464", "I6565", "J6666",
    "K6767", "L6868", "M6969", "N7070", "O7171", "P7272", "Q7373", "R7474", "S7575", "T7676",
    "U7777", "V7878", "W7979", "X8080", "Y8181", "Z8282", "A8383", "B8484", "C8585", "D8686",
    "E8787", "F8888", "G8989", "H9090", "I9191", "J9292", "K9393", "L9494", "M9595", "N9696"];

    Console.Write("Please input a letter to find any orders beginning with your imput: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    Console.ResetColor();
    char OrderInput = keyInfo.KeyChar;
    Console.WriteLine("");

    string loadingMessage = $"Finding orders that begin with {OrderInput.ToString().ToUpper()}.";
    Console.WriteLine("");
    Console.Write(loadingMessage);
    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
    }

    Console.WriteLine("");

    Thread.Sleep(1000);
    int count = 0;
    Console.ForegroundColor = ConsoleColor.Cyan;
    foreach (string ID in ExFraudIDs)
    {
        if (ID.StartsWith(OrderInput.ToString().ToUpper()))
        {
            Thread.Sleep(100);
            Console.WriteLine($"{ID}");
            count++;
        }
    }
    Console.ResetColor();

    if (count == 1)
    {
        Console.WriteLine("");
        Console.Write("There is ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{count}");
        Console.ResetColor();
        Console.Write(" order that start with ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{OrderInput.ToString().ToUpper()}.");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("");
        Console.Write("There are ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{count}");
        Console.ResetColor();
        Console.Write(" orders that start with ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{OrderInput.ToString().ToUpper()}.");
        Console.ResetColor();
    }

    Console.WriteLine("");
    UserInput();
}
#endregion

#region Student Grading Exercise.

void StudentGradingEx()
{
    int ExamAssignments = 5;

    int[] SophiaScores = new int[] { 97, 95, 92, 98, 98, 94, 90 };
    int[] AndrewScores = new int[] { 92, 95, 85, 96, 90, 89 };
    int[] EmmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
    int[] LoganScores = new int[] { 90, 95, 87, 88, 96, 96 };
    int[] beckyScores = new int[] { 76, 69, 87, 34, 92, 76, 78 };
    int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 8, 98 };
    int[] ericScores = new int[] { 57, 90, 100, 80, 65, 100, 80, 90 };
    int[] gregorScores = new int[] { 45, 91, 65, 28, 15, 91, 64 };

    string[] StudentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky" , "Chris", "Eric", "Gregor" };
    int[] StudentScores = new int[10];
    string CurrentStudentLetterGrade = "";

    // Write the Report Header to the console
    Console.WriteLine("Student\t\tGrade\n");

    foreach (string name in StudentNames)
    {
        string CurrentStudent = name;

        if (CurrentStudent == "Sophia")
            StudentScores = SophiaScores;

        else if (CurrentStudent == "Andrew")
            StudentScores = AndrewScores;

        else if (CurrentStudent == "Emma")
            StudentScores = EmmaScores;

        else if (CurrentStudent == "Logan")
            StudentScores = LoganScores;

        else if (CurrentStudent == "Becky")
            StudentScores = beckyScores;

        else if (CurrentStudent == "Chris")
            StudentScores = chrisScores;

        else if (CurrentStudent == "Eric")
            StudentScores = ericScores;

        else if (CurrentStudent == "Gregor")
            StudentScores = gregorScores;
        else
            continue;

        /// Sum and Score Veriables.
        int SumAssignmentScores = 0;

        decimal CurrentStudentGrade = 0;

        // initialize/reset a counter for the number of assignment 
        int GradedAssignments = 0;

        foreach (int score in StudentScores)
        {
            // increment the assignment counter
            GradedAssignments += 1;

        if (GradedAssignments <= ExamAssignments)
            // add the exam score to the sum
            SumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            SumAssignmentScores += score / 10;
        }

        CurrentStudentGrade = (decimal)SumAssignmentScores / ExamAssignments;

        if(CurrentStudentGrade >= 97)
            CurrentStudentLetterGrade = "A+";
        else if(CurrentStudentGrade >= 93)
            CurrentStudentLetterGrade = "A";
        else if(CurrentStudentGrade >= 90)
            CurrentStudentLetterGrade = "A-";
        else if(CurrentStudentGrade >= 87)
            CurrentStudentLetterGrade = "B+";
        else if(CurrentStudentGrade >= 83)
            CurrentStudentLetterGrade = "B";
        else if(CurrentStudentGrade >= 80)
            CurrentStudentLetterGrade = "B-";
        else if(CurrentStudentGrade >= 77)
            CurrentStudentLetterGrade = "C+";
        else if(CurrentStudentGrade >= 73)
            CurrentStudentLetterGrade = "C";
        else if(CurrentStudentGrade >= 70)
            CurrentStudentLetterGrade = "C-";
        else if(CurrentStudentGrade >= 67)
            CurrentStudentLetterGrade = "D+";
        else if(CurrentStudentGrade >= 63)
            CurrentStudentLetterGrade = "D";
        else if(CurrentStudentGrade >= 60)
            CurrentStudentLetterGrade = "D-";
        else
            CurrentStudentLetterGrade = "F";

        Thread.Sleep(400);
        ///displaying scores.
        Console.WriteLine($"{CurrentStudent}\t\t{CurrentStudentGrade}\t{CurrentStudentLetterGrade}");

    }

    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();

    Console.WriteLine("");
    UserInput();
}


#endregion