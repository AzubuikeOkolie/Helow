// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;
using System.Xml.Linq;

var totalPrice = 1 + /* This is an online comment*/ 2;
Console.WriteLine("Hello, World!" + totalPrice);

Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

int age = 23;
double price = 344.0D;

Console.WriteLine($"The name of the variable is {nameof(age)} with value {age}, also the variable name is {nameof(price)} with value {price}");

//Assembly myAsssembly = Assembly.GetEntryAssembly();

//if (myAsssembly == null) return;

//foreach (var name in myAsssembly.GetReferencedAssemblies())
//{
//    Assembly a = Assembly.Load(name);

//    int methodCount = 0;

//    foreach (TypeInfo t in a.DefinedTypes)
//    {
//        // add up the counts of methods
//        methodCount += t.GetMethods().Count();
//    }

//    Console.WriteLine(
//   "{0:N0} types with {1:N0} methods in {2} assembly.",
//   arg0: a.DefinedTypes.Count(),
//    arg1: methodCount,
//   arg2: name.Name);
//}
