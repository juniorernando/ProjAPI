using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Coca-Cola', 'Refrigerante de cola', 5.45, 'coca.jpg', 50, '2022-03-31', 1)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pepsi', 'Refrigerante de cola', 5.45, 'pepsi.jpg', 50, '2022-03-31', 1)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Hamburguer', 'Pão, carne e queijo', 15.45, 'hamburguer.jpg', 50, '2022-03-31', 2)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Cheese Salada', 'Pão, carne, queijo e salada', 17.45, 'cheese.jpg', 50, '2022-03-31', 2)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Sorvete', 'Sorvete de chocolate', 7.45, 'sorvete.jpg', 50, '2022-03-31', 3)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pudim', 'Pudim de leite', 10.45, 'pudim.jpg', 50, '2022-03-31', 3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
