using AutoMapper;
using FichaCadastroAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FichaCadastroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichaCadastroController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly FichaCadastroContextDB _db;

        public FichaCadastroController(IMapper mapper, FichaCadastroContextDB db)
        {
            _mapper = mapper;
            _db = db;
        }
        
        [HttpPost]
        public ActionResult Post() {
            return Ok();
        }
    }
}
