using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        
        private static List<string> produtos = new List<string>
        {
            "Notebook",
            "Smartphone",
            "Tablet"
        };

        
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetProdutos()
        {
            return produtos;
        }

        
        [HttpGet("{id}")]
        public ActionResult<string> GetProduto(int id)
        {
            if (id < 0 || id >= produtos.Count)
                return NotFound("Produto não encontrado.");

            return produtos[id];
        }

        
        [HttpPost]
        public ActionResult PostProduto([FromBody] string produto)
        {
            produtos.Add(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = produtos.Count - 1 }, produto);
        }

       
        [HttpDelete("{id}")]
        public ActionResult DeleteProduto(int id)
        {
            if (id < 0 || id >= produtos.Count)
                return NotFound("Produto não encontrado.");

            produtos.RemoveAt(id);
            return NoContent();
        }
    }
}
