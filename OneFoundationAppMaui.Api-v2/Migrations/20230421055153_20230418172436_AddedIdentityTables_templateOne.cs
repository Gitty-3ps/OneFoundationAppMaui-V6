using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneFoundationAppMaui.Api_v2.Migrations
{
    /// <inheritdoc />
    public partial class _20230418172436_AddedIdentityTables_templateOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11454481-2d37-4fa8-b6be-ccd8799d66e2", "AQAAAAIAAYagAAAAENqpTPbbteCA6imGLv91IIov7CdupE4st7an2v8UN5ApD3z/kv7n4EtYaIEX256Ykg==", "d3e3cd5c-e314-470c-bd6f-e757c275b07f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2c3ba8-8df3-4174-97a1-fe5cb0b331bb", "AQAAAAIAAYagAAAAEMKP82EamW4zLoeIE9IXnpUfprrltdDoqYJkM0KJBSOi9Y2h/2AhKEjtKv+QeVUcjQ==", "3813679b-2f8f-4bde-9292-29090f4ea9a9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
