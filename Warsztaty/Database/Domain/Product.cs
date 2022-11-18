using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }

        public int ShopId { get; set; }
        [ForeignKey(nameof(ShopId))]
        public virtual Shop Shop { get; set; }
    }
}
