using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebBanRemCua26.Data;
using WebBanRemCua26.Infrastructure;
using WebBanRemCua26.Models;

namespace WebBanRemCua26.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.GetJson<Cart>("cart"));
        }
        public IActionResult AddToCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", cart);
                return View("Cart", cart);  // Truyền giỏ hàng vào trang web
            }
            else
            {
                TempData["ErrorMessage"] = "Không tìm thấy sản phẩm.";
                return RedirectToAction("Index", "Products");
            }
        }

        public IActionResult UpdateCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                cart.AddItem(product, -1);

                // Kiểm tra nếu số lượng của mục đã giảm về 0, xóa mục đó khỏi giỏ hàng
                if (cart.Lines.Any(l => l.Product.ProductId == productId && l.Quantity <= 0))
                {
                    cart.RemoveLine(product);
                }

                HttpContext.Session.SetJson("cart", cart);
                return View("Cart", cart);  // Truyền giỏ hàng vào trang web
            }
            else
            {
                TempData["ErrorMessage"] = "Không tìm thấy sản phẩm.";
                return RedirectToAction("Index", "Products");
            }
        }


        public IActionResult RemoveFromCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", cart);
                return View("Cart", cart);  // Truyền giỏ hàng vào trang web
            }
            else
            {
                TempData["ErrorMessage"] = "Không tìm thấy sản phẩm.";
                return RedirectToAction("Index", "Products");
            }
        }

    }
}
