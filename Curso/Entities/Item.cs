using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    public  class Item
    {
        public Item(double valorProduto, double valorDesconto)
        {
            this.valorProduto = valorProduto;
            this.valorDesconto = valorDesconto;
        }

        public double valorProduto { get; set; }
        public double valorDesconto { get; set; }
        
    }
}
