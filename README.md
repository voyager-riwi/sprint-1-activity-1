# sprint-1-activity-1
Cine Intergaláctico - README
Overview

This program is designed to calculate the final price of a cinema ticket based on various factors such as age, type of movie, day of the week, time, membership, promo activity, student status, and if the customer is purchasing in a couple. The task is intended for beginners to practice conditional statements in C#.

Purpose

The task allows you to apply nested if statements to account for multiple conditions and exceptions, simulating a complex pricing system in a fictional cinema. The program should output the base price, applied discounts, and the final price the customer needs to pay.

Input

The program expects the following inputs:

age (string): The age of the customer.

movie (string): The type of movie: "premier", "classic", "3d", "marathon", or "special".

day (string): The day of the week (e.g., Monday).

time (string): The time of day: 24 hours format.

membership (string): The membership type: "none", "silver", "gold", or "platinum".

specialPrice (bool): A boolean flag indicating if a promotion is active.

isStudent (bool): A boolean flag indicating if the customer is a student.

combo (bool): A boolean flag indicating if the customer is purchasing a combo for two (this applies a discount on the second ticket).

price (decimal): The base price of the ticket before any discounts or surcharges.

Rules & Conditions
Age-Based Rules:

Children (<12):

Free for classic movies on Mondays and Wednesdays (with discount).

Pays 30% of the price for 3D movies, but only before 6 PM.

Cannot attend special screenings.

Teens (12–17):

Pays full price for new releases.

50% off for classic movies on Wednesdays.

20% off for 3D movies with Silver membership (except Sundays).

adults (18–59):

Pays full price for new releases and special screenings.

Gold membership gives:

25% off for classic movies (except Friday or Saturday night).

15% off for 3D movies (except Sunday).

Platinum membership gives:

35% off on everything (except new releases on Saturday night, where they pay full price).

Seniors (60+):

Always gets a 40% discount.

If it’s Sunday and there’s an active promotion, they get 70% off.

For marathons, they pay 50% of the price.

Day-Based Rules:

Wednesday: Global discount day — everyone pays 80% of the base price (except special screenings, which have no discount).

Friday y Saturday at night: No membership discounts apply.

Movie Type Rules:

Premier: Always more expensive, discounts apply only if the customer is a student (15%) or has Platinum membership (35%, except Saturday night).

Classic: Base for all discounts.

3D: Always has a 10% surcharge on the final price after discounts.

Marathon: Fixed price with 20% off, except for seniors who pay 50%.

Special: Only adults and seniors can attend. No discounts apply.

Extras:

Student:

If it's Monday or Wednesday, an extra 10% discount applies on top of any other discounts.

Combo:

If the customer is buying for two, the second ticket gets a 50% discount, but only if it’s not Sunday.

specialPrice:

On Sundays, adds an extra 10% discount on top of other discounts (except special screenings).

On other days, applies only if the user has Silver membership or higher (+5%).

Validation Order

Age (check if the customer is a child, teen, adult, or senior).

Day of the Week (Wednesday has global discounts, Friday/Saturday night blocks membership discounts).

Movie Type (Premier, Classic, 3d, Marathon, Special).

Membership (None, Silver, Gold, Platinum).

Extras (Student, Couple, Active Promotion).

Output

The program should output the following information:

Discounts: List all discounts applied and explain why (e.g., "Miércoles de descuento + Estudiante + Membresía Silver").

Price: The final price after all discounts and surcharges.

Instructions

Initialize the input variables based on user input or hardcoded values for testing.

Implement nested if statements to account for all rules and conditions.

Calculate the final price by considering all applicable conditions.

Output the base price, applied discounts, and the final price in a clear and understandable format.

Author

This project was developed by Juan David Barrera for learning purposes in C#.
