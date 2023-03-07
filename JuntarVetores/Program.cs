// Primeiramente os vetores devem ser declarados
int[] A, B, C;

// Construindo e determinando espaço dos vetores
A = new int[5];
B = new int[5];
C = new int[A.Length + B.Length];
Console.WriteLine(C.Length);
// Populando vetores A e B
Console.WriteLine("Vetor A:");
A = PopularVetor(A);
Console.WriteLine();
Console.WriteLine("Vetor B:");
B = PopularVetor(B);

int[] PopularVetor(int[] vet)
{
    for (int i = 0; i < vet.Length; i++)
    {
        Console.WriteLine("Posição {0} do vetor:", i + 1);
        vet[i] = int.Parse(Console.ReadLine());
    }
    return vet;
}

// Juntando vetores:
C = JuntarVetores(A, B, C);

int[] JuntarVetores(int[] vetA, int[] vetB, int[] vetFinal)
{
    for (int i = 0; i < vetA.Length; i++)
    {
        vetFinal[i] = vetA[i];
    }

    for (int i = 0; i < vetB.Length; i++)
    {
        vetFinal[i + vetA.Length] = vetB[i];
    }

    return vetFinal;
}

Console.WriteLine();
// Imprimindo valores de cada vetor:
Console.WriteLine("Vetor A:");
ImprimirVetor(A);

Console.WriteLine("Vetor B:");
ImprimirVetor(B);

Console.WriteLine("Vetor C (A + B):");
ImprimirVetor(C);

void ImprimirVetor(int[] vet)
{
    foreach (int valor in vet) {
        Console.Write(valor + " ");
    }
    Console.WriteLine();
}