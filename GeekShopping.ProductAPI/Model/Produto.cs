using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("TB_GS_PRODUTO")]
    public class Produto : BaseEntity
    {
        [Column("DS_NOME")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Column("VL_PRECO")]
        [Required]
        [Range(1,10000)]
        public decimal Preco { get; set; }

        [Column("DS_DESCRICAO")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column("DS_CATEGORIA")]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Column("DS_URL_IMAGEM")]
        [StringLength(300)]
        public string ImagemURL { get; set; }
    }
}
