using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HW_1_30_03_21.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [MaxLength]
        [Required(ErrorMessage = "Field is required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public double ProductPrice { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Categories { get; set; }
    }
}
