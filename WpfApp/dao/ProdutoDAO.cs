using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfApp.model;

namespace WpfApp.dao
{
    public class ProdutoDAO
    {
        private readonly Categoria Categoria;
        public ProdutoDAO()
        {
            Categoria = new Categoria();
        }
        public List<Produto> Listar()
        {
            try
            {
                return Categoria.Produtos.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao carregar produtos!", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                throw;
            }
        }

        public Produto Inserir(Produto produto)
        {
            try
            {
                var novoProduto = Categoria.Produtos.Add(produto);
                Categoria.SaveChanges();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Erro", MessageBoxButton.OK, MessageBoxImage.Information);
                return novoProduto;
            }
            catch (Exception)
            {
                MessageBox.Show("Cadastro não efetuado.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                throw;
            }

        }
    }
}
