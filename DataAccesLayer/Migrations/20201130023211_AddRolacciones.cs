using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class AddRolacciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RolaAcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolesRolId = table.Column<int>(type: "int", nullable: false),
                    AccionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolaAcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolaAcciones_Acciones_AccionesId",
                        column: x => x.AccionesId,
                        principalTable: "Acciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolaAcciones_Roles_RolesRolId",
                        column: x => x.RolesRolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 32, 10, 577, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 32, 10, 579, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 32, 10, 579, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 21, 32, 10, 579, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2020, 11, 29, 21, 32, 10, 587, DateTimeKind.Local).AddTicks(9666), new DateTime(2000, 11, 29, 21, 32, 10, 587, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.CreateIndex(
                name: "IX_RolaAcciones_AccionesId",
                table: "RolaAcciones",
                column: "AccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_RolaAcciones_RolesRolId",
                table: "RolaAcciones",
                column: "RolesRolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolaAcciones");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 18, 28, 23, 488, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 18, 28, 23, 489, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 18, 28, 23, 489, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2020, 11, 29, 18, 28, 23, 489, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaNacimiento" },
                values: new object[] { new DateTime(2020, 11, 29, 18, 28, 23, 498, DateTimeKind.Local).AddTicks(6542), new DateTime(2000, 11, 29, 18, 28, 23, 498, DateTimeKind.Local).AddTicks(3098) });
        }
    }
}
