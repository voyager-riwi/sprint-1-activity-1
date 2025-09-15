Console.WriteLine("What is your age?: ");
string age = Console.ReadLine();
Console.WriteLine(("What kind of movie are you watching?: "));
string movie = Console.ReadLine().ToLower();
Console.WriteLine(("What is today's day?: "));
string day = Console.ReadLine().ToLower();
Console.WriteLine(("What time is it? (24h format): "));
string time = Console.ReadLine();
Console.WriteLine(("What membership do you have?"));
string membership = Console.ReadLine().ToLower();
Console.WriteLine(("Is there any special price?: "));
bool specialPrice = true;
if (Console.ReadLine().ToLower() == "no")
{
    specialPrice = false;
}
else if (Console.ReadLine().ToLower() == "yes")
{
    specialPrice = true;
}
Console.WriteLine(("Are you a student?: "));
bool isStudent = true;
if (Console.ReadLine().ToLower() == "no")
{
    isStudent = false;
}
else if (Console.ReadLine().ToLower() == "yes")
{
    isStudent = true;
}
Console.WriteLine(("Did you buy a combo?: "));
bool combo = true;
if (Console.ReadLine().ToLower() == "no")
{
    combo = false;
}
else if (Console.ReadLine().ToLower() == "yes")
{
    combo = true;
}
double price = 12000;

if (combo)
{
     price = 24000;
}
string discounts = null;
bool isRestricted = false; 

// age validation

if (int.Parse(age) < 12 && int.Parse(age) > 0)
{
    if ((day == "monday" || day == "wednesday") && movie == "classic")
    {
        price = 0;
        specialPrice = true;
        discounts = "Child";
    }
    else if (movie == "3d" && int.Parse(time) <= 18)
    {
        price = price * 0.3;
        specialPrice = true;
        discounts = "Child";
    }
    else if (movie == "special")
    {
        Console.WriteLine("You cannot enter to special movies");
        isRestricted = true;
    }
    else
    {
        specialPrice = false;
    }
}

else if (int.Parse(age) >= 12 && int.Parse(age) <= 17)
{
    if (movie == "premier")
    {
        specialPrice = false;
    }

    else if (movie == "classic" && day == "wednesday")
    {
        price = price * 0.5;
        specialPrice = true;
        discounts = "Teen";
    }

    else if (membership == "silver" && movie == "3d" && day != "sunday")
    {
        price = price * 0.8;
        specialPrice = true;
        discounts = "Teen";
    }
    else if (movie == "special")
    {
        isRestricted = true;
    }
    else
    {
        specialPrice = false;
    }
}

else if (int.Parse(age) >= 18 && int.Parse(age) < 60)
{
    if (movie == "premier" || movie == "special")
    {
        price = price;
        specialPrice = false;
    }
    else if (membership == "gold" && movie == "classic" && !(day == "friday" || day == "saturday" && int.Parse(time) >= 19))
    
    {
        price = price * 0.75;
        specialPrice = true;
        discounts = "Adult";
    }

    else if (membership == "gold" && movie == "3d" && day != "sunday")
    {
        price = price * 0.85;
        specialPrice = true;
        discounts = "Adult";
    }
    else if (membership == "platinum" && movie != "premier" && !(day == "saturday" && int.Parse(time) >= 19))
    {
        price = price * 0.65;
        specialPrice = true;
        discounts = "Adult";
    }
    else
    {
        specialPrice = false;
    }
}

else if (int.Parse(age) >= 60)
{
    if (day == "sunday" && specialPrice)
    {
        price = price * 0.3;
        specialPrice = true;
        discounts = "Elder";
    }
    else if (movie == "marathon")
    {
        price = price * 0.5;
        specialPrice = true;
        discounts = "Elder";
    }
    else
    {
        price = price * 0.6;
        specialPrice = true;
        discounts = "Elder";
    }
}

// day validation

if (day == "wednesday" && movie != "special")
{
    price = price * 0.8;
    specialPrice = true;
    discounts += " - wednesday discount";
}

// movie type

if (movie == "premier" && int.Parse(age) < 60)
{
    if (isStudent)
    {
        price = price * 0.85;
        specialPrice = true;
        discounts += " - student discount";
    }
    else if (membership == "platinum" && (day != "saturday" && int.Parse(time) < 19))
    {
        price = price * 0.65;
        specialPrice = true;
        discounts += " - membership discount";
    }
}

else if (movie == "3d")
{
    price = price * 1.1;
}

else if (movie == "marathon" && int.Parse(age) < 60)
{
    price = price * 0.8;
    specialPrice = true;
    discounts += " - marathon discount";
}

else if (movie == "special")
{
    price = 12000;
    specialPrice = false;
}

// extras

if (isStudent && (day == "wednesday" || day == "monday"))
{
    price = price * 0.9;
    specialPrice = true;
    discounts += " - student discount";
}

if (combo && day != "sunday")
{
    price = price * 0.5;
    specialPrice = true;
    discounts += " - Combo discount";
}

if (movie != "special" && day == "sunday")
{
    price = price * 0.9;
    specialPrice = true;
    discounts += " - new discount";
}

if (membership == "silver" || membership == "gold")
{
    price = price * 0.95;
    specialPrice = true;
    discounts += " - membership discount";
}

if (!isRestricted)
{
    Console.WriteLine($"Discounts = {discounts} \nTotal = {price}");
}
