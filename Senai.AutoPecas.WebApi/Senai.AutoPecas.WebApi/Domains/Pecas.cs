﻿using System;
using System.Collections.Generic;

namespace Senai.AutoPecas.WebApi.Domains
{
    public partial class Pecas
    {
        public int IdPeca { get; set; }
        public string Descricao { get; set; }
        public int Peso { get; set; }
        public int PrecoCusto { get; set; }
        public int PrecoVenda { get; set; }
        public int? IdFornecedor { get; set; }

        public Fornecedores IdFornecedorNavigation { get; set; }
    }
}
