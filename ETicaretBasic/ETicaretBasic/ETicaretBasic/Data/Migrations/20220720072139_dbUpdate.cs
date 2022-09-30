using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaretBasic.Data.Migrations
{
    public partial class dbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Game_GameId",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Game_GameId",
                table: "BasketItem");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "BasketItem",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_GameId",
                table: "BasketItem",
                newName: "IX_BasketItem_SongId");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Basket",
                newName: "SongId");

            migrationBuilder.RenameColumn(
                name: "ActiveOrNot",
                table: "Basket",
                newName: "Active");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_GameId",
                table: "Basket",
                newName: "IX_Basket_SongId");

            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "AspNetUsers",
                newName: "DateOfBirth");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Basket",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Basket",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    MinimumValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ArtistId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    FirstPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Song_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_ArtistId",
                table: "Song",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_CategoryId",
                table: "Song",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Song_SongId",
                table: "Basket",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Song_SongId",
                table: "BasketItem",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Song_SongId",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Song_SongId",
                table: "BasketItem");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "BasketItem",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_SongId",
                table: "BasketItem",
                newName: "IX_BasketItem_GameId");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Basket",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Basket",
                newName: "ActiveOrNot");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_SongId",
                table: "Basket",
                newName: "IX_Basket_GameId");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "AspNetUsers",
                newName: "DateofBirth");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Basket",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Basket",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoundedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_CategoryId",
                table: "Game",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PublisherId",
                table: "Game",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Game_GameId",
                table: "Basket",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Game_GameId",
                table: "BasketItem",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
