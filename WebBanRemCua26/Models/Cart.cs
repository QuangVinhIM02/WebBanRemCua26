namespace WebBanRemCua26.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
                .Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.ProductId == product.ProductId);
        public decimal ComputeTotalValues()
        {
            return Lines.Where(e => e.Product != null && e.Product.ProductPrice != null)
                        .Sum(e => e.Product!.ProductPrice!.Value * e.Quantity);
        }

        public void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
    }
}
