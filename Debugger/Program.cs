var numbers = Console.ReadLine().Split(" ");

foreach (var number in numbers)
{
    var numberInt = int.Parse(number);
    var numberPow = Math.Pow(numberInt, 2);
    
    Console.WriteLine($"{numberInt}² = {numberPow}");
}

Console.ReadKey();