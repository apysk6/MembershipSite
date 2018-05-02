using Memberships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var model = new ProductSectionModel
            {
                Title = "Title",
                Sections = new List<ProductSection>()
        };
            return View(model);
        }
    }
}