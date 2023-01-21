int num, char1, char2;
Console.Write("Enter number ");
num = int.Parse(Console.ReadLine());
char1 = num / 10;
char2 = num % 10;

int reverseNum = char2*10 + char1;
Console.Write("Reverse number: " + reverseNum);