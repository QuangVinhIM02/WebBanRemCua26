using Microsoft.AspNetCore.Mvc;
using WebBanRemCua26.Data;

namespace WebBanRemCua26.Components
{
    public class JustArrived:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public JustArrived(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p => p.IsArrived == 1).ToList());
        }
    }
}
