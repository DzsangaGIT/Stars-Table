using System;

class Program
{
    static void Main()
    {
        // Táblázatok mérete
        int sorok = 50;
        int oszlopok = 40;

        // Táblázatok inicializálása
        char[,] tabla1 = new char[sorok, oszlopok];
        char[,] tabla2 = new char[sorok, oszlopok];

        // Táblázatok kitöltése szóközökkel
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                tabla1[i, j] = ' ';
                tabla2[i, j] = ' ';
            }
        }

        // Random csillagok elhelyezése a táblázatokban
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            int x1 = random.Next(0, oszlopok);
            int y1 = random.Next(0, sorok);
            int x2 = random.Next(0, oszlopok);
            int y2 = random.Next(0, sorok);

            tabla1[y1, x1] = '*';
            tabla2[y2, x2] = '*';
        }

        // Táblázatok keretének elkészítése
        Console.WriteLine("┌" + new string('─', oszlopok) + "┐" + "  " + "┌" + new string('─', oszlopok) + "┐");
        for (int i = 0; i < sorok; i++)
        {
            Console.Write("│");
            for (int j = 0; j < oszlopok; j++)
            {
                if (tabla1[i, j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(tabla1[i, j]);
                }
            }
            Console.Write("│" + "  " + "│");
            for (int j = 0; j < oszlopok; j++)
            {
                if (tabla2[i, j] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("*");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(tabla2[i, j]);
                }
            }
            Console.WriteLine("│");
        }
        Console.WriteLine("└" + new string('─', oszlopok) + "┘" + "  " + "└" + new string('─', oszlopok) + "┘");
    }
}