using LOJAH1.Catalogo.Application.Interfaces;
using LOJAH1.Catalogo.Application.ViewModels;
using LOJAH1.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJAH1.Catalogo.Application.Services
{
	public class ProdutoService : IProdutoService
	{
		private readonly IProdutoRepository _produtoRepository;

		public ProdutoService(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public void Adicionar(NovoProdutoViewModel novoProdutoViewModel)
		{
			_produtoRepository.Adicionar(new Domain.Entities.Produto(
				 novoProdutoViewModel.Codigo,
				 novoProdutoViewModel.Nome,
				 novoProdutoViewModel.QtdeEstoque,
				 novoProdutoViewModel.DataCadastro,
				 novoProdutoViewModel.Ativo
				));
		}
	}
}
