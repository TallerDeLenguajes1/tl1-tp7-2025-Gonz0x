using SisPersonal;
Empleado jose = new Empleado("Jose", "Figueredo", new DateTime(2000, 10, 12), 'C', new DateTime(2018, 10, 11), 900000.50, Cargos.Ingeniero);
Console.WriteLine("Datos del Empleado:");
Console.WriteLine(jose.MostrarEmpleado());

Empleado [] empleados = new Empleado[3];
empleados[0] = new Empleado("Jamar", "Pines", new DateTime(2001, 11, 3), 'C', new DateTime(2019, 9, 3), 160000, Cargos.Ingeniero);
empleados[1] = new Empleado("Franklin", "James", new DateTime(1980, 7, 8), 'S', new DateTime(2009, 3, 2), 150000, Cargos.Especialista);
empleados[2] = new Empleado("Jennifer", "Aniston", new DateTime(2003, 7, 8), 'C', new DateTime(2020, 7, 9), 130000, Cargos.Administrativo);

foreach (var emp in empleados)
{
    Console.WriteLine($"Empleado: {emp.Nombre}");
    Console.WriteLine($"Antigüedad: {emp.GetAntiguedad()} años");
    Console.WriteLine($"Salario total: {emp.salario()}");
    Console.WriteLine("--------------------------");
}

double montoTotal = 0;
foreach(var emp in empleados)
{
    montoTotal += emp.salario();
}
Console.WriteLine($"Monto total en salarios: {montoTotal:C}");

/* int menor = 100;
foreach(var emp in empleados){
    int añosParaJubilar = emp.paraJubilarse();
    if(añosParaJubilar < menor){
        menor = añosParaJubilar;
        proximo = emp;
    }
}
Console.WriteLine("Empleado más próximo a jubilarse:");
Console.WriteLine(menor.MostrarEmpleado());
Console.WriteLine($"Años para jubilarse: {menor}"); */
