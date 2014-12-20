using System.Web.Mvc;
using MyItems.Models;
using MyItems.ReadAndWrite;

namespace MyItems.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReadAndWriteAcions _rawActions = new ReadAndWriteAcions();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Items = _rawActions.Read();

            return View();
        }

        [HttpPost]
        public ActionResult Index(ItemModel itemModel)
        {
            ViewBag.Items = _rawActions.Read();

            var newItem = new ItemModel
            {
                Item = itemModel.Item
            };

            _rawActions.Write(newItem);

            return View();
        }
	}
}