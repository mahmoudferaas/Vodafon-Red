using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updateSaleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Numbers_NumberId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Packages_PackageId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Status_StatusId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PackageId",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NumberId",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Numbers_NumberId",
                table: "Sales",
                column: "NumberId",
                principalTable: "Numbers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Packages_PackageId",
                table: "Sales",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Status_StatusId",
                table: "Sales",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Numbers_NumberId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Packages_PackageId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Status_StatusId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PackageId",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberId",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Numbers_NumberId",
                table: "Sales",
                column: "NumberId",
                principalTable: "Numbers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Packages_PackageId",
                table: "Sales",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Status_StatusId",
                table: "Sales",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
