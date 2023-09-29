/*
   
   This is a training set in basic programming
   Solve the tasks in the order they are given. 
   Do not change code unless explisitly asked to do so.
    
*/

/*
    Task: Example 
    Write the code needed to output the names to terminal, one name per line. 
*/
Print("Task: Example");

string[] names = new string[] { "Bjarne", "Christian", "Håkon" };

for (int index = 0; index < names.Length; index++)
{
    string name = names[index];
    Print(name);
}


/*
    Task: A
    Create variables for the following:
    * Houers in a day
    * minutes in an hour
    * Seconds in a minute
    * The name of a color
    * Days remaining to xmas
    * Ratio of water to coffe in a cup
    * The name of a planet
    * The name of a country
    * Distance traveled in a car in km
*/
Print("Task: A");


/*
    Task: B
   Use the variables you created in task A to calculate the following:
    * How many seconds are there in 2.5 days?
    * How many minutes are there in 124 days?
    * How many hours are there in 36.5 weeks?
    Example:
    // How many dl is 4.5 coups?
    const double numberOfCoups = 4.5
    const double dlInCoups = 2.36588;
    double numberOfDl = dlInCoups * 4.5;
*/
Print("Task: B");


/*
    Task: C
    Use a for loop to print out the numbers from 1 to 10 
*/
Print("Task: C");



/*
    Task: D
    Use a for loop to print out the numbers from 10 to 1
*/
Print("Task: D");


/*
    Task: E
    Use a for loop to print out every tird and fifth numbers from 1 to 100
*/
Print("Task: E");


/*
    Task: F
    Fix the code so it outputs the expexted messages.
    NB! the code is broken so you will have to change it.
*/
Print("Task: F");

Dictionary<string, string> DICTIONARY = new Dictionary<string, string>()
{
    { "hello", "Hello" },
    { "howAreYou", "hvordan står det til?" },
    { "goodQuestionsLatly", "Fått noen gode spørsmål i det siste?" }
};


Print($"{DICTIONARY["hello"]}");
Christian ${DICTIONARY.howAreYou}); //-> Hello Christian, hvordan står det til?
Console.WriteLine(`${ DICTIONARY["goodQuestionsLatly"]}`) //-> Fått noen gode spørsmål i det siste?


/*
    Task: G
    Write a function that takes a string as a parameter and returns the string reversed.
*/
Print("Task: G");


/*
    Task: H
    Write a function that takes an array as input and returns the middle item.
*/
Print("Task: H");


/*
    Task: I
    Write a function that takes an array of integers as input and returns the average value of the items in the array.
*/
Print("Task: I");



/*
    Task: J
    Red = 0, Yellow = 1, Green = 2
    Write a function that takes the state of a traffic light as input and returns the action the driver should take.
*/
const int RED = 0;
const int YELLOW = 1;
const int GREEN = 2;


// Helper functions - do not change -------------------------------------

void Print(string text)
{
    Console.WriteLine(text);
}