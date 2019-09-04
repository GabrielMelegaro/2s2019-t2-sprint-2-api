using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.AutoPecas.WebApi.Repositories
{
    public class FornecedorRepository : IFornecedoresRepository
    {
        public void Cadastrar(Fornecedores fornecedor)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                ctx.Fornecedores.Add(fornecedor);
                ctx.SaveChanges();
            }
        }

        public List<Fornecedores> Listar()
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Fornecedores.ToList();
            }
        }
    }
}
