﻿using System;


namespace WpfApp.model
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(string nome, string descricao, int quantidade)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Quantidade = quantidade;   
        }
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
    }
}
