using Microsoft.AspNetCore.Mvc;

namespace NSE.Clientes.API.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
