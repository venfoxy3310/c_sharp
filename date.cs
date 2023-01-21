int day, month, year, num;
Console.Write("Enter date without <</>> ");
num = int.Parse(Console.ReadLine());
day = num / 10000;
month = (num / 100) % 100;
year = num % 100;
Console.WriteLine(day + "/" + month + "/" + year);