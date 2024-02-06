using System;

static void Main(string[] args)
{
    Console.WriteLine("Números menores que 1000 donde la suma y el producto de los dígitos coinciden:");
    int[] numerosCoincidentes = new int[1000]; 
    int contador = 0; 
    for (int i = 0; i < 1000; i++)
    {
        if (SumaProductoCoinciden(i)) 
        {
            numerosCoincidentes[contador] = i; 
            contador++;
        }
    }
    for (int j = 0; j < contador; j++)
    {
        Console.WriteLine(numerosCoincidentes[j]);
    }
    Console.ReadLine();
}

static bool SumaProductoCoinciden(int num)
{
    int suma = 0;
    int producto = 1;
    while (num != 0)
    {
        int digito = num % 10;
        suma += digito;
        producto *= digito;
        num /= 10;
    }
    return suma == producto;
}