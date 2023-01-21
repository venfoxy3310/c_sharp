int balloons, participants, eachOne, left;

Console.Write("Enter the amout of the balloons: ");
balloons = int.Parse(Console.ReadLine());
Console.Write("how much participants? ");
participants =  int.Parse(Console.ReadLine());

eachOne = balloons / participants ;
left = balloons % participants ;
Console.WriteLine("Each one gets: " + eachOne);
Console.WriteLine("balloons left: " + left);
