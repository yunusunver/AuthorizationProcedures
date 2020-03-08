using System;
using System.Linq.Expressions;
using authorizationProcedures.Models;
using authorizationProcedures.Services;
using Microsoft.AspNetCore.Mvc;

namespace authorizationProcedures.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private companyService _companyService;
        public CompanyController(companyService companyService)
        {
            _companyService=companyService;
        }
#region GETENDPOINT
        [Route("GetCompanies")]
        [HttpGet]
        public IActionResult GetCompanies([FromQuery] string keyword, [FromQuery] int offset,[FromQuery] int limit)
        {
            Expression<Func<Company, bool>> where = x => x.isDeleted == false;

            if (!string.IsNullOrEmpty(keyword))
            {
                var compiled = where.Compile();
                where = x =>
                    compiled(x) && x.name.ToLower().Equals(keyword.ToLower());
            }
            return Ok(_companyService.GetCompanies(where,offset,limit));
        }
#endregion
    }
}
