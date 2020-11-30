using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class AddCampoRoterRolaccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Router",
                table: "RolAcciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 22, 12, 3, 129, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 22, 12, 3, 130, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 22, 12, 3, 130, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 22, 12, 3, 130, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2020, 11, 29, 22, 12, 3, 139, DateTimeKind.Local).AddTicks(7474), new DateTime(2000, 11, 29, 22, 12, 3, 139, DateTimeKind.Local).AddTicks(4331) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Router",
                table: "RolAcciones");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 42, 5, 205, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2020, 11, 29, 21, 42, 5, 215, DateTimeKind.Local).AddTicks(8103), new DateTime(2000, 11, 29, 21, 42, 5, 215, DateTimeKind.Local).AddTicks(4375) });
        }
    }
}
