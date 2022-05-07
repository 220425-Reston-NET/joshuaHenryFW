namespace shopUI
{
    public class Secret
    {
            
        public static void empGreet()
        {
           
            Console.Clear();
            Console.WriteLine("Welcome agent!");
            Console.WriteLine("What agent number did our master give you?");
            string IDnum = Console.ReadLine();
            Console.WriteLine("Hope you're doing well agent " + IDnum + "!");
            Console.WriteLine("How can I help you take over the world today?");
            string answer = Console.ReadLine();
            if (answer == "1") 
            {
                // modItem();
            }
            else if (answer == "2")
            {
                // modEmp();
            }
            else if (answer == "3")
            {
                // modCust();
            }
            else
            {
                Console.WriteLine("Please input a vaid response");
            }
        }
    }















}