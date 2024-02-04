// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!");

Console.WriteLine("This is the first line.");
Console.Write("This is the second line.");

Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");

// Store and retrieve data using literal and variable values
    // ('') creates a charecter literal
    // ("") creates a string literal
    // (true) creates a boolean literal
    // (123) creates an integer literal

// Make new line using \n
Console.Write("\n");

Console.WriteLine('A');
Console.WriteLine("A");
Console.WriteLine(true);
Console.WriteLine(123);

// Floating-point literals/ numbers
    // float
    // double
    // decimal

Console.WriteLine(0.25F); // float
Console.WriteLine(2.625); // double
Console.WriteLine(12.39816m); // decimal

// Declaring a variable
string firstName;
string lastName;

// use camelCase for variable names
// use PascalCase for class names
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

// Setting and getting values from variables
firstName = "Bob";
Console.WriteLine(firstName);
lastName = "Smith";
Console.WriteLine(lastName);
userOption = 'B';
Console.WriteLine(userOption);
gameScore = 10;
Console.WriteLine(gameScore);
particlesPerMillion = 12.39816m;
Console.WriteLine(particlesPerMillion);
processedCustomer = true;
Console.WriteLine(processedCustomer);
// Reasdigning a variable
firstName = "Robert";
Console.WriteLine(firstName);

var message = "Hello World!"; // Cannot reasign a var
Console.WriteLine(message);

// Display literal and variable values
    // Store the following values in variables
        // Bob
        // 3
        // 34.4
            // Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
string firstName2;
int messages;
double temperature;

firstName2 = "Bob";
messages = 3;
temperature = 34.4;

Console.WriteLine("Hello, " + firstName2 + "! You have " + messages + " messages in your inbox. The temperature is " + temperature + " celcius.");

// Format output using charecter escape sequences
    // \n - new line
    // \t - tab
    // \\ - backslash
    // \" - double quote
    // \' - single quote
// create the mockup of the command line tool
Console.WriteLine("Generate invoices for customer \"Contoso\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Generate invoices for customer "Contoso" ...
// Invoice: 1021		Complete!
// Invoice: 1022		Complete!
// Output Directory:

// Verbatim string literal
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");


// Verbatim string literal
Console.WriteLine(@"Generate invoices for customer ""Contoso"" ...
");
Console.WriteLine(@"Invoice: 1021   Complete!");
Console.WriteLine(@"Invoice: 1022   Complete!");
Console.WriteLine(@"    Output Directory:");

Console.Write(@"c:\invoices");
Console.WriteLine(); // new line

// Combine strings using string concatenation
string firstName3 = "Bob";
string message2 = "Hello " + firstName3;
Console.WriteLine(message2);
// This is called intermediate variables and should be avoided

string firstName4 = "Bob";
string message4 = "Hello";
Console.WriteLine(message4 + " " + firstName4 + "!");

// Combine strings using string interpolation
string message5 = $"{message4} {firstName4}!";
Console.WriteLine(message5);


string firstName5 = "Bobby";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName5}!");
// Hello Bobby!

// Combine strings using string interpolation
// instead of this
string message6 = greeting + " " + firstName5 + "!";
Console.WriteLine(message6);
// Hello Bobby!

// use interpolation using template string
string message7 = $"{greeting} {firstName}!";
Console.WriteLine(message7);
// Hello Robert!

// instead of this
string message8 = greeting + " " + firstName + "!";
Console.WriteLine(message8);
// Hello Robert!

// use interpolation using template string
string message9 = $"{greeting} {firstName}!";
Console.WriteLine(message9);
// Hello Robert!


// Use string interpolation to combine a literal string and a variable value
int version = 11;
string updateText = "Update to Windows";
string message10 = $"{updateText} {version}";
Console.WriteLine(message10);
// Update to Windows 11
    // Avoid using intermediate variable

// More Concise
int version2 = 11;
string updateText2 = "Update to Windows";
Console.WriteLine($" {updateText2} {version2}!");
// Update to Windows 11

// Combine verbatim literals and string interpolation
    // You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
// C:\Output\First-Project\Data


string projectName2 = "ACME";
Console.WriteLine("View English output:\t");
Console.WriteLine($"\tc:\\Exercise\\{projectName2}\\data.txt");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"\n {russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

// Recommended solution
string projectName3 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName3}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage2 = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation2 = $@"c\Exercise\{projectName3}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage2}:\n\t\t{russianLocation2}");

//  Perform addition with implicit data conversion
    // '+' operator can be used to add two numbers or to concatenate two strings
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
// 19

// Mix data types to force implicit type conversions
string firstName6 = "Steve";
int widgetsSold = 7;
Console.WriteLine(firstName6 + " sold " + widgetsSold + " widgets.");
// Steve sold 7 widgets.

// Attempt a more advanced case of adding numbers and concatenating strings
string firstName7 = "Steve";
int widgetsSold2 = 10;
Console.WriteLine(firstName7 + " sold " + widgetsSold2 + 7 + " widgets.");
// Steve sold 107 widgets.

string firstName8 = "Steve";
int widgetsSold3 = 10;
Console.WriteLine(firstName8 + " sold " + (widgetsSold3 + 7) + " widgets.");
// Steve sold 17 widgets.
    // avoid performing both a calculation and concatenation in a single line of code

string firstName9 = "Steve";
int widgetsSold4 = 20;
string message11 = firstName9 + " sold " + (widgetsSold4 + 7) + " widgets.";
Console.WriteLine(message11);
// Steve sold 27 widgets.


// Perform math operations
    // Perform addition with explicit data conversion
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// Sum: 12
// Difference: 2
// Product: 35
// Quotient: 1

// Add code to perform division using literal decimal data
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");
// Decimal quotient: 1.4

decimal decimalQuotient2 = 7 / 5.0m;
Console.WriteLine($"{decimalQuotient2}");
// 1.4

// Add code to perform division using literal decimal data
int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);
// 1.4

// Write code to determine the remainder after integer division
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
// Modulus of 200 / 5 : 0
// Modulus of 7 / 5 : 2

// PEMDAS
    // Parentheses
    // Exponents
    // Multiplication and Division
    // Addition and Subtraction
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
// 23
// 35

int value = 0; // 0
value = value + 1; // 1
value += 5; // 6
Console.WriteLine(value);
    // lines 1 and 2 are equivalent
    // line 3 is a shorthand for line 2

int value3 = 0; // 0
value3 = value3 + 1; // 1
value3++; // 2
Console.WriteLine(value3);
    // lines 1 and 2 are equivalent
    // line 3 is a shorthand for line 2

int value4 = 1; // 1
value4 = value4 + 1;
Console.WriteLine("First increment: " + value4); // 2
value4 += 1;
Console.WriteLine("Second increment: " + value4); // 3
value4++;
Console.WriteLine("Third increment: " + value4); // 4
value4 = value4 - 1;
Console.WriteLine("First decrement: " + value4); // 3
value4 -= 1;
Console.WriteLine("Second decrement: " + value4); // 2
value4--;
Console.WriteLine("Third decrement: " + value4); // 1

// Use the increment operator using string interpolation
int value5 = 1;
value5++;
Console.WriteLine("First: " + value5);
Console.WriteLine($"Second: {value5++}");
Console.WriteLine($"Third: " + value5);
Console.WriteLine("Fourth: " + (++value5));

// Convert Fahrenheit to Celsius
int fahrenheit = 94;
double celsius = (fahrenheit - 32) * 5.0 / 9.0;
Console.WriteLine($"The temperature is {celsius} Celsius.");
// The temperature is 34.4444444444444 Celsius.

    // Recommended solution
int fahrenheit2 = 94;
decimal celsius2 = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius2 + " Celsius.");
// The temperature is 34.



