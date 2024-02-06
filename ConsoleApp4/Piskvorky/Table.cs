using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.NewFolder
{

    public class Table
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Counter { get; set; } = 1;
        public int Height { get; set; }
        public int Width { get; set; }
        public int Winner { get; set; }

        private int[,] data;
        Check check = new Check();

        public Table(int width, int height)
        {
            data = new int[height, width];
            Height = height;
            Width = width;
        }

        public void Draw()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                DrawRow(i, true);
                DrawRow(i, false);
            }

            DrawRow(0, true);
        }

        private void DrawRow(int i, bool line)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (line)
                {
                    Console.Write("|---");
                }
                else
                {
                    if (Y == i && X == j)
                    {
                        Console.Write("| ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(data[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        continue;
                    }
                    else { Console.ForegroundColor = ConsoleColor.Gray; }
                    Console.Write("| " + data[i, j] + " ");
                }
            }
            Console.WriteLine("|");
        }
        public void HandleKey(ConsoleKey key) // ovladac
        {

            if (key == ConsoleKey.UpArrow)
            {
                if (Y == 0) { }
                else
                {
                    Y--;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (Y < Height - 1) { Y++; }
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                if (X == 0) { }
                else
                {
                    X--;
                }
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (X < Width - 1) { X++; }
            }
            else if (key == ConsoleKey.Enter)
            {
                if (data[Y, X] == 0)
                {
                    if (Counter == 2)
                    {
                        data[Y, X] = Counter;
                        Counter--;
                    }
                    else
                    if (Counter == 1)
                    {
                        data[Y, X] = Counter;
                        Counter++;
                    }
                }
            }
            check.DetectAll(X, Y, data, Height, Width);
            Winner = check.Winner;
            Console.Clear();
        }
    }
}

