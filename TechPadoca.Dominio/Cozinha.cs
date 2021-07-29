﻿using TechPadoca.Dominio.Enum;
using TechPadoca.Dominio.Interface;

namespace TechPadoca.Dominio
{
    public class Cozinha : IEntity
    {
        public int Id { get; private set; }
        public Produto ProdutoFabricado { get; private set; }
        public int QuantidadeProduzida { get; set; }
        public ProducaoStatusEnum StatusDeProducao { get; set; }

        public void Cadastrar(int id, Produto produtoFabricado, int quantidadeProduzida)
        {
            Id = id;
            ProdutoFabricado = produtoFabricado;
            QuantidadeProduzida = quantidadeProduzida;
            StatusDeProducao = ProducaoStatusEnum.Recebido;
        }

        public void Alterar(int quantidadeProduzida)
        {
            QuantidadeProduzida = (quantidadeProduzida <= 0) ? QuantidadeProduzida : quantidadeProduzida;
        }

        public void AlterarStatus(ProducaoStatusEnum idStatus) 
        {
            StatusDeProducao = idStatus;
        }
    }
}
