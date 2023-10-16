// Value and Reference type
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

var isWhite = false;
var address = "Bobur Shox ko'chasi, 8";

//Static and Dynamic
var modelNumber = "34567890";

//Dynamic 
//Can't access any members from object
//object exampleObject = new User();
//exampleObject.Name = "Tom";


//Can assign any type value
object objectA = 10;
objectA = "Java";
var unboxedString = (string)objectA;
Console.WriteLine(unboxedString);

//Can access members with dynamic
dynamic objectB = new User();
objectB.Name = "Bob";
Console.WriteLine(objectB.Name);
//Console.WriteLine(objectB.LastName);


var staticString = "string";
object dynamicString = (object)staticString;

object variable = new object();
GCHandle handleA = GCHandle.Alloc(staticString, GCHandleType.Pinned);
GCHandle handleB = GCHandle.Alloc(dynamicString, GCHandleType.Pinned);
IntPtr pointerA = handleA.AddrOfPinnedObject();
IntPtr pointerB = handleB.AddrOfPinnedObject();

Console.WriteLine(pointerA.ToString());
Console.WriteLine(pointerB.ToString());
//Built-in and Complex types

public class User
{
    public string Name { get; set; }
    public string Lastame { get; set; }
}