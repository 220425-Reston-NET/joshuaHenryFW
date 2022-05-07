namespace shopUI
{

public class Shoppers
{
    public static string _custName;
    ShopCart cartobj = new ShopCart();

    public static string TotalPrice { get; set; }

    public static void custGreet()
    {
        Console.WriteLine("Nice to meet you " + _custName + "!");
        Console.WriteLine("How can i help you today?");
        bool repeat = true;
        // ask if want to make a purchase
        while (repeat)
        {
            Console.WriteLine("Would you like to make a purchase?");
            Console.WriteLine("yes or no");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                ShopCart.Cart();
                
            }
            else if (answer == "no")
            {       
                Console.WriteLine( TotalPrice + " is your total for today!");
                Console.WriteLine("Now get out of my shop and bring more money next time!");
                repeat = false;
            }
            else 
            {
            Console.WriteLine("Please input a vaid response");
            }            
        }
    }       
}
}