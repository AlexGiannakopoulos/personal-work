
//ask user for car info(number,brand,km)
//put user inputs in a list
//imagine 5 cars
// make a class to add new cars (objects)

using Exercise3OOP;

List<Cars> myList = new List<Cars>();

Console.Write("How many cars listed?: ");
int listLen = Int32.Parse(Console.ReadLine());

for (int i = 0; i < listLen; i++)
{
    Console.Write("Car "+ (i+1) + " number?: ");
    string num = Console.ReadLine();
    Console.Write("Car brand?: ");
    string brand = Console.ReadLine();
    Console.Write("Car killometers traveled?: ");
    int km = Int32.Parse(Console.ReadLine());
    Cars c = new Cars(num, brand, km);
    
    myList.Add(c);

    
}
foreach (Cars a in myList)
{
    Console.WriteLine(a);
}

