//Random dice = new Random();
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);


//int result = Random.Next();

//Random dice = new Random();
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

//int firstValue = 500;
//int secondValue = 600;
//int largerValue;
//largerValue = Math.Max(firstValue, secondValue);
//Console.WriteLine(largerValue);

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    if ((roll1 == roll2) && (roll2 == roll3))
//    {
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    }
//    else
//    {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

//if (total >= 15)
//{
//    Console.WriteLine("You win!");
//}
//else
//{
//    Console.WriteLine("Sorry, you lose.");
//}


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
//if (daysUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscribption has expired. Renew Now!");
//}

//else if (daysUntilExpiration == 1)
//{
//    Console.WriteLine("Your subscription expires within a day");
//    discountPercentage = 20;
//}

//else if (daysUntilExpiration <= 5)
//{
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days\nRenew now and save 10%");
//}

//else if (daysUntilExpiration <= 10)
//{
//    Console.WriteLine("Your subscribtion will expire soon. Renew now!");
//}
//if (discountPercentage > 0)
//{
//    Console.WriteLine($"Renew now and save {discountPercentage}%.");
//}

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";
//////fraudulentOrderIDs[3] = "D000";

//string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"First: {fraudulentOrderIDs[2]}");


//fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
//int[] inventory = { 200, 450, 700, 175, 250};
//int sum = 0;
//int bin = 0;
//foreach (int items in inventory)
//{
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin{bin} = {items} items(Running total: {sum})");
//}

//Console.WriteLine($"We have {sum} items in inventory.");

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

