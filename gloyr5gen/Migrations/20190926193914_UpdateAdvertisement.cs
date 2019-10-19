using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gloyr5gen.Migrations
{
    public partial class UpdateAdvertisement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ilanName = table.Column<string>(nullable: true),
                    aciklama = table.Column<string>(nullable: true),
                    tecrube = table.Column<string>(nullable: true),
                    egitimdurumu = table.Column<string>(nullable: true),
                    firmasektoru = table.Column<string>(nullable: true),
                    calismasekli = table.Column<string>(nullable: true),
                    pozisyonseviyesi = table.Column<string>(nullable: true),
                    ulke = table.Column<string>(nullable: true),
                    sehir = table.Column<string>(nullable: true),
                    acikadres = table.Column<string>(nullable: true),
                    baslangicmaas = table.Column<double>(nullable: false),
                    bitismaas = table.Column<double>(nullable: false),
                    paylasimtarihi = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    HtmlContent = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsHome = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.AdvertisementId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Categoryaciklama = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsHome = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ulkes",
                columns: table => new
                {
                    ulkeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ulkename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ulkes", x => x.ulkeId);
                });

            migrationBuilder.CreateTable(
                name: "CalismaSeklis",
                columns: table => new
                {
                    CalismaSekliId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    calismaseklibilgi = table.Column<string>(nullable: true),
                    AdvertisementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSeklis", x => x.CalismaSekliId);
                    table.ForeignKey(
                        name: "FK_CalismaSeklis_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "AdvertisementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SehirName = table.Column<string>(nullable: true),
                    AdvertisementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirId);
                    table.ForeignKey(
                        name: "FK_Sehirs_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "AdvertisementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    AdvertisementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementCategory", x => new { x.AdvertisementId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_AdvertisementCategory_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "AdvertisementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ulkecategory",
                columns: table => new
                {
                    ulkecategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SehirId = table.Column<int>(nullable: false),
                    ulkeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ulkecategory", x => x.ulkecategoryId);
                    table.ForeignKey(
                        name: "FK_ulkecategory_Sehirs_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirs",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ulkecategory_ulkes_ulkeId",
                        column: x => x.ulkeId,
                        principalTable: "ulkes",
                        principalColumn: "ulkeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementCategory_CategoryId",
                table: "AdvertisementCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSeklis_AdvertisementId",
                table: "CalismaSeklis",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirs_AdvertisementId",
                table: "Sehirs",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_ulkecategory_SehirId",
                table: "ulkecategory",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_ulkecategory_ulkeId",
                table: "ulkecategory",
                column: "ulkeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementCategory");

            migrationBuilder.DropTable(
                name: "CalismaSeklis");

            migrationBuilder.DropTable(
                name: "ulkecategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "ulkes");

            migrationBuilder.DropTable(
                name: "Advertisements");
        }
    }
}
