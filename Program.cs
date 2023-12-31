﻿using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        byte opcion;

        //Declaración de tubla
        (decimal num1, decimal num2, decimal resultado) numeros;

        do
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("Escoge una opción ");
            opcion = (byte)short.Parse(Console.ReadLine() ?? "");
        } while ((opcion < 1) || (opcion > 4));

        switch (opcion)
        {
            case 1:
                Sumar();
                break;
            case 2:
                numeros = Restar();
                Console.WriteLine("Resultado: {0} - {1} = {2}", numeros.num1,numeros.num2,numeros.resultado);
                break;
            case 3:
                Multiplicación();
                break;
            case 4:
                División();
                break;
        }
    }


    static void Sumar()
    {
        Console.WriteLine("Dame el primer número: ");
        decimal num1 = decimal.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Dame el segundo número: ");
        decimal num2 = decimal.Parse(Console.ReadLine() ?? "");
        int resultado = Decimal.ToInt32(num1) + Decimal.ToInt32(num2);
        Console.WriteLine("Resultado: {0}", resultado);
    }

    static (decimal,decimal,decimal) Restar()
    {
        Console.WriteLine("Dame el primer número: ");
        decimal num1 = decimal.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Dame el segundo número: ");
        decimal num2 = decimal.Parse(Console.ReadLine() ?? "");
        
        int resultado = Decimal.ToInt32(num1) - Decimal.ToInt32(num2);
        return (num1,num2,resultado);
    }

    static void Multiplicación()
    {
        Console.WriteLine("Dame el primer número: ");
        decimal num1 = decimal.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Dame el segundo número: ");
        decimal num2 = decimal.Parse(Console.ReadLine() ?? "");
        int resultado = Decimal.ToInt32(num1) * Decimal.ToInt32(num2);
        Console.WriteLine("Resultado: {0}", resultado);
    }

    static void División()
    {
        Console.WriteLine("Dame el primer número: ");
        decimal num1 = decimal.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Dame el segundo número: ");
        decimal num2 = decimal.Parse(Console.ReadLine() ?? "");

        if ((Decimal.ToInt32(num1) != 0) && (Decimal.ToInt32(num2) != 0))
        {
            int resultado = Decimal.ToInt32(num1) / Decimal.ToInt32(num2);
            Console.WriteLine("Resultado: {0}", resultado);
        }
        else
        {
            Console.WriteLine("No es posible dividir entre cero");
        }

    }
}