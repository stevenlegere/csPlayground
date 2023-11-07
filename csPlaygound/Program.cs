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




