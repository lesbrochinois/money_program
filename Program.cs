class Program
{
  // MARK: Main
  static void Main(string[] args)
  {
    Random rnd = new();
    int product_price = rnd.Next(1, 60);
    Console.WriteLine($"The product costs {product_price}$");
    Console.Write("Enter your money : ");
    int user_money = int.Parse(Console.ReadLine() ?? "");

    if(user_money > product_price)
    {
      // Give money back
      Console.WriteLine("Give money back");
    }
    else if(user_money == product_price)
    {
      // Perfect
      Console.WriteLine("Perfect");
    }
    else
    {
      // You need money
      Console.WriteLine("You need money");
    }

  }
}
