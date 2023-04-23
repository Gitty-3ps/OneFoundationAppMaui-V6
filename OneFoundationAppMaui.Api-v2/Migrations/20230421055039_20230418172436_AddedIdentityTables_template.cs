using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneFoundationAppMaui.Api_v2.Migrations
{
    /// <inheritdoc />
    public partial class _20230418172436_AddedIdentityTables_template : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20c1a987-bb2b-46b6-9ce1-00544de3ddcf", "AQAAAAIAAYagAAAAEO/CQZXu/bEmWG8lXvhPnKiDyj2elERCdg3KeqLO2Idgu+S03YcYhBHJmqCWr8C7jA==", "9e11c07b-7fec-45e2-9d19-830bdec22801" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6026dcd-99c9-4dd1-8da8-d49344047895", "AQAAAAIAAYagAAAAEAKSCmO5qIMNfomzvxG+CeCu1bCIV3DGuf9aLws5mi8+wAAMarOxAP54JC4sqZ52TQ==", "bb968406-5481-440a-be75-c807471f477c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93baa2a8-fdb8-446d-aa91-053314afc23b", "AQAAAAIAAYagAAAAEPue3PCzjsKSnObY63okvc9hEYKk+4iDQwdo6yk5Ul8/yL2gLPrcmOoMxerZ2ill2g==", "b263bd71-378c-4a02-9287-fe93fbb3cb2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35aeaf4e-0335-4e03-b7d8-9a5e7509fb14", "AQAAAAIAAYagAAAAEL72300qFWVO98Hexby5DZQQP5vKUK5tvB7yYM7+JlkxkFDyz9IEbPezFhNl1obOWA==", "9f978a0c-adaa-49af-913b-202d920fefc6" });
        }
    }
}
