using EspacioCalculadora;

Calculadora micalculo = new Calculadora();

micalculo.Sumar(20);
micalculo.Sumar(100);

Console.WriteLine($"El resultado es: {micalculo.getResultado()}");

micalculo.Dividir(2);
Console.WriteLine($"El resultado es: {micalculo.getResultado()}");