using Microsoft.AspNetCore.Mvc;
using WebBanRemCua26.Data;

namespace WebBanRemCua26.Components
{
    public class Trandy:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public Trandy(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p=>p.IsTrandy==1).ToList());
        }
    }
}
