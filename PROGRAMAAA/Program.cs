using System.Diagnostics;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Console.WriteLine("--------------------------------------------------------------------------------------");
Using System;
//Switch
string programs;
Console.WriteLine("¿QUE PROGRAMA DESEAS EJECUTAR?: ");
programs = Console.ReadLine();
switch(programs)
{
    case 1: Console.WriteLine("HAS ELEGIDO EL PROGRAMA NUMERO 01"); break;
    case 2: Console.WriteLine("HAS ELEGIDO EL PROGRAMA NUMERO 02"); break;
}
Console.ReadKey();
}
}
Console.WriteLine("--------------------------------------------------------------------------------------");

namespace encript
{
    0 referencias
        Static class ArrayExtensions
    {
        1 referencia
            public static int IndexOF<T>(CallConvThiscall T[] array,T value)
        {
            return Array.IndexOf(array, value);
        }
    }
}
0 referencias
    class program
{
    1 referencia
        public static int[] convertfrase(string frase)
char[] charFrase = frase.ToCharArray();
    int[] frase = new int[charFrase.Length];
    for(int i=0; i<CharFrase.Length; i++)
  {
        frases[i] = fraseTo(charFrase[i]);
}
return fraseStyles;
}

1 referencia
    public static int fraseTo(char letter)
{
    char[] alfabeto = {´ ´,´a´,´b´,´c´,´d´,´f´,´g´,´h´,í´,´j´,´k´,´m´,´n´,ó´,´p´,´q´,´r´,´s´,t´,ú´,´v´,´w´,´x´,ý´,´z´}
    int index = alfabeto.IndexOF(letter);
    return index;
}

Console.WriteLine("--------------------------------------------------------------------------------------");

static woid Main(String[] args)
{
    int[,] clave = { { 1, 2, 1 }, { 0, -1, 3 }, { 2, 1, 0 } };
    Console.WriteLine("INGRESE SU FRASE DESEADA...");
    string frase = Console.ReadLine();

    int[]frase = convertNumber(frase);
    for(int i=0;  i<frase.Length;  i++)
    {
        Console.Write(frase[i] + " ");
    }
Console.WriteLine("--------------------------------------------------------------------------------------");
}

public static int[] convertNumber(string frase)
char[] charFrase = frase.ToCharArray();
int[] numbers = new int[charFrase.Length];
for (int i = 0; i < CharFrase.Length; i++)
{
    numbers[i] = numberTo(charFrase[i]);
}
return NumberStyles;
}

Console.WriteLine("--------------------------------------------------------------------------------------");


1 referencia
    public static int numberTo(char letter)
{
    char[] alfabeto = {´ ´,´1´,´2´,´3´,´4´,´5´,´6´,´7´, 8´,´9´,´10´,´11´,´12´, 13´,´14´,´15´,´16´,´17´, 18´, 19´,´20´,´21´,´22´, 23´,´&´}
    int index = alfabeto.IndexOF(letter);
    return index;
}

Console.WriteLine("--------------------------------------------------------------------------------------");

static woid Main(String[] args)
{
    int[,] clave = { { 1, 2, 1 }, { 0, -1, 3 }, { 2, 1, 0 } };
    Console.WriteLine("INGRESE SU FRASE DESEADA...");
    string frase = Console.ReadLine();

    int[] numeros = convertNumber(frase);
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write(numeros[i] + " ");
    }
    Console.WriteLine("--------------------------------------------------------------------------------------");
}