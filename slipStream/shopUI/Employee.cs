namespace shopModel
{
    public class Employee
    {
        private string _name;
        public string name 
        { 
            get{ return _name; }
            set{ _name = value;}
        }

    
        public string sex;
        public int age;
        public string phoneNumber;

        public  Employee()
        {
        _name = "Triton";
        }
    }



// look at pokemon project

// public class AddEmployee : Imenu
// {
//     public void Display()
//     {
//         Employee empobj1 - Employee();
//         Console.WriteLine("Please enter information");
//         Console.WriteLine("Please enter the name of the employee");
//         empobj1.name = Console.ReadLine();
//         Console.WriteLine("What is Employee number");
//         empobj1.IDnum = Console.ReadLine();
//         Console.WriteLine("[1] add employee");
//         Console.WriteLine("[2] cancel")

    
//     }

//     public string YourChoice()
//     {
//         string user = Console.ReadLine();
//         if (userinput = 1 )
//     }
// }




}