﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificação_02
{
    abstract class Acessorio : Produto
    {
        public string Tamanho { get; set; }
        public string Cor { get; set; }
    }

    class Sapato : Acessorio
    {
        public string Material { get; set; }
    }


    class Bolsa : Acessorio
    {
        public int Compartimentos { get; set; }
    }

}
