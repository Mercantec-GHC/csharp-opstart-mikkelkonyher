//using System;

//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");
//DisplayTimes();

//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());

//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//    Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}
//else
//{
//    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//    AdjustTimes();
//}

//Console.WriteLine("New Medicine Schedule:");
//DisplayTimes();


//void DisplayTimes()
//{
//    /* Format and display medicine times */
//    foreach (int val in times)
//    {
//        string time = val.ToString();
//        int len = time.Length;

//        if (len >= 3)
//        {
//            time = time.Insert(len - 2, ":");
//        }
//        else if (len == 2)
//        {
//            time = time.Insert(0, "0:");
//        }
//        else
//        {
//            time = time.Insert(0, "0:0");
//        }

//        Console.Write($"{time} ");
//    }

//    Console.WriteLine();
//}

//void AdjustTimes()
//{
//    /* Adjust the times by adding the difference, keeping the value within 24 hours */
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}


/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

//string [] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
//string[] address;
//bool validLength = false;
//bool validZeroes = false;
//bool validRange = false;

//foreach (string ip in ipv4Input)
//{
//    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//    ValidateLength();
//    ValidateZeroes();
//    ValidateRange();

//    if (validLength && validZeroes && validRange)
//    {
//        Console.WriteLine($"ip is a valid IPV4 address");
//    }
//    else
//    {
//        Console.WriteLine($"ip is an invalid IPV4 address");
//    }
//}

//void ValidateLength()
//{

//    validLength = address.Length == 4;
//};
//void ValidateZeroes()
//{


//    foreach(string number in address)
//    {
//        if (number.Length > 1 && number.StartsWith("0"))
//        {
//            validZeroes = false;
//            return;
//        }
//    }

//    validZeroes = true;
//}

//void ValidateRange()
//{


//    foreach(string number in address)
//    {
//        int value = int.Parse(number);
//        if(value < 0 || value > 255)
//        {
//            validRange = false;
//            return;
//        }
//    }
//    validRange = true;
//}

//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//TellFortune();
//luck = random.Next(100);
//TellFortune();
//void TellFortune()
//{
//    Console.WriteLine("A fortune teller whispers the following words:");
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//    Console.Write($"{text[i]} {fortune[i]} ");
//    }
//}

//int[] schedule = { 800, 1200, 1600, 2000 };
//DisplayAdjustedTimes(schedule, 6, -6);

//void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
//{
//    int diff = 0;
//    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//    {
//        Console.WriteLine("Invalid GMT");
//    }
//    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//    {
//        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//    }
//    else
//    {
//        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//    }
//    for (int i = 0; i < times.Length; i++)
//    {
//        int newTime = ((times[i] + diff)) % 2400;
//        Console.WriteLine($"{times[i]} -> {newTime}");
//    }
//}


//string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

//DisplayStudents(students);
//DisplayStudents(new string[] { "Robert", "Vanya" });

//void DisplayStudents(string[] students)
//{
//    foreach (string student in students)
//    {
//        Console.Write($"{student}, ");
//    }
//    Console.WriteLine();
//}

//int[] array = { 1, 2, 3, 4, 5 };

//PrintArray(array);
//Clear(array);
//PrintArray(array);

//void PrintArray(int[] array)
//{
//    foreach (int a in array)
//    {
//        Console.Write($"{a} ");
//    }
//    Console.WriteLine();
//}

//void Clear(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

//string[,] corporate =
//{
//    {"Robert", "Bavin"}, {"Simon", "Bright"},
//    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
//};

//string[,] external =
//{
//    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
//};

//string externalDomain = "hayworth.com";

//for (int i = 0; i < corporate.GetLength(0); i++)
//{
//    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
//}

//for (int i = 0; i < external.GetLength(0); i++)
//{
//    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
//}


//void DisplayEmail(string first, string last, string domain = "contoso.com")
//{
//    string email = first.Substring(0, 2) + last;
//    email = email.ToLower();
//    Console.WriteLine($"{email}@{domain}");
//}

//double total = 0;
//double minimumSpend = 30.00;

//double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

//for (int i = 0; i < items.Length; i++)
//{
//    total += GetDiscountedPrice(i);
//}

//if (TotalMeetsMinimum())
//{
//    total -= 5.00;
//}
//Console.WriteLine($"Total: ${FormatDecimal(total)}");

//double GetDiscountedPrice(int itemIndex)
//{
//    return items[itemIndex] * (1 - discounts[itemIndex]);
//}

//bool TotalMeetsMinimum()
//{
//    return total >= minimumSpend;
//}

//string FormatDecimal(double input)
//{
//    return input.ToString().Substring(0, 5);
//}

//double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD = ${vnd} VND");
//Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

//int UsdToVnd(double usd)
//{
//    int rate = 23500;
//    return (int)(rate * usd);
//}

//double VndToUsd(int vnd)
//{
//    double rate = 23500;
//    return vnd / rate;
//}

//string input = "there are snakes at the zoo";

//Console.WriteLine(input);
//Console.WriteLine(ReverseSentence(input));



//string ReverseSentence(string input)
//{
//    string result = "";
//    string[] words = input.Split(" ");
//    foreach (string word in words)
//    {
//        result += ReverseWord(word) + " ";
//    }
//    return result.Trim();
//}

//string ReverseWord(string word)
//{
//    string result = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}

//string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

//Console.WriteLine("Is it a palindrome?");
//foreach (string word in words)
//{
//    Console.WriteLine($"{word}: {IsPalindrome(word)}");
//}

//bool IsPalindrome(string word)
//{
//    int start = 0;
//    int end = word.Length - 1;

//    while (start < end)
//    {
//        if (word[start] != word[end])
//        {
//            return false;
//        }
//        start++;
//        end--;
//    }

//    return true;
//}

//int[] TwoCoins(int[] coins, int target)
//{
//    for (int curr = 0; curr < coins.Length; curr++)
//    {
//        for (int next = curr + 1; next < coins.Length; next++)
//        {
//            if (coins[curr] + coins[next] == target)
//            {
//                return new int[] { curr, next };
//            }

//        }
//    }
//}


//Random random = new Random();

//Console.WriteLine("Would you like to play? (Y/N)");
//if (ShouldPlay())
//{
//    PlayGame();
//}

//bool ShouldPlay()
//{

//    string response = Console.ReadLine();
//    return response.ToLower().Equals("y");
//}

//void PlayGame()
//{
//    var play = true;

//    while (play)
//    {
//        var target = GetTarget();
//        var roll = RollDice();

//        Console.WriteLine($"Roll a number greater than {target} to win!");
//        Console.WriteLine($"You rolled a {roll}");
//        Console.WriteLine(WinOrLose(roll,target));
//        Console.WriteLine("\nPlay again? (Y/N)");

//        play = ShouldPlay();
//    }
//}

//int GetTarget()
//{
//    return random.Next(1,6);
//}

//int RollDice()
//{
//    return random.Next(1, 7);
//}

//string WinOrLose(int roll, int target)
//{
//    if(roll > target)
//    {
//        return "You win";
//    }
//    return "You lose";
//}

