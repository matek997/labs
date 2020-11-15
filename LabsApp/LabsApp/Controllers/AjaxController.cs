using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabsApp.Models;
using LabsApp.Web.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabsApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AjaxController : ControllerBase
    {
        private readonly LabsAppDbContext _dbContext;
        public AjaxController(LabsAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public AjaxResult Post(CompanyModel company)
        {
            var res = new AjaxResult();
            res.success = true;

            var entity = new ItemEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return res;
        }

    }



}
