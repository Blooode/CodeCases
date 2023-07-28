using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleTest
{
    internal class Number
    {
        public Number(int row, int column, int value, ConsoleColor color)
        {
            Row = row;
            Column = column;
            Value = value;
            Color = color;
        }

        public int Row { get; set; }
        public int Column { get; set; }
        public int Value { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
