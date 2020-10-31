﻿using System;
using System.Globalization;

namespace _1_Produto__Encapsulamento_
{
	class Produto
	{
		//declara as variáveis, duas com propriedades autoimplementadas
		private string _nome;
		public double Preco { get; private set; }
		public int Quantidade { get; private set; }

		//Construtor padrão
		public Produto() 
		{
		}

		//Construtor personalizado
		public Produto(string nome, double preco, int quantidade)
		{
			_nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}

		//Propriedade Nome customizada com condição
		public string Nome
		{
			get { return _nome; }

			set { if (value != null && value.Length > 1)
				{
					_nome = value;
				}
			}
		}

		//Métodos de classe
		public double ValorTotalEstoque()
		{
			double total = Quantidade * Preco;
			return total;
		}

		public void AdicionarProdutos(int qnt)
		{
			Quantidade += qnt;
		}

		public void RemoverProdutos(int qnt)
		{
			Quantidade -= qnt;
		}

		//Tostring: definir a formatação
		public override string ToString()
		{
			return "Nome: " + _nome + "\n"
				+ "Preço: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
				+ Quantidade + " unidades em estoque\n"
				+ "Valor total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
