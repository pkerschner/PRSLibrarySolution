using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Models {

    public class Product {

        public int Id { get; set; } // primary key
        [Required, StringLength(30)] // Required does not allow null
        public string PartNbr { get; set; }
        [Required, StringLength(30)] // StringLength determines the length of the sting
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")] // this attribute determines the length of the decimal
        public decimal Price { get; set; }
        [Required, StringLength(30)]
        public string Unit { get; set; }
        [StringLength(225)]
        public string PhotoPath { get; set; }

        public int VendorId { get; set; } // foreign key
        // virtual instance required for Entity Framework to recognize foreign key
        // virtual means this property is in this class but not in the database
        public virtual Vendor Vendor { get; set; }
        // default constructor
        public Product() { }
    }
}
