using Empresa;
double montoTotal = 0;
int[] edades = new int[3];
Empleado[] nuevoEmpleado = new Empleado[3];
for (int i = 0; i < 3; i++)
{

    nuevoEmpleado[i] = new Empleado();

    Console.WriteLine("Ingrese el nombre del cliente numero: " + (i + 1));

    nuevoEmpleado[i].Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el apellido del empleado " + nuevoEmpleado[i].Nombre);

    nuevoEmpleado[i].Apellido = Console.ReadLine();

    string anioIngresado;

    Console.WriteLine("Ingrese la fecha de nacimiento de " + nuevoEmpleado[i].Nombre + " " + nuevoEmpleado[i].Apellido);

    anioIngresado = Console.ReadLine();

    while (!DateTime.TryParse(anioIngresado, out nuevoEmpleado[i].FechaNac))
    {
        Console.WriteLine("Volve a escribir la fecha pibe");

        anioIngresado = Console.ReadLine();
    }

    Console.WriteLine("Estado civil?");
    Console.WriteLine("S-soltero@");
    Console.WriteLine("C-casad@");
    Console.WriteLine("D-divorciad@");
    Console.WriteLine("V-viud@");
    Console.WriteLine("U-union convivencial");

    string estadoCivil = Console.ReadLine();

    while (!char.TryParse(estadoCivil, out nuevoEmpleado[i].EstadoCivil))
    {
        Console.WriteLine("Volve a escribir el caracter pibe");

        estadoCivil = Console.ReadLine();
    }

    Console.WriteLine("Fecha de ingreso de la empresa?");
    string fechaIngresoEmpleado = Console.ReadLine();

    while (!DateTime.TryParse(fechaIngresoEmpleado, out nuevoEmpleado[i].FechaIngreso))
    {
        Console.WriteLine("Volve a escribir la fecha pibe");
        fechaIngresoEmpleado = Console.ReadLine();
    }

    Console.WriteLine("Sueldo basico?");

    string sueldoBasicoEmpleado = Console.ReadLine();

    while (!double.TryParse(sueldoBasicoEmpleado, out nuevoEmpleado[i].sueldoBasico))
    {

        Console.WriteLine("Volve a escribir el sueldo pibe");
        sueldoBasicoEmpleado = Console.ReadLine();

    }

    Console.WriteLine("Que cargo ocupa en la empresa?");
    Console.WriteLine("Administrativo");
    Console.WriteLine("Ingeniero");
    Console.WriteLine("Especialista");
    Console.WriteLine("Investigador");

    string cargoEmpresa = Console.ReadLine();

    while (!Enum.TryParse<Cargos>(cargoEmpresa, true, out nuevoEmpleado[i].Cargo))
    {
        Console.WriteLine("Volve a escribir el cargo pibe");
        cargoEmpresa = Console.ReadLine();
    }



    int aniosAntiguedad = nuevoEmpleado[i].antiguedad();

    int edadEmpleado = nuevoEmpleado[i].edadEmpleado();

    nuevoEmpleado[i].jubilacion(edadEmpleado);

    double Salario_pagado = nuevoEmpleado[i].salario(aniosAntiguedad);

    Console.WriteLine("-----------------------------------------------------------------");


    montoTotal += Salario_pagado;

    edades[i] = edadEmpleado;

}

int mayorEdad = edades[0];
int indiceMayorEdad = 0;

for (int i = 0; i < 3; i++)
{
    if (edades[i] > mayorEdad)
    {
        mayorEdad = edades[i];
        indiceMayorEdad = i;
    }

}

Empleado viejo = nuevoEmpleado[indiceMayorEdad];

Console.WriteLine("--- Empleado más viejo ---");
Console.WriteLine("Nombre: " + viejo.Nombre);
Console.WriteLine("Apellido: " + viejo.Apellido);
Console.WriteLine("Fecha de Nacimiento: " + viejo.FechaNac);
Console.WriteLine("Estado Civil: " + viejo.EstadoCivil);
Console.WriteLine("Fecha de Ingreso: " + viejo.FechaIngreso);
Console.WriteLine("Cargo: " + viejo.Cargo);
Console.WriteLine("Sueldo Básico: " + viejo.sueldoBasico);
Console.WriteLine("Edad: " + mayorEdad);


Console.WriteLine("Monto total que se pagó: " + montoTotal);









