using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class SuatChieuAPI : ControllerBase
    {
        private CSuatChieu da = new CSuatChieu();
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = da.GetList("");
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
