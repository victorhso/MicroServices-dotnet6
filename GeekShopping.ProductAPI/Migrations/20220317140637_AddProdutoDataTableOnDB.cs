using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class AddProdutoDataTableOnDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_GS_PRODUTO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DS_NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    VL_PRECO = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DS_DESCRICAO = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DS_CATEGORIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DS_URL_IMAGEM = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GS_PRODUTO", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_GS_PRODUTO");
        }
    }
}
