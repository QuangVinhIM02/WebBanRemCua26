using Microsoft.AspNetCore.Mvc;
using WebBanRemCua26.Data;
using WebBanRemCua26.Infrastructure;
using WebBanRemCua26.Models;

namespace WebBanRemCua26.Components
{
    public class CartWidget:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
