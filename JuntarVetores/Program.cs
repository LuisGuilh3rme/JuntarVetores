﻿// Primeiramente os vetores devem ser declarados

int[] A, B, C;

// Populando vetores A e B
Console.WriteLine("Vetor A:");
A = PopularVetor(new int[5]);
Console.WriteLine();
Console.WriteLine("Vetor B:");
B = PopularVetor(new int[5]);

int[] PopularVetor(int[] vet)
{
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write("Posição [{0}] do vetor:", i + 1);
        if (!int.TryParse(Console.ReadLine(), out vet[i]))
        {
            AvisoErro("Valor inválido, substituido por zero\n");
        }
    }
    return vet;
}

// Juntando vetores:
C = JuntarVetores(A, B);

int[] JuntarVetores(int[] vetA, int[] vetB)
{
    int[] vetFinal = new int[vetA.Length + vetB.Length];

    for (int i = 0; i < vetA.Length; i++)
    {
        vetFinal[i] = vetA[i];
    }

    int tamA = vetA.Length;

    for (int i = 0; i < vetB.Length; i++)
    {
        vetFinal[i + tamA] = vetB[i];
    }

    return vetFinal;
}

Console.WriteLine();
// Imprimindo valores de cada vetor:
Console.Write("Vetor A: ");
ImprimirVetor(A);

Console.Write("Vetor B: ");
ImprimirVetor(B);

Console.Write("Vetor C (A + B): ");
ImprimirVetor(C);

void ImprimirVetor(int[] vet)
{
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write(vet[i] + " ");
    }
    Console.WriteLine();
}

// Aviso de erro:

void AvisoErro(string erro)
{
    ConsoleColor aux = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(erro);
    Console.ForegroundColor = aux;
}