Console.WriteLine("Enter your first name");
string userName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n):"); char userGender = char.Parse(Console.ReadLine());

string greeting;

if (userGender == 'f')
{
    greeting = "Ms.";
}

else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}


Console.WriteLine($"Hello, {greeting} {userName}!");

Console.WriteLine("Enter your year of birth:");

int userYOB = Int32.Parse(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int userAge = currentYear - userYOB;

//Console.WriteLine($"Current Year: {currentYear}");


//int userAge = Int32.Parse(Console.ReadLine());


if (userAge >= 13)
{
    Console.WriteLine($"You are {userAge} - old enough to have an account");
}

else
{
    Console.WriteLine($"You are {userAge} - to young to have an account");
}
