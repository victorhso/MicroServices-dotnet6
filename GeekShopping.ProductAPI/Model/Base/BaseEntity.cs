using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
    }
}
