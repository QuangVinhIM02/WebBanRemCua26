using Microsoft.AspNetCore.Mvc;
using WebBanRemCua26.Data;

namespace WebBanRemCua26.Components
{
    public class Imagebar:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Imagebar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View("Index",_context.Categories.ToList());
        }
    }
}
