using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBanRemCua26.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedbackModelNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Products_ProductId",
                table: "FeedBack");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack");

            migrationBuilder.RenameTable(
                name: "FeedBack",
                newName: "Feedbacks");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_ProductId",
                table: "Feedbacks",
                newName: "IX_Feedbacks_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks",
                column: "FeedbackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Products_ProductId",
                table: "Feedbacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks");

            migrationBuilder.RenameTable(
                name: "Feedbacks",
                newName: "FeedBack");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbacks_ProductId",
                table: "FeedBack",
                newName: "IX_FeedBack_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeedBack",
                table: "FeedBack",
                column: "FeedbackId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Products_ProductId",
                table: "FeedBack",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
