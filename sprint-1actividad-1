Console.WriteLine("Cine");
Console.WriteLine("Precio base: $10,000");
Console.WriteLine();

int edad = 0;
string tipo_pelicula = "";
string dia = "";
string hora = "";
string membresia = "";
bool estudiante = false;
bool pareja = false;
bool promo_activa = false;

Console.Write("Edad: ");
string input_edad = Console.ReadLine();
if (int.TryParse(input_edad, out edad))
{
    if (edad < 0 || edad > 100)
    {
        Console.WriteLine("Edad debe estar entre 0 y 100");
        Console.Write("Edad: ");
        input_edad = Console.ReadLine();
        while (!int.TryParse(input_edad, out edad) || edad < 0 || edad > 100)
        {
            Console.WriteLine("Edad debe estar entre 0 y 100");
            Console.Write("Edad: ");
            input_edad = Console.ReadLine();
        }
    }
}
else
{
    Console.WriteLine("Edad debe ser un número");
    Console.Write("Edad: ");
    input_edad = Console.ReadLine();
    while (!int.TryParse(input_edad, out edad) || edad < 0 || edad > 100)
    {
        Console.WriteLine("Edad debe ser un número entre 0 y 100");
        Console.Write("Edad: ");
        input_edad = Console.ReadLine();
    }
}

Console.Write("Tipo de película (estreno/clasico/3D/maraton/funcion_especial): ");
tipo_pelicula = Console.ReadLine();
while (tipo_pelicula != "estreno" && tipo_pelicula != "clasico" && tipo_pelicula != "3D" && tipo_pelicula != "maraton" && tipo_pelicula != "funcion_especial")
{
    Console.WriteLine("Opciones: estreno, clasico, 3D, maraton, funcion_especial");
    Console.Write("Tipo de película: ");
    tipo_pelicula = Console.ReadLine();
}

Console.Write("Día (lunes/martes/miercoles/jueves/viernes/sabado/domingo): ");
dia = Console.ReadLine();
while (dia != "lunes" && dia != "martes" && dia != "miercoles" && dia != "jueves" && dia != "viernes" && dia != "sabado" && dia != "domingo")
{
    Console.WriteLine("Opciones: lunes, martes, miercoles, jueves, viernes, sabado, domingo");
    Console.Write("Día: ");
    dia = Console.ReadLine();
}

Console.Write("Hora (mañana/tarde/noche): ");
hora = Console.ReadLine();
while (hora != "mañana" && hora != "tarde" && hora != "noche")
{
    Console.WriteLine("Opciones: mañana, tarde, noche");
    Console.Write("Hora: ");
    hora = Console.ReadLine();
}

Console.Write("Membresía (ninguna/silver/gold/platino): ");
membresia = Console.ReadLine();
while (membresia != "ninguna" && membresia != "silver" && membresia != "gold" && membresia != "platino")
{
    Console.WriteLine("Opciones: ninguna, silver, gold, platino");
    Console.Write("Membresía: ");
    membresia = Console.ReadLine();
}

Console.Write("¿Es estudiante? (si/no): ");
string input_estudiante = Console.ReadLine();
while (input_estudiante != "si" && input_estudiante != "no")
{
    Console.WriteLine("Opciones: si, no");
    Console.Write("¿Es estudiante? (si/no): ");
    input_estudiante = Console.ReadLine();
}
if (input_estudiante == "si")
{
    estudiante = true;
}

Console.Write("¿Viene en pareja? (si/no): ");
string input_pareja = Console.ReadLine();
while (input_pareja != "si" && input_pareja != "no")
{
    Console.WriteLine("Opciones: si, no");
    Console.Write("¿Viene en pareja? (si/no): ");
    input_pareja = Console.ReadLine();
}
if (input_pareja == "si")
{
    pareja = true;
}

Console.Write("¿Promo activa? (si/no): ");
string input_promo = Console.ReadLine();
while (input_promo != "si" && input_promo != "no")
{
    Console.WriteLine("Opciones: si, no");
    Console.Write("¿Promo activa? (si/no): ");
    input_promo = Console.ReadLine();
}
if (input_promo == "si")
{
    promo_activa = true;
}

double precio_base = 10000;
double precio_final = precio_base;
List<string> descuentos_aplicados = new List<string>();

if (edad < 12)
{
    if (tipo_pelicula == "clasico")
    {
        if (dia == "lunes" || dia == "miercoles")
        {
            precio_final = 0;
            descuentos_aplicados.Add("Niño gratis en clásico");
        }
        else
        {
            precio_final = precio_base;
        }
    }
    else if (tipo_pelicula == "3D")
    {
        if (hora != "noche")
        {
            precio_final = precio_base * 0.3;
            descuentos_aplicados.Add("Niño 70% descuento en 3D");
        }
        else
        {
            precio_final = precio_base;
        }
    }
    else if (tipo_pelicula == "funcion_especial")
    {
        precio_final = 0;
        descuentos_aplicados.Add("Niños no pueden entrar a función especial");
    }
    else
    {
        precio_final = precio_base;
    }
}
else
{
    if (edad >= 12 && edad <= 17)
    {
        if (tipo_pelicula == "clasico")
        {
            if (dia == "miercoles")
            {
                precio_final = precio_base * 0.5;
                descuentos_aplicados.Add("Adolescente 50% en clásico miércoles");
            }
            else
            {
                precio_final = precio_base;
            }
        }
        else if (tipo_pelicula == "3D")
        {
            if (membresia == "silver")
            {
                if (dia != "domingo")
                {
                    precio_final = precio_base * 0.8;
                    descuentos_aplicados.Add("Adolescente Silver 20% en 3D");
                }
                else
                {
                    precio_final = precio_base;
                }
            }
            else
            {
                precio_final = precio_base;
            }
        }
        else
        {
            precio_final = precio_base;
        }
    }
    else
    {
        if (edad >= 18 && edad <= 59)
        {
            if (membresia == "gold")
            {
                if (tipo_pelicula == "clasico")
                {
                    if (dia != "viernes" && dia != "sabado")
                    {
                        if (hora != "noche")
                        {
                            precio_final = precio_base * 0.75;
                            descuentos_aplicados.Add("Gold 25% en clásico");
                        }
                        else
                        {
                            precio_final = precio_base;
                        }
                    }
                    else
                    {
                        precio_final = precio_base;
                    }
                }
                else if (tipo_pelicula == "3D")
                {
                    if (dia != "domingo")
                    {
                        precio_final = precio_base * 0.85;
                        descuentos_aplicados.Add("Gold 15% en 3D");
                    }
                    else
                    {
                        precio_final = precio_base;
                    }
                }
                else
                {
                    precio_final = precio_base;
                }
            }
            else
            {
                if (membresia == "platino")
                {
                    if (tipo_pelicula == "estreno")
                    {
                        if (dia == "sabado")
                        {
                            if (hora == "noche")
                            {
                                precio_final = precio_base;
                            }
                            else
                            {
                                precio_final = precio_base * 0.65;
                                descuentos_aplicados.Add("Platino 35% descuento");
                            }
                        }
                        else
                        {
                            precio_final = precio_base * 0.65;
                            descuentos_aplicados.Add("Platino 35% descuento");
                        }
                    }
                    else
                    {
                        precio_final = precio_base * 0.65;
                        descuentos_aplicados.Add("Platino 35% descuento");
                    }
                }
                else
                {
                    precio_final = precio_base;
                }
            }
        }
        else
        {
            if (edad >= 60)
            {
                if (tipo_pelicula == "maraton")
                {
                    precio_final = precio_base * 0.5;
                    descuentos_aplicados.Add("Senior 50% en maratón");
                }
                else
                {
                    if (dia == "domingo")
                    {
                        if (promo_activa)
                        {
                            precio_final = precio_base * 0.3;
                            descuentos_aplicados.Add("Senior 70% domingo con promo");
                        }
                        else
                        {
                            precio_final = precio_base * 0.6;
                            descuentos_aplicados.Add("Senior 40% descuento");
                        }
                    }
                    else
                    {
                        precio_final = precio_base * 0.6;
                        descuentos_aplicados.Add("Senior 40% descuento");
                    }
                }
            }
            else
            {
                precio_final = precio_base;
            }
        }
    }
}

if (dia == "miercoles")
{
    if (tipo_pelicula != "funcion_especial")
    {
        precio_final = precio_final * 0.8;
        descuentos_aplicados.Add("Miércoles 20% descuento");
    }
}

if (tipo_pelicula == "maraton")
{
    if (edad < 60)
    {
        precio_final = precio_base * 0.8;
        descuentos_aplicados.Add("Maratón 20% descuento");
    }
}

if (tipo_pelicula == "3D")
{
    precio_final = precio_final * 1.1;
    descuentos_aplicados.Add("3D +10% recargo");
}

if (tipo_pelicula == "estreno")
{
    if (estudiante)
    {
        precio_final = precio_final * 0.85;
        descuentos_aplicados.Add("Estudiante 15% en estreno");
    }
}

if (estudiante)
{
    if (dia == "lunes" || dia == "miercoles")
    {
        precio_final = precio_final * 0.9;
        descuentos_aplicados.Add("Estudiante 10% extra lunes/miércoles");
    }
}

if (pareja)
{
    if (dia != "domingo")
    {
        double segundo_boleto = precio_final * 0.5;
        precio_final = precio_final + segundo_boleto;
        descuentos_aplicados.Add("Pareja 50% segundo boleto");
    }
}

if (promo_activa)
{
    if (dia == "domingo")
    {
        if (tipo_pelicula != "funcion_especial")
        {
            precio_final = precio_final * 0.9;
            descuentos_aplicados.Add("Promo domingo 10%");
        }
    }
    else
    {
        if (membresia == "silver" || membresia == "gold" || membresia == "platino")
        {
            precio_final = precio_final * 0.95;
            descuentos_aplicados.Add("Promo membresía 5%");
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Precio base: ${precio_base:F0}");
if (descuentos_aplicados.Count > 0)
{
    Console.WriteLine($"Descuentos: {string.Join(" + ", descuentos_aplicados)}");
}
else
{
    Console.WriteLine("Descuentos: Ninguno");
}
Console.WriteLine($"Precio final: ${precio_final:F0}");
