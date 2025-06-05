using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KasaHesap.Migrations
{
    /// <inheritdoc />
    public partial class Kurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KasaHesap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortalEmanet = table.Column<float>(type: "real", nullable: false),
                    BankaEmanet = table.Column<float>(type: "real", nullable: false),
                    PortalHarc = table.Column<float>(type: "real", nullable: false),
                    BankaHarc = table.Column<float>(type: "real", nullable: false),
                    GelirVergisi = table.Column<float>(type: "real", nullable: false),
                    DamgaVergisi = table.Column<float>(type: "real", nullable: false),
                    EldeSayilanMiktar = table.Column<float>(type: "real", nullable: false),
                    ProvizyondaBekleyenTutar = table.Column<float>(type: "real", nullable: false),
                    SlipToplam = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasaHesap", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KasaHesap");
        }
    }
}
