int[,] mat = new int[5, 5];

// Populando matriz:
Console.WriteLine("Inserindo valores na matriz, se valor for inválido, será substituido por zero");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write("Posição {0}:{1}: ", i + 1, j + 1);
        int.TryParse(Console.ReadLine(), out mat[i, j]);
    }
}

// Resultado da soma de cada linha:
int[] linhas = new int[mat.GetLength(0)];

for (int i = 0; i < linhas.Length; i++)
{
    linhas[i] = SomaLinha(i, mat);
}
int SomaLinha (int linha, int[,] mat)
{
    int somatoria = 0;
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        somatoria += mat[linha, j];
    }
    return somatoria;
}

// Resultado da soma de cada coluna:
int[] colunas = new int[mat.GetLength(1)];

for (int j = 0; j < colunas.Length; j++)
{
    colunas[j] = SomaColuna(j, mat);
}
int SomaColuna(int coluna, int[,] mat)
{
    int somatoria = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        somatoria += mat[i, coluna];
    }
    return somatoria;
}

// Soma da diagonal principal:
int somaDiagonalPrincipal = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    somaDiagonalPrincipal += mat[i, i];
}

// Soma da diagonal secundária:
int somaDiagonalSecundaria = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    somaDiagonalSecundaria += mat[i, ((mat.GetLength(1) - 1) - i)];
}

// Exibindo resultados:
Console.Clear();
Console.WriteLine("Valores da matriz:");
ImprimirMatriz(mat);

Console.WriteLine("\nSoma de cada linha:");
for (int i = 0; i < linhas.Length; i++)
{
    Console.WriteLine("Linha {0}: {1}", i + 1, linhas[i]);
}

Console.WriteLine("\nSoma de cada coluna:");
for (int j = 0; j < colunas.Length; j++)
{
    Console.WriteLine("Coluna {0}: {1}", j + 1, colunas[j]);
}

Console.WriteLine("\nDiagonal principal: {0}", somaDiagonalPrincipal);
Console.WriteLine("\nDiagonal secundária: {0}", somaDiagonalSecundaria);

void ImprimirMatriz(int[,] mat) {
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("\t {0} \t", mat[i, j]);
        }
        Console.WriteLine();
    }
}