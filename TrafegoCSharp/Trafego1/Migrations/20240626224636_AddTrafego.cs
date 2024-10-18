using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trafego1.Migrations
{
    /// <inheritdoc />
    public partial class AddTrafego : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notificacoes",
                columns: table => new
                {
                    NotificacoesId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ServicoEmergencia = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ServicoPolicial = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ServicoSaude = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ServicoCliente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacoes", x => x.NotificacoesId);
                });

            migrationBuilder.CreateTable(
                name: "Semaforos",
                columns: table => new
                {
                    SemaforosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Localizacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FluxoTrafego = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semaforos", x => x.SemaforosId);
                });

            migrationBuilder.CreateTable(
                name: "Trafegos",
                columns: table => new
                {
                    TrafegoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Rotas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    OtimizacaoRotas = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AnaliseVias = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AnaliseCongestionamento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CondicoesClimaticas = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trafegos", x => x.TrafegoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificacoes");

            migrationBuilder.DropTable(
                name: "Semaforos");

            migrationBuilder.DropTable(
                name: "Trafegos");
        }
    }
}
