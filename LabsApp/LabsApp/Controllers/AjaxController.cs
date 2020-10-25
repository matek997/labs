using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabsApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AjaxController : ControllerBase
    {
        public AjaxResult Post()
        {
            var res = new AjaxResult();
            res.success = true;

            return res;
        }

    }



}
