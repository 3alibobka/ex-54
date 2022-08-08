int[,] m = new int[5, 5]
{
{3, 8, 6, 2, 4},
{6, 3, 2, 0, 5},
{1, 5, 7, 4, 9},
{8, 9, 2, 3, 1},
{2, 3, 9, 8, 0}

};
int[,] m2 = new int[5, 5]
{
{2, 4, 9, 1, 3},
{6, 3, 2, 0, 5},
{1, 5, 7, 4, 9},
{8, 9, 2, 3, 1},
{2, 3, 9, 8, 0}

};
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        m[i, j] *= m2[i, j];
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(m[i, j] + "\t");
    }
    Console.WriteLine();
}