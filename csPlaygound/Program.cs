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
decimal celsius2 = (fahrenheit2 - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius2 + " Celsius.");
// The temperature is 34.444444444444444444444444447 Celsius.


// initialize variables - graded assignments 
// This section initializes variables representing scores for different students and their assignments.
int currentAssignments = 5; // Number of current assignments.

// Scores for Sophia across 5 assignments.
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
// Scores for Nicolas across 5 assignments.
int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
// Scores for Zahirah across 5 assignments.
int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
// Scores for Jeong across 5 assignments.
int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
// Summing the scores for each student.
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
// Calculating the average score for each student.
    // The average score is calculated by dividing the sum of the scores by the number of assignments.
        // Casting the sum to a decimal to ensure the result is a decimal = (decimal) sophiaSum
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");

// Printing out the average scores along with their corresponding letter grades.
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + " \tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

string message12 = "The quick brown fox jumps over the lazy dog.";
bool result = message12.Contains("dog");
Console.WriteLine(result);

if (message12.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

// Student GPA Calculator
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;
// += operator is shorthand notation to add a value to a variable and assign the result to the variable

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

// Call different kinds of methods in the .NET Class Library
    // System.Random
        // System.Console
//Random dice = new Random();
Random dice = new(); // Target-typed constructor invocation (C# 9.0)
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Random dice2 = new Random(); // stateful method, must create an instance of the class
int roll2 = dice2.Next(1, 7); // Access the Next method on an onject of the class.
                            // An instance of a class is called an object
Console.WriteLine(roll2);

////////////////////////////////////////////////////////////////////////////////////////

// Call methods or classes from CSharpFreeCodeCamp.cs
       // CSharpFreeCodeCamp.PrintToConsole();
    


