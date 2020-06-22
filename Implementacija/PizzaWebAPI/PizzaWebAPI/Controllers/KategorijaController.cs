using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KategorijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPoklone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKategorije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveKategorije());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiKategoriju/{kategorijaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKategorija(int kategorijaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKategoriju(kategorijaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiKategoriju/{kategorijaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteKategorija(int kategorijaID)
        {
            try
            {
                DataProvider.ObrisiKategoriju(kategorijaID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
    }
}
