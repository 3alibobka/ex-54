int[,] m = new int[5, 5]
{
{3, 8, 6, 2, 4},
{6, 3, 2, 0, 5},
{1, 5, 7, 4, 9},
{8, 9, 2, 3, 1},
{2, 3, 9, 8, 0}

};
for (int k = 0; k < 5; k++)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (m[i, j] > m[i, j + 1])
            {
                int temp = m[i, j];
                m[i, j] = m[i, j + 1];
                m[i, j + 1] = temp;
            }

        }
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