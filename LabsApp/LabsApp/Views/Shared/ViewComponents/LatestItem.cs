using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabsApp.ViewComponents
{
    public class LatestItem : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly LabsApp.Web.Database.LabsAppDbContext db;
        public LatestItem(LabsApp.Web.Database.LabsAppDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var latestItem = db.Items
            .OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }

    }
}
