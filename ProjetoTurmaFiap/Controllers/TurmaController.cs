using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTurmaFiap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TurmaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("/ListarTodos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Entidade.AlunoEntidade))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(new Entidade.AlunoEntidade());

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("/ListarPorId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Entidade.AlunoEntidade))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ListarPorId(int id)
        {
            try
            {
                return Ok(new Entidade.AlunoEntidade());

            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("/CadastrarAluno")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public int CadastrarAluno(Entidade.AlunoEntidade aluno)
        {
            return 0;
        }

        [HttpDelete]
        [Route("/Deletar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public int Deletar(Entidade.AlunoEntidade aluno)
        {
            return 0;
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("/Atualizar")]
        public int Atualizar(Entidade.AlunoEntidade aluno)
        {
            return 0;
        }
    }
}
