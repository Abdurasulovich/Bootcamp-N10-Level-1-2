// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown " +
    "printer took a galley of type and scrambled it to make a type specimen book. It has survived not " +
    "only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
    "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

#region Nimadur:
//Unformatted string
//Cases- Lower, Upper


/*var unformattedFirstName = "fIrDaVs";
var capitalizedFirstName = string.Concat(unformattedFirstName.Substring(0, 1)
    .ToUpper(), unformattedFirstName.Substring(1).ToLower());
Console.WriteLine(capitalizedFirstName);*/

//=== === === === === === === === === === === === === ===

//Comparison and Equality

//! Only for objects
// == - compares by reference
//instance.Equals - by value
// class.Equals - by value
// class.ReferenceEquals - by reference

/*var objectA = (object)12;
var objectB = (object)12;
Console.WriteLine(objectA == objectB);
Console.WriteLine(objectA.Equals(objectB));
Console.WriteLine(object.Equals(objectA, objectB));
Console.WriteLine(object.ReferenceEquals(objectA, objectB));*/

//=== === === === === === === === === === === === === === === === === === ===

/*var objectA = "text";
var objectB = objectA;
Console.WriteLine($"objectA == objectB - { objectA == objectB}");
Console.WriteLine($"objectA.Equals(objectB -{ objectA.Equals(objectB)}");
Console.WriteLine($"object.Equals(objectA, objectB) - {object.Equals(objectA, objectB)}");
Console.WriteLine($"object.ReferenceEquals(objectA, objectB) - {object.ReferenceEquals(objectA, objectB)}");
*/

/*Console.Write("Enter your firstname: ");
var input = Console.ReadLine();
var formattedInput = string.Concat(input.Substring(0, 1)
    .ToUpper(), input.Substring(1).ToLower());

Console.WriteLine(input == formattedInput);*/

//=== === === === === === === === === === === === === === === === === === ===
#endregion

/*var firstName1 = "john";
var firstName2 = "jOhN";
Console.WriteLine();
Console.WriteLine($"firstName1 equals fistName2 {firstName1.Equals(firstName2, StringComparison.OrdinalIgnoreCase)}");


//Searching
Console.WriteLine($"text contains saepe - {text.Contains("saepE", StringComparison.OrdinalIgnoreCase)}");

var wordIndex = text.IndexOf("standarD", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(text.Substring(wordIndex, 10));*/

//Replacing
/*var userNameToken = "{{UserName}}";
var urlToken = "{{Url}}";
var appNameToken = "{{AppName}}";

var notification = "Hello {{UserName}}, Welcome to our {{Url}}, Enter this {{AppName}}, to varify your account";

var formattednotification = notification
    .Replace(userNameToken, "John")
    .Replace(urlToken, "www.soft-furniture.com")
    .Replace(appNameToken, "Email");
Console.WriteLine(formattednotification);*/

//Trim and Padding
Console.WriteLine("Trimming: ");
var exampleforTrim = " text   text    text    text  ** ";


/*var wordSplitted = exampleforTrim.Split();
for (var index = 0; index < wordSplitted.Length; index++)
    wordSplitted[index] = wordSplitted[index].Trim();
var formattedForTrim = string.Join(" ", wordSplitted);
Console.WriteLine($"Format bo'ganda: {formattedForTrim}");
Console.WriteLine(exampleforTrim.Trim().Length);*/

//Console.WriteLine($"Trim default - {exampleforTrim.Trim()} and length {exampleforTrim.Trim().Length}");
//Console.WriteLine($"Trim default - {exampleforTrim.Trim('*', ' ')} and length {exampleforTrim.Trim().Length}");


//Padding

Console.WriteLine($"Padding default - {exampleforTrim.PadLeft(10)} and length {exampleforTrim.PadLeft(10)}");
Console.WriteLine($"Padding default - {exampleforTrim.PadRight(10, '*')} and length {exampleforTrim.PadRight(10)}");
