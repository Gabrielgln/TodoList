using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TWTodoList.Migrations
{
    /// <inheritdoc />
    public partial class UpTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todo",
                table: "Todo");

            migrationBuilder.RenameTable(
                name: "Todo",
                newName: "todos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "todos",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_todos",
                table: "todos",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_todos",
                table: "todos");

            migrationBuilder.RenameTable(
                name: "todos",
                newName: "Todo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Todo",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todo",
                table: "Todo",
                column: "Id");
        }
    }
}
