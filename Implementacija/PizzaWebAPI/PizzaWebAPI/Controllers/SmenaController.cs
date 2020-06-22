using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaDatabaseAccess;
using PizzaDatabaseAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmenaController : ControllerBase
    {
        #region Smena
        [HttpGet]
        [Route("PreuzmiSmene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSmene()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSmene());
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSmenu/{smenaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSmena(int smenaID)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSmenu(smenaID));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSmenu/{smenaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSmena(int smenaID)
        {
            try
            {
                DataProvider.ObrisiSmenu(smenaID);
                return Ok();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.ToString());
            }
        }
        #endregion

        #region Smena1
        [HttpPost]
        [Route("DodajSmenu1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSmena1([FromBody] Smena1View s1)
        {
            try
            {
                DataProvider.DodajSmenu1(s1);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Smena1
        [HttpPost]
        [Route("DodajSmenu2")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSmena2([FromBody] Smena2View s2)
        {
            try
            {
                DataProvider.DodajSmenu2(s2);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Smena3
        [HttpPost]
        [Route("DodajSmenu3")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSmena3([FromBody] Smena3View s3)
        {
            try
            {
                DataProvider.DodajSmenu3(s3);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
