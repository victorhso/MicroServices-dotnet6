using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 2,
                Nome = "Nome",
                Preco = new decimal(69.99),
                Descricao = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                ImagemURL = "https://img.freepik.com/fotos-gratis/imagem-aproximada-em-tons-de-cinza-de-uma-aguia-careca-americana-em-um-fundo-escuro_181624-31795.jpg?size=626&ext=jpg",
                Categoria = "Animal"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 3,
                Nome = "Capacete Darth Vader Star Wars Black Series",
                Preco = new decimal(999.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                Categoria = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 4,
                Nome = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                Preco = new decimal(189.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                Categoria = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 5,
                Nome = "Camiseta Gamer",
                Preco = new decimal(69.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                Categoria = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 6,
                Nome = "Camiseta SpaceX",
                Preco = new decimal(49.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                Categoria = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 7,
                Nome = "Camiseta Feminina Coffee Benefits",
                Preco = new decimal(69.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                Categoria = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 8,
                Nome = "Moletom Com Capuz Cobra Kai",
                Preco = new decimal(159.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                Categoria = "Sweatshirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 9,
                Nome = "Livro Star Talk – Neil DeGrasse Tyson",
                Preco = new decimal(49.9),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                Categoria = "Book"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 10,
                Nome = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Preco = new decimal(359.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                Categoria = "Action Figure"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 11,
                Nome = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                Categoria = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 12,
                Nome = "Camiseta GNU Linux Programador Masculina",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                Categoria = "T-shirt"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ID = 13,
                Nome = "Camiseta Goku Fases",
                Preco = new decimal(59.99),
                Descricao = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                ImagemURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                Categoria = "T-shirt"
            });
        }
    }
}
