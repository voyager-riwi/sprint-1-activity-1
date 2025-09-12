# sprint-1-activity-1
# Cinema Ticket Pricing System
## Overview

This is a C# console application that simulates a cinema ticket pricing system.
The program calculates the final ticket price based on different conditions such as:

-Age of the customer

-Type of movie (new release, classic, 3D, marathon, special function)

-Day of the week

-Time of the show (morning, afternoon, night)

-Type of membership (none, silver, gold, platinum)

-Student status

-Couple promotion

-Active promotions

The base ticket price is 10.00. Multiple discounts and rules are applied to determine the final ticket cost.

# Features

Discounts and rules for different age groups:

Children (<12 years): Free or discounted tickets depending on the movie and day.

Teenagers (12–17 years): Membership and weekday discounts.

Adults (18–59 years): Membership-specific discounts with restrictions.

Seniors (60+): Special senior discounts and Sunday promotions.

Special conditions:

# Students get additional discounts.

-Couple discount: buy one ticket, get the second at 50%.

-Wednesday discounts (up to 80%).

-Active promotions with stackable discounts.

-Extra charges for 3D movies.

-How to Run

Clone or download this repository.

Open the project in your favorite C# IDE (e.g., Visual Studio, Rider, or VS Code with C# extension).

Run the program:

dotnet run

# Example Usage
Please enter your age:
12
Please enter the movie type (estreno, clasico, 3D, maraton, funcion_especial):
clasico
Please enter the day:
miercoles
Please enter the time (mañana, tarde, noche):
tarde
Please enter membership type (ninguna, silver, gold, platino):
silver
Is there an active promotion? (true/false):
true
Are you a student? (true/false):
true
Are you coming as a couple? (true/false):
false


The system will calculate the price and show applied discounts step by step.

# Key Rules

Children under 12: Free entry on Mondays and Wednesdays for classics.

Students: Extra 15% discount on new releases, plus 10% on Mondays/Wednesdays.

Memberships:

Silver → 20% on 3D (except Sundays).

Gold → 15–25% depending on type (restrictions on weekends).

Platinum → 35% discount except special cases.

Wednesdays: Up to 80% discount (not valid for special functions).

Seniors: 40–70% discount depending on movie type and promotions.

# Project Structure
CinemaTicketSystem/
│── Program.cs   # Main program with pricing logic
│── README.md    # Documentation

# Learning Goals

This project demonstrates:

Use of if/else conditions in C#.

Handling user input via the console.

Applying nested conditions for real-world business rules.

Working with boolean logic and discount accumulation.
