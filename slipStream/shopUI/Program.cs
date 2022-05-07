
using shopModel;
using shopUI;

Employee emp = new Employee();
Shoppers cust = new Shoppers();
Products prod = new Products();
ShopCart cart = new ShopCart(); 
Secret agent = new Secret();
// // shoppingCart cart1 = new shoppingCart();
//MainMenu menuobj = new MainMenu();






Console.Clear();
Console.WriteLine("Welcome to the slipStream shop!");
Console.WriteLine("Im " + emp.name + " nice to meet you!");
Console.WriteLine("What is your namre?");
string _custName = Console.ReadLine();
if (_custName == "agent")
{     
    Secret.empGreet();
}
else
{
    Shoppers.custGreet();
}
