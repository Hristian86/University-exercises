﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrint
{
    public class Cell
    {
            public Cell(int row, int col, int step)
            {
                this.Row = row;
                this.Col = col;
                this.Step = step;
            }

            public int Row { get; set; }
            public int Col { get; set; }
            public int Step { get; set; }
        
    }
}
