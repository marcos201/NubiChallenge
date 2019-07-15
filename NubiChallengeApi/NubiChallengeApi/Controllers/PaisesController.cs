using Microsoft.AspNetCore.Mvc;
using NubiChallengeApi.Models;
using System.Collections.Generic;

namespace NubiChallengeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        // GET: api/Paises/AR o BR o CO
        [HttpGet("{pais}", Name = "Get")]
        public IActionResult Get([FromRoute] string pais)
        {
            if (pais == "AR" | pais == "ar")
            {
                var webClient = new System.Net.WebClient();
                var url = "https://api.mercadolibre.com/classified_locations/countries/AR";

                var res = webClient.DownloadString(url);

                var argentina = Newtonsoft.Json.JsonConvert.DeserializeObject<Pais>(res);

                return Ok(argentina);
            }
            if (pais == "BR" | pais == "CO" | pais == "br" | pais == "co" | pais == "Br" | pais == "Co")
            {
                return Unauthorized();
            }
            return NotFound();
        }
    }
}
