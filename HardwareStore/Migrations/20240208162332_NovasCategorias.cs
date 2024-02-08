using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Migrations
{
    /// <inheritdoc />
    public partial class NovasCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES('Computadores', 'Os melhores computadores estão aqui')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES('Celulares', 'Os melhores celulares estão aqui')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES('Coolers', 'Os melhores coolers para deixar seu computador refrigerado estão aqui')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
