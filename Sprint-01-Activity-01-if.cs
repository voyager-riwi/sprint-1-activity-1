// ejercicio IF

Console.WriteLine("Por favor dame tu edad:");
string edad = Console.ReadLine();
int edadP = int.Parse(edad);

Console.WriteLine("Por favor dame el tipo de pelicula (estreno, clasico, 3D, maraton, funcion_especial):");
string tipo_pelicula = Console.ReadLine();

Console.WriteLine("Por favor dame el dia (lunes, martes, ...):");
string dia = Console.ReadLine();

Console.WriteLine("Por favor dame la hora (mañana, tarde, noche):");
string hora = Console.ReadLine();

Console.WriteLine("Por favor dame el tipo de membresia (ninguna, silver, gold, platino):");
string membresia = Console.ReadLine();

Console.WriteLine("¿promo activa? (true/false):");
bool promo = Console.ReadLine().ToLower() == "true";

Console.WriteLine("¿Es estudiante? (true/false):");
bool estudiante = Console.ReadLine().ToLower() == "true";

Console.WriteLine("¿Pareja? (true/false):");
bool pareja = Console.ReadLine().ToLower() == "true";

decimal precio_base = 10.000M;
decimal precio_final = precio_base;

// para niños (<12)
if (edadP < 12 && tipo_pelicula == "clasico" && (dia == "lunes" || dia == "miercoles"))
{
    precio_final = 0;
    Console.WriteLine($"Precio base = {precio_base}, Tu boleta es gratis en clásicos los lunes y miércoles de descuento, precio boleta = {precio_final}");
}
else if (edadP < 12 && tipo_pelicula == "3D" && hora == "tarde")
{
    precio_final -= (precio_base * 30) / 100;
    Console.WriteLine($"Precio base = {precio_base}, Tienes el 30% de descuento en tu boleta por escoger 3D y en horas de la tarde, precio boleta = {precio_final}");
}
else if (edadP < 12 && tipo_pelicula == "funcion_especial")
{
    Console.WriteLine("Los menores de 12 años no pueden entrar a funciones especiales.");
}
else if (edadP < 12)
{
    precio_final = precio_base;
    Console.WriteLine($"Tu boleta cuesta el precio completo = {precio_final}");
}

// para adolescentes (12-17)
if (edadP >= 12 && edadP <= 17 && tipo_pelicula == "estreno")
{
    precio_final = precio_base;
    Console.WriteLine($"Pagas la boleta completa con estrenos, precio boleta = {precio_final}");
}
else if (edadP >= 12 && edadP <= 17 && tipo_pelicula == "clasico" && dia == "miercoles")
{
    precio_final -= (precio_base * 50) / 100;
    Console.WriteLine($"Precio base {precio_base}, Pagan 50% en clásicos los miércoles, valor boleta  = {precio_final}");
}
else if (edadP >= 12 && edadP <= 17 && membresia == "silver" && tipo_pelicula == "3D")
{
    if (dia == "domingo")
    {
        precio_final = precio_base;
        Console.WriteLine($"Los domingos no se hace efectivo el descuento de membresía, valor boleta {precio_final}");
    }
    else
    {
        precio_final -= (precio_base * 20) / 100;
        Console.WriteLine($"Precio base {precio_base}, Tienes membresia silver obtienes 20% de descuento en peliculas 3D, valor boleta  = {precio_final}");
    }
}
else if (edadP >= 12 && edadP <= 17)
{
    precio_final = precio_base;
    Console.WriteLine($"No tienes descuentos aplicables. El valor de tu boleta es el precio completo = {precio_final}");
}

// para adultos (18-59)
if (edadP >= 18 && edadP <= 59 && (tipo_pelicula == "estreno" || tipo_pelicula == "funcion_especial"))
{
    precio_final = precio_base;
    Console.WriteLine($"Pagan completo en estrenos y funciones especiales, valor boleta = {precio_final}");
}
else if (edadP >= 18 && edadP <= 59 && membresia == "gold")
{
    if (tipo_pelicula == "clasico")
    {
        if (hora == "noche" && (dia == "viernes" || dia == "sabado"))
        {
            precio_final = precio_base;
            Console.WriteLine($"Tienes membresia gold pero viernes y sabado en la noche no es valido el descuento, valor boleta = {precio_final}.");
        }
        else
        {
            precio_final -= (precio_base * 25) / 100;
            Console.WriteLine($"Precio base = {precio_base}, Tienes el 25% de descuento por tener membresia gold en peliculas clasicas, valor boleta = {precio_final}");
        }
    }
    else if (tipo_pelicula == "3D")
    {
        if (dia == "domingo")
        {
            precio_final = precio_base;
            Console.WriteLine($"Tienes membresia gold, pero el descuento en 3D no aplica los domingos. Valor boleta = {precio_final}");
        }
        else
        {
            precio_final -= (precio_base * 15) / 100;
            Console.WriteLine($"Precio base = {precio_base}, Tienes el 15% de descuento por tener membresia gold en peliculas 3D, valor boleta = {precio_final}");
        }
    }
    else
    {
        precio_final = precio_base;
        Console.WriteLine($"Tu membresía gold no ofrece descuento para este tipo de película. Valor boleta = {precio_final}");
    }
}
else if (edadP >= 18 && edadP <= 59 && membresia == "platino")
{
    if (tipo_pelicula == "estreno" && dia == "sabado" && hora == "noche")
    {
        precio_final = precio_base;
        Console.WriteLine($"Pagas completa la boleta para este tipo de pelicula, dia y hora, valor boleta = {precio_final}");
    }
    else
    {
        precio_final -= (precio_base * 35) / 100;
        Console.WriteLine($"Precio base = {precio_base}, Tienes el 35% de descuento en esta pelicula por tener membresia platino, valor boleta = {precio_final}");
    }
}
else if (edadP >= 18 && edadP <= 59)
{
    precio_final = precio_base;
    Console.WriteLine($"El valor de tu boleta es el precio completo = {precio_final}");
}

// seniors (60+)
if (edadP >= 60)
{
    if (dia == "domingo" && promo == true)
    {
        precio_final -= (precio_base * 70) / 100;
        Console.WriteLine($"Precio base = {precio_base}, Tienes el 70% de descuento, por ser dia domingo y promo activa, valor boleta = {precio_final}");
    }
    else if (tipo_pelicula == "maraton")
    {
        precio_final -= (precio_base * 50) / 100;
        Console.WriteLine($"Precio base = {precio_base}, pagas el 50% de la boleta por esta pelicula, valor boleta = {precio_final}");
    }
    else
    {
        precio_final -= (precio_base * 40) / 100;
        Console.WriteLine($"Precio base = {precio_base}, Tienes el 40% de descuento, valor boleta = {precio_final}");
    }
}

// por día de la semana
if (dia == "miercoles" && tipo_pelicula != "funcion_especial")
{
    precio_final -= (precio_base * 80) / 100;
    Console.WriteLine($"Miércoles de descuento. Precio final = {precio_final}");
}
if (hora == "noche" && (dia == "viernes" || dia == "sabado"))
{
    precio_final = precio_base;
    Console.WriteLine($"No aplica descuentos por membresía, valor boleta = {precio_final}");
}

// por tipo de pelicula
if (estudiante && tipo_pelicula == "estreno")
{
    precio_final -= (precio_base * 15) / 100;
    Console.WriteLine($"Precio base = {precio_base}, Estudiante en estreno 15%. Precio final = {precio_final}");
}
else if (tipo_pelicula == "estreno" && membresia == "platino")
{
    precio_final -= (precio_base * 35) / 100;
    Console.WriteLine($"Precio base = {precio_base}, pelicula en estreno con membresia platino 35%. Precio final = {precio_final}");
}
if (tipo_pelicula == "3D")
{
    precio_final += (precio_base * 10) / 100; 
    Console.WriteLine($"Precio base = {precio_base}, 3D recargo 10%. Precio final = {precio_final}");
}
if (tipo_pelicula == "maraton")
{
    precio_final -= (precio_base * 20) / 100;
    Console.WriteLine($"Precio base = {precio_base}, Maratón paga 80%. Precio final = {precio_final}");
}
if (tipo_pelicula == "funcion_especial")
{
    if (edadP >= 18)
    {
        precio_final = precio_base;
        Console.WriteLine($"Precio base = {precio_base}, Función especial sin descuentos. Precio final = {precio_final}");
    }
    else
    {
        Console.WriteLine("Los menores de edad no pueden entrar a funciones especiales.");
    }
}

// extras
if (estudiante && (dia == "lunes" || dia == "miercoles"))
{
    precio_final = precio_final * 0.9M;
    Console.WriteLine($"Estudiante lunes/miércoles 10% extra. Precio final = {precio_final}");
}
if (pareja && dia != "domingo")
{
    decimal total = precio_base + (precio_base * 0.5M);
    Console.WriteLine($"Pareja: 2 boletos, segundo al 50%. Total = {total}");
}
if (promo && dia == "domingo" && tipo_pelicula != "funcion_especial")
{
    precio_final = precio_final * 0.9M;
    Console.WriteLine($"Promo activa domingo: -10% acumulable. Precio final = {precio_final}");
}
if (promo && dia != "domingo" && (membresia == "silver" || membresia == "gold" || membresia == "platino"))
{
    precio_final = precio_final * 0.95M;
    Console.WriteLine($"Promo activa con membresía {membresia}: -5% acumulable. Precio final = {precio_final}");
}
