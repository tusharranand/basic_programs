
// to initiate an integer variable 
int coin_head = 1;
// to make a basic object named "x"
Random x = new Random();
int coin_check = x.Next(0, 2);

Console.WriteLine("Random number was: " + coin_check);

if (coin_check == coin_head)
{
    Console.WriteLine("Coin landed on Heads.");
}
else
{
    Console.WriteLine("Coin landed on Tails.");
}