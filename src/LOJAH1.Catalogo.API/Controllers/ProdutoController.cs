using LOJAH1.Catalogo.Application.Interfaces;
using LOJAH1.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LOJAH1.Catalogo.API.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class ProdutoController : ControllerBase
	{
		private readonly IProdutoService _produtoService;

		public ProdutoController(IProdutoService produtoService)
		{
			_produtoService = produtoService;
		}

		[HttpPost]
		public IActionResult Post(NovoProdutoViewModel novoProdutoViewModel)
		{
			_produtoService.Adicionar(novoProdutoViewModel);
			return Ok("Registro adicionado com sucesso!");
		}
	}
}
