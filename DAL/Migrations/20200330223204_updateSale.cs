using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updateSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Numbers_NumberID",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Packages_PackageID",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Status_StatusID",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "Sales",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "PackageID",
                table: "Sales",
                newName: "PackageId");

            migrationBuilder.RenameColumn(
                name: "NumberID",
                table: "Sales",
                newName: "NumberId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_StatusID",
                table: "Sales",
                newName: "IX_Sales_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_PackageID",
                table: "Sales",
                newName: "IX_Sales_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_NumberID",
                table: "Sales",
                newName: "IX_Sales_NumberId");

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

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Sales",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "Sales",
                newName: "PackageID");

            migrationBuilder.RenameColumn(
                name: "NumberId",
                table: "Sales",
                newName: "NumberID");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_StatusId",
                table: "Sales",
                newName: "IX_Sales_StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_PackageId",
                table: "Sales",
                newName: "IX_Sales_PackageID");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_NumberId",
                table: "Sales",
                newName: "IX_Sales_NumberID");

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PackageID",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NumberID",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Numbers_NumberID",
                table: "Sales",
                column: "NumberID",
                principalTable: "Numbers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Packages_PackageID",
                table: "Sales",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Status_StatusID",
                table: "Sales",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
