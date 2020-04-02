using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TTD.API.Data;
using TTD.API.Model;

namespace TTD.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroTTDController : ControllerBase
    {
        private readonly TtdContext _context;

        public RegistroTTDController(TtdContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMacro(){
            try
            {
                var results = await _context.Macroprocessos.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro: Conexão com o banco falhou!");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMacro(int id){
            try
            {
                var result = await _context.Macroprocessos.FirstAsync(x => x.Id == id);
                if (result.Id != 0)
                {
                    return Ok(result);
                }
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro: id não localizado!" );
                
            }
            catch (Exception)
            {
               return this.StatusCode(StatusCodes.Status500InternalServerError,"Erro: Não possível conectar ao banco!" );
            }
        }
    }
}