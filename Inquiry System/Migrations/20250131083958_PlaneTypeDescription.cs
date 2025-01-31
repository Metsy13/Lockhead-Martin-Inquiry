using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inquiry_System.Migrations
{
    /// <inheritdoc />
    public partial class PlaneTypeDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_Planes_PlaneID",
                table: "Inquiries");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeID",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistories_Inquiries_InquiryID",
                table: "StatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistories_Users_UserID",
                table: "StatusHistories");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "StatusHistories",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "InquiryID",
                table: "StatusHistories",
                newName: "InquiryId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusHistories_UserID",
                table: "StatusHistories",
                newName: "IX_StatusHistories_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusHistories_InquiryID",
                table: "StatusHistories",
                newName: "IX_StatusHistories_InquiryId");

            migrationBuilder.RenameColumn(
                name: "PlaneTypeID",
                table: "Planes",
                newName: "PlaneTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Planes_PlaneTypeID",
                table: "Planes",
                newName: "IX_Planes_PlaneTypeId");

            migrationBuilder.RenameColumn(
                name: "PlaneID",
                table: "Inquiries",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiries_PlaneID",
                table: "Inquiries",
                newName: "IX_Inquiries_PlaneId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PlaneTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_Planes_PlaneId",
                table: "Inquiries",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes",
                column: "PlaneTypeId",
                principalTable: "PlaneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusHistories_Inquiries_InquiryId",
                table: "StatusHistories",
                column: "InquiryId",
                principalTable: "Inquiries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusHistories_Users_UserId",
                table: "StatusHistories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_Planes_PlaneId",
                table: "Inquiries");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeId",
                table: "Planes");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistories_Inquiries_InquiryId",
                table: "StatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusHistories_Users_UserId",
                table: "StatusHistories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PlaneTypes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "StatusHistories",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "InquiryId",
                table: "StatusHistories",
                newName: "InquiryID");

            migrationBuilder.RenameIndex(
                name: "IX_StatusHistories_UserId",
                table: "StatusHistories",
                newName: "IX_StatusHistories_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_StatusHistories_InquiryId",
                table: "StatusHistories",
                newName: "IX_StatusHistories_InquiryID");

            migrationBuilder.RenameColumn(
                name: "PlaneTypeId",
                table: "Planes",
                newName: "PlaneTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Planes_PlaneTypeId",
                table: "Planes",
                newName: "IX_Planes_PlaneTypeID");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Inquiries",
                newName: "PlaneID");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiries_PlaneId",
                table: "Inquiries",
                newName: "IX_Inquiries_PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_Planes_PlaneID",
                table: "Inquiries",
                column: "PlaneID",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_PlaneTypes_PlaneTypeID",
                table: "Planes",
                column: "PlaneTypeID",
                principalTable: "PlaneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusHistories_Inquiries_InquiryID",
                table: "StatusHistories",
                column: "InquiryID",
                principalTable: "Inquiries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusHistories_Users_UserID",
                table: "StatusHistories",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
