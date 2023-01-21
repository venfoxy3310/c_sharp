int num, digit1, digit2, digit3, reverse;
Console.Write("Enter 3 digits number: ");
num = int.Parse(Console.ReadLine());
digit1 = num / 100;
digit2 = (num / 10) % 10;
digit3 = num % 10;
reverse = digit3 * 100 + digit2 * 10 + digit1;
Console.WriteLine("reverse number: " + reverse);