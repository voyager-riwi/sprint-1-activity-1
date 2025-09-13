
//El Cine Intergaláctico maneja un sistema de precios complejo que depende de múltiples factores.
//Tu tarea es calcular el costo final de la boleta considerando todas las condiciones y excepciones

Console.WriteLine("Ingresa tu edad: ");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el tipo de pelicula (estreno, clasico, 3D, maraton, funcion_especial): ");
string tipoPelicula = Console.ReadLine().ToLower();

Console.WriteLine("Ingresa el día de la semana (Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo): ");
string dia = Console.ReadLine().ToLower();

Console.WriteLine("Ingresa la hora (mañana, tarde, noche): ");
string hora = Console.ReadLine().ToLower();

Console.WriteLine(" Ingresa tu membresia (ninguna, silver, gold, platino): ");
string membresia = Console.ReadLine().ToLower();

Console.WriteLine("¿Tienes promo activa? (si/no): ");
bool promoActiva = Console.ReadLine() .ToLower() == "si";

Console.WriteLine("¿Eres estudiante? (si/no): ");
bool eresEstudiante = Console.ReadLine() .ToLower() == "si";

Console.WriteLine("¿Vienes con tu pareja? (si/no): ");
bool conPareja = Console.ReadLine() .ToLower() == "si";

const int precioBase = 10000;

// Niños (<12):
//Gratis en clásicos los lunes y miércoles de descuento.
//  Pagan 30% en 3D, pero solo hasta las 6pm.
// No pueden entrar a funciones especiales.

if (edad < 12 && tipoPelicula == "clasico" && (dia == "lunes" || dia == "miercoles"))
    {
        Console.WriteLine( "El precio de la boleta es gratis.");
    }
    else if (edad < 12 && tipoPelicula == "3D" && hora != "noche")
    {
        double precioFinal = precioBase * 0.7;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
    else if (edad < 12 && tipoPelicula == "funcion_especial")
    {
        Console.WriteLine("No pueden entrar a funciones especiales.");
    }
    else if (edad < 12)
    {
        Console.WriteLine($"El precio de la boleta es: {precioBase}");
    }   

//Adolescentes (12–17):
//Pagan completo en estrenos.
//Pagan 50% en clásicos los miércoles.
//Con membresía Silver → 20% descuento en 3D, salvo domingos.

if (edad >= 12 && edad <= 17 && tipoPelicula == "estreno")
{
    Console.WriteLine($"El precio de la boleta es: {precioBase}");
}

else if (edad >= 12 && edad <= 17 && tipoPelicula == "clasico" && dia == "miercoles")
Console.WriteLine(" El precio de la boleta es: " + (precioBase * 0.5));

else if (edad >= 12 && edad <= 17 && tipoPelicula == "3D" && membresia == "silver" && dia != "domingo")
{
    double precioFinal = precioBase * 0.8;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
    
//Adultos (18–59):
//Pagan completo en estrenos y funciones especiales.
//  Con Gold →
//25% en clásicos (salvo viernes o sábado en la noche).
//15% en 3D si no es domingo.
//  Con Platino →
//Siempre 35% descuento, salvo en estrenos en sábado noche (pagan completo).

if (edad >= 18 && edad <= 59 && tipoPelicula == "estreno")
{
    Console.WriteLine($"El precio de la boleta es: {precioBase}");
}
else if (edad >= 18 && edad <= 59 && membresia == "platino")
{
    if (tipoPelicula == "estreno" && dia == "sabado" && hora == "noche")
    {
        Console.WriteLine($"El precio de la boleta es: {precioBase}");
    }
    else
    {
        double precioFinal = precioBase * 0.65;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
}

else if (edad >= 18 && edad <= 59 && tipoPelicula == "funcion_especial" && tipoPelicula == "estreno")
{
    Console.WriteLine($"El precio de la boleta es: {precioBase}");
}
else if (edad >= 18 && edad <= 59 && tipoPelicula == "clasico" && membresia == "gold" && !((dia == "viernes" || dia == "sabado") && hora == "noche"))

{
    double precioFinal = precioBase * 0.75;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (edad >= 18 && edad <= 59 && tipoPelicula == "3D" && membresia == "gold" && dia != "domingo")
{
    double precioFinal = precioBase * 0.85;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (edad >= 18 && edad <= 59 && membresia == "platino")
{
    double precioFinal = precioBase * 0.65;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}


//Seniors (60+):
//Siempre 40% descuento.
//Si es domingo y hay promo activa → 70% descuento.
// Si es maratón → pagan 50% fijo.

if (edad >= 60 && dia == "domingo" && promoActiva)
{
    double precioFinal = precioBase * 0.3;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (edad >= 60 && tipoPelicula == "maraton")
{
    double precioFinal = precioBase * 0.5;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (edad >= 60)
{
    double precioFinal = precioBase * 0.6;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}

//Por día de la semana
//Miércoles = día de descuento global → todos pagan 80% del precio (descuento general), salvo funciones especiales que nunca tienen rebaja.
//Viernes y sábado en la noche → no aplican descuentos por membresía (regla rígida).

if (dia == "miercoles" && tipoPelicula != "funcion_especial")
{
    double precioFinal = precioBase * 0.8;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if ((dia == "viernes" || dia == "sabado") && hora == "noche" && (membresia == "gold" || membresia == "platino"))
{
    Console.WriteLine($"El precio de la boleta es: {precioBase}");
}

//Por tipo de película
//Estreno → siempre más caro, solo descuentos si la persona es estudiante (15%) o si tiene Platino (35%, excepto sábado noche).
//Clásico → base para aplicar todos los descuentos.
//3D → siempre hay un recargo de +10% al precio final, después de aplicar descuentos.
//Maratón → precio único con 20% descuento general, salvo seniors (que pagan 50%).
//Función especial → solo adultos y seniors pueden entrar, nunca aplica descuento.

if (tipoPelicula == "estreno")
{
    if (eresEstudiante)
    {
        double precioFinal = precioBase * 0.85;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
    else if (membresia == "platino" && !(dia == "sabado" && hora == "noche"))
    {
        double precioFinal = precioBase * 0.65;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
    else
    {
        Console.WriteLine($"El precio de la boleta es: {precioBase}");
    }
}
else if (tipoPelicula == "3D")
{
    double precioFinal = precioBase * 1.1; 
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (tipoPelicula == "maraton")
{
    if (edad >= 60)
    {
        double precioFinal = precioBase * 0.5;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
    else
    {
        double precioFinal = precioBase * 0.8;
        Console.WriteLine($"El precio de la boleta es: {precioFinal}");
    }
}
else if (tipoPelicula == "funcion_especial" && edad < 18)
{
    Console.WriteLine("No pueden entrar a funciones especiales.");
}

//Extras 
//Si el cliente es estudiante y es lunes o miércoles → tiene un 10% extra acumulable sobre cualquier descuento.
//Si viene en pareja → el segundo boleto tiene 50% descuento, pero solo si no es domingo.
//Promo activa:
//En domingos → agrega un 10% extra de rebaja acumulable (excepto funciones especiales).
//En otros días → aplica solo si el usuario tiene membresía Silver o superior (+5%).


if (eresEstudiante && (dia == "lunes" || dia == "miercoles"))
{
    double precioFinal = precioBase * 0.9;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}

if (conPareja && dia != "domingo")
{
    double precioFinal = precioBase * 0.5;
    Console.WriteLine($"El precio del segundo boleto es: {precioFinal}");
}

if (promoActiva && dia == "domingo" && tipoPelicula != "funcion_especial")
{
    double precioFinal = precioBase * 0.9;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}
else if (promoActiva && dia != "domingo" && (membresia == "silver" || membresia == "gold" || membresia == "platino"))
{
    double precioFinal = precioBase * 0.95;
    Console.WriteLine($"El precio de la boleta es: {precioFinal}");
}

