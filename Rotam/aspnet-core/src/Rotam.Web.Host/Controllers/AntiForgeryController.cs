using Microsoft.AspNetCore.Antiforgery;
using Rotam.Controllers;

namespace Rotam.Web.Host.Controllers
{
    public class AntiForgeryController : RotamControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
