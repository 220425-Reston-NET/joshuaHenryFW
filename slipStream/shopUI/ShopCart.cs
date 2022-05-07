using shopModel;

namespace shopUI
{
    public class ShopCart
    {
        public static int _beardOil = 18; 
        public static int _candle = 14;
        public static int _lotion = 12;
        public static int _totalPrice;
        public static int TotalPrice 
        { 
            get{return _totalPrice;}
            set{_totalPrice = value;}
        }
     
            
        // Products prodobj1 = new Products();

        public static void Cart()
        {
            Console.Clear();
            Console.WriteLine("Welcome to shopping cart");
            Console.WriteLine("What can i do for for you?");
            Console.WriteLine("[1] add a item to cart");
            Console.WriteLine("[2] remove a item from cart");
            Console.WriteLine("[3] exit");
        
            bool repeat = true;
            Console.Clear();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                addCheck();
            }
            else if ( userInput == "2")
            {
                removeCheck();
            }
            else if ( userInput == "3")
            {
               repeat = false;
            }
            else
            {
                Console.WriteLine("Please input a vaid response");
            }
           
        }

        

        public static void addCheck()
        {
           Console.Clear();
           Console.WriteLine("1 - _beardOil");
           Console.WriteLine("2 - _candle");
           Console.WriteLine("3 - _lotion");
           string answer = Console.ReadLine();
           if (answer == "1")
           {
                  _totalPrice += _beardOil;
           }
               else if (answer == "2")
           {
                   _totalPrice += _candle;
           }
               else if (answer == "3")
           {
                   _totalPrice += _lotion;
           }
            Console.WriteLine("your current total is :" + _totalPrice);
        }

        public static void removeCheck()
        {
            Console.Clear();
            Console.WriteLine("1 - _beardOil");
            Console.WriteLine("2 - _candle");
            Console.WriteLine("3 - _lotion");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                _totalPrice -= _beardOil;
            }
            else if (answer == "2")
            {
                _totalPrice -= _candle;
            }
            else if (answer == "3")
            {
                _totalPrice = _lotion;
            }
            Console.WriteLine("your current total is :" + _totalPrice);
        }
    }
}