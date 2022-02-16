using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Controllers {

    public class RequestLinesController {

        private readonly PrsDbContext _context;

        public RequestLinesController(PrsDbContext context) {
            this._context = context;
        }
        // method from PRS project specs file to recalcualte request total
        private void RecalculateRequestTotal(int requestId) {
            var request = _context.Requests.Find(requestId);

            request.Total = (from rl in _context.RequestLines
                             join p in _context.Products
                             on rl.ProductId equals p.Id
                             where rl.RequestId == requestId
                             select new {
                                 LineTotal = rl.Quantity * p.Price
                             }).Sum(x => x.LineTotal); // query syntax
            _context.SaveChanges();
        }

        public IEnumerable<RequestLine> GetAll() {
            return _context.RequestLines
                                .Include(x => x.Product)
                                .Include(x => x.Request)
                                .ToList();
        }

        public RequestLine GetByPk(int id) {
            return _context.RequestLines
                                .Include(x => x.Product)
                                .Include(x => x.Request)
                                .SingleOrDefault(x => x.Id == id);
        }

        public RequestLine Create(RequestLine requestLine) {
            if (requestLine is null) {
                throw new ArgumentNullException("RequestLine");
            }
            if (requestLine.Id != 0) {
                throw new ArgumentException("RequestLine.Id must be zero!");
            }
            _context.RequestLines.Add(requestLine);
            _context.SaveChanges();
            RecalculateRequestTotal(requestLine.RequestId);
            return requestLine;
        }

        public void Change(RequestLine requestLine) {
            _context.SaveChanges();
            RecalculateRequestTotal(requestLine.RequestId);
        }

        public void Remove(int id) {
            var requestLine = _context.RequestLines.Find(id);
            if (requestLine is null) {
                throw new Exception("RequestLine not found!");
            }
                _context.RequestLines.Remove(requestLine);
                _context.SaveChanges();
                RecalculateRequestTotal(requestLine.RequestId);
        }
    }
}
