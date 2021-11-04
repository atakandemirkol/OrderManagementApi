using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.DataAccess.Migrations
{
    public partial class initialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PositionCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ColorId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrderCount = table.Column<int>(type: "int", nullable: false),
                    ReleasedCount = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    Priorty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");
        }
    }
}
