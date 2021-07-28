﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPadoca.Dominio
{
<<<<<<< HEAD
    public class Loja : ISolicitacaoEstoque//, ISolicitacaoCozinha
=======
    public class Loja
>>>>>>> 52a6a3a537a858edf65994a511754c9ebcca7148
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinima { get; set; }


        public void Cadastrar(int id, int quantidade, int quantidadeMinima)
        {
            Id = id;
            Quantidade = quantidade;
            QuantidadeMinima = quantidadeMinima;
        }

        public void Alterar(int quantidade, int quantidadeMinima)
        {
            Quantidade = (quantidade < 0) || (quantidade < quantidadeMinima) ? Quantidade : quantidade;
            QuantidadeMinima = (quantidadeMinima < 0) ? QuantidadeMinima : quantidadeMinima;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        void PedirProdutoEstoque(int quantidade)
        {
            if (this.Produto.Categoria == "Pronto")
            {
                if (this.Quantidade <= QuantidadeMinima)
                {
                    Console.WriteLine("Necessario fazer pedido a Cozinha");
                }
            }
        }

        void PedirProdutoCozinha(int quantidade)
        {
            if (this.Produto.Categoria == "Produzido")
            {
                if (this.Quantidade <= QuantidadeMinima)
                {
                    Console.WriteLine("Necessario fazer pedido a Cozinha");
                }
            }
        }

    }
}