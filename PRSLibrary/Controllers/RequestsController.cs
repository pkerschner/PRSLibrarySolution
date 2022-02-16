using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Controllers {

    public class RequestsController {

        private readonly PrsDbContext _context;

        public RequestsController(PrsDbContext context) {
            this._context = context;
        }        
        // method from PRS project specs file to get requests in review status
        public IEnumerable<Request> GetRequestsInReview(int userId) {
            var requests = _context.Requests
                                        .Where(x => x.Status == "REVIEW"
                                                && x.UserId != userId)
                                        .ToList(); // query syntax
            return requests;
        }
        // method to reject request
        public void SetRejected(Request request) {
            request.Status = "REJECTED";
            Change(request);
        }
        // method to approve request
        public void SetApproved(Request request) {
            request.Status = "APPROVED";
            Change(request);            
        }
        // method to review request
        public void SetReview(Request request) {
            if(request.Total <= 50) {
                request.Status = "APPROVED"; // status all caps
            } else {
                request.Status = "REVIEW"; // status all caps
            }
            Change(request);
        }

        public IEnumerable<Request> GetAll() {
            return _context.Requests.Include(x => x.User).ToList();
        }

        public Request GetByPk(int id) {
            return _context.Requests.Include(x => x.User)
                                .SingleOrDefault(x => x.Id == id);
        }

        public Request Create(Request Request) {
            if (Request is null) {
                throw new ArgumentNullException("Request");
            }
            if (Request.Id != 0) {
                throw new ArgumentException("Request.Id must be zero!");
            }
            _context.Requests.Add(Request);
            _context.SaveChanges();
            return Request;
        }

        public void Change(Request Request) {
            _context.SaveChanges();
        }

        public void Remove(int id) {
            var Request = _context.Requests.Find(id);
            if (Request is null) {
                throw new Exception("Request not found!");
            }
                _context.Requests.Remove(Request);
                _context.SaveChanges();            
        }
    }
}
