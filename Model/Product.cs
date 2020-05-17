using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiTest2.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Brand { get; set; }
    }
}