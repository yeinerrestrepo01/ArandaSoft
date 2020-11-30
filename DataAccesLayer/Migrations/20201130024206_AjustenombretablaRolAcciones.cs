using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class AjustenombretablaRolAcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolaAcciones");

            migrationBuilder.CreateTable(
                name: "RolAcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolesRolId = table.Column<int>(type: "int", nullable: false),
                    AccionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolAcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolAcciones_Acciones_AccionesId",
                        column: x => x.AccionesId,
                        principalTable: "Acciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolAcciones_Roles_RolesRolId",
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

            migrationBuilder.CreateIndex(
                name: "IX_RolAcciones_AccionesId",
                table: "RolAcciones",
                column: "AccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_RolAcciones_RolesRolId",
                table: "RolAcciones",
                column: "RolesRolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolAcciones");

            migrationBuilder.CreateTable(
                name: "RolaAcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccionesId = table.Column<int>(type: "int", nullable: false),
                    RolesRolId = table.Column<int>(type: "int", nullable: false)
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
    }
}
