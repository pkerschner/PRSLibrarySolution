using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Controllers {

    public class ProductsController {

        private readonly PrsDbContext _context;

        public ProductsController(PrsDbContext context) {
            this._context = context;
        }

        public IEnumerable<Product> GetAll() {
            return _context.Products.Include(x => x.Vendor).ToList(); // reference Vendor instance to include vendor name
        }

        public Product GetByPk(int id) {
            return _context.Products.Include(x => x.Vendor)
                                .SingleOrDefault(x => x.Id == id); // reference Vendor instance to include vendor name
        }

        public Product Create(Product product) {
            if (product is null) {
                throw new ArgumentNullException("product");
            }
            if (product.Id != 0) {
                throw new ArgumentException("Product.Id must be zero!");
            }
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Change(Product product) {
            _context.SaveChanges();
        }

        public void Remove(int id) {
            var product = _context.Products.Find(id);
            if (product is null) {
                throw new Exception("Product not found!");
            }
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        
    }
}
