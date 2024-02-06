using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.NewFolder
{
    public class Check
    {
        public int Winner;
        private void CheckForTie(int[,] data, int Y, int X, int counter, int Height, int Width) // remíza
        {
            counter = 0;
            while (true)
            {
                if (Y + 1 == Height) { continue; }
                else
                {
                    if (data[Y, X] == 0) { counter++; }
                    Y++;
                    if (data[Y, X] == 0) { counter++; }
                }
                if (X + 1 == Width) { continue; }
                else
                {
                    if (data[Y, X] == 0) { counter++; }
                    X++;
                    if (data[Y, X] == 0) { counter++; }
                }
                if (counter == 0)
                {
                    if (Y + 1 == Height && X + 1 == Width)
                    {
                        Winner = 3;
                        break;
                    }
                }
                else { break; }
            }
        }
        private void DetectUp(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X] && data[Y, X] == data[Y - 2, X])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectMidVert(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 1 && Y < Height - 1)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X] && data[Y, X] == data[Y + 1, X])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDown(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y < Height - 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y + 2, X] && data[Y, X] == data[Y + 1, X])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectLeft(int X, int Y, int[,] data, int Height, int Width)
        {
            if (X >= 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y, X - 1] && data[Y, X] == data[Y, X - 2])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectMidHor(int X, int Y, int[,] data, int Height, int Width)
        {
            if (X >= 1 && X < Width - 1)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y, X - 1] && data[Y, X] == data[Y, X + 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectRight(int X, int Y, int[,] data, int Height, int Width)
        {
            if (X < Width - 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y, X + 2] && data[Y, X] == data[Y, X + 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagUp(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 2 && X >= 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X - 1] && data[Y, X] == data[Y - 2, X - 2])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagMidVert(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 1 && Y < Height - 1 && X >= 1 && X < Width - 1)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X - 1] && data[Y, X] == data[Y + 1, X + 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagDown(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y < Height - 2 && X < Width - 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y + 2, X + 2] && data[Y, X] == data[Y + 1, X + 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagLeft(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 2 && X < Width - 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X + 1] && data[Y, X] == data[Y - 2, X + 2])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagMidHor(int X, int Y, int[,] data, int Height, int Width)
        {
            if (Y >= 1 && Y < Height - 1 && X >= 1 && X < Width - 1)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y - 1, X + 1] && data[Y, X] == data[Y + 1, X - 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        private void DetectDiagRight(int X, int Y, int[,] data, int Height, int Width)
        {
            if (X >= 2 && Y < Height - 2)
            {
                if (data[Y, X] == 0) { }
                else
                if (data[Y, X] == data[Y + 2, X - 2] && data[Y, X] == data[Y + 1, X - 1])
                {
                    Winner = data[Y, X];
                }
            }
        }
        public void DetectAll(int X, int Y, int[,] data, int Height, int Width)
        {
            CheckForTie(data, 0, 0, 0, Height, Width);

            DetectUp(X, Y, data, Height, Width);
            DetectMidVert(X, Y, data, Height, Width);
            DetectDown(X, Y, data, Height, Width);

            DetectLeft(X, Y, data, Height, Width);
            DetectMidHor(X, Y, data, Height, Width);
            DetectRight(X, Y, data, Height, Width);

            DetectDiagUp(X, Y, data, Height, Width);
            DetectDiagMidVert(X, Y, data, Height, Width);
            DetectDiagDown(X, Y, data, Height, Width);

            DetectDiagLeft(X, Y, data, Height, Width);
            DetectDiagMidHor(X, Y, data, Height, Width);
            DetectDiagRight(X, Y, data, Height, Width);
        }
    }
}
