using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalityTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CCChargeController : ControllerBase
    {
        private readonly ICCChargeService _cCChargeService; //Code for point 2

        public CCChargeController(ICCChargeService cCChargeService)
        {
            _cCChargeService = cCChargeService;
        }

        [HttpGet]
        public List<CCChargeViewModel> Get(int id)
        {
            return _cCChargeService.GetCharges(id);  //Code for point 2
        }

        [HttpPost]
        public int CreateCCCharge(CCChargeViewModel model)
        {
            return _cCChargeService.CreateCCCharge(model.CustomerId, model.Amount); //Code for point 2
        }        
    }
}
