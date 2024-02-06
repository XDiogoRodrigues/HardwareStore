using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareStore.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoTabelasCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES ('Placas de videos', 'As melhores placa de videos')");
			migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES ('Processadores', 'Os melhores processadores')");
			migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES ('Placas mães', 'As melhores placa mães')");
			migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) VALUES ('Gabinetes', 'Os melhores Gabinetes')");

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
