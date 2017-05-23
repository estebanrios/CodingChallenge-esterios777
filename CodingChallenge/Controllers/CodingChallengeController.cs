using AccesoDB._titulosServices;
using AccesoDB.Response;
using System.Web.Mvc;
using System.Collections.Generic;
using AccesoDB.ViewModel;

namespace CodingChallenge.Controllers
{
    public class CodingChallengeController : Controller
    {
        private readonly ItitulosServices _ItitulosServices;

        public CodingChallengeController()
        {
            _ItitulosServices = new titulosServices();
        }
        // GET: CodingChallenge
        public ActionResult Index()
        {
            var model = new TitulosResponse { TitulosViewModel = new List<TitulosViewModel>(), IsValid = true };
            return View(model);
        }

        public ActionResult GetList(string cadenaBuscar)
        {
            var result = _ItitulosServices.GetTitulos(cadenaBuscar);
            return PartialView("Partial/listado", result);

        }


    }
}
