using Microsoft.AspNetCore.Mvc;
using WebBanRemCua26.Data;

namespace WebBanRemCua26.Components
{
    public class Navbar:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Navbar(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }
    }
}
