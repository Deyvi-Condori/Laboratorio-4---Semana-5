Console.Write("Ingrese el numero limite: ");
int limite = int.Parse(Console.ReadLine());
Console.WriteLine("============================");
Console.WriteLine("Escoja una opción:");
Console.WriteLine("1: Numeros pares");
Console.WriteLine("2: Numeros impares");
Console.WriteLine("3: Factorial");
Console.WriteLine("============================");
Console.Write("--> ");
int Opcion = int.Parse(Console.ReadLine());
switch (Opcion)
{
    case 1:
        for (int i = 1; i <= limite; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }
        }
        break;
    case 2:
        for (int i = 1; i <= limite; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + ",");
            }
        }
        break;
    case 3:
        int Resultado = 1;
        for (int i = 1; i <= limite; i++)
        {
            Resultado *= i;
        }
        Console.Write("El factorial es " + Resultado);
        Console.ReadKey();
        break;
}