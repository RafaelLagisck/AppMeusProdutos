using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DevIO.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IProdutoService _fornecedorService;

        public FornecedoresController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(), new EnderecoRepository());
        }
        // GET: Fornecedor
        public async Task<ActionResult> Index()
        {
            var fornecedor = new Fornecedor()
            {
                Nome = "Rafael Lagisck",
                Documento = "32235978835",
                Endereco = new Endereco(),
                TipoFornecedor = TipoFornecedor.PessoaFisica,
                Ativo = true

            };

            await _fornecedorService.Adicionar(fornecedor);

            return new EmptyResult();
        }
    }
}