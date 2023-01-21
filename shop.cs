int price, customer_money, coin_10, coin_5, coin_2, coin_1, left;
Console.WriteLine("How much pay?");
price = int.Parse(Console.ReadLine());
Console.WriteLine("Money from the customer?");
customer_money= int.Parse(Console.ReadLine());
left = customer_money - price;
Console.WriteLine("left " + left);
coin_10 = left / 10;
left = left - coin_10 * 10;
coin_5 = left / 5;
left = left - coin_5 * 5;
coin_2 = left / 2;
left = left - coin_2 * 2;
coin_1 = left / 1;
Console.WriteLine("coin 10: "+coin_10 
    + "\n" + "coin 5: "+coin_5 
    + "\n" + "coin 2: "+coin_2 
    + "\n" + "coin 1: "+coin_1);