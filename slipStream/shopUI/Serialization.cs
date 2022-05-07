
// public class Serialization
// {
//     private string _filepath = "./Data/emp.json";
//     public void SerializationMain()
//     {
//         Console.WriteLine("===serialization===");
    
//         Employee empobj1 = new Employee();
//         Employee empobj2 = new Employee();
//         {
//             _empName = "Josh",
//             // IDnum = "1",

//         };
    
//     string jsonstring = JsonSerializer.Serialize(empobj1, new JsonSerializerOptions(){WriteIndent = true});
//     Console.WriteLine(jsonstring);

//     File.WriteAllText(_filepath, jsonstring);

//     string jsonstring2 = File.ReadAllText(_filepath);
//     Console.WriteLine(jsonstring2);

//     Employee empobj2 = JsonSerializer.Deserialize<Employee>(jsonstring2);
//     Console.WriteLine(empobj2.empName);
//     }
// }