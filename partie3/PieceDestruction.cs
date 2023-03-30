﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceNamespace
{
    internal class PieceDestruction : Piece
    {
        public string Type { get; set; }

        public PieceDestruction() : base() 
        {
            Type = "destruction";
        }

        public override string ToString()
        {
            return $"type : {Type}";
        }
    }
}
