using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioAPI.Migrations
{
    /// <inheritdoc />
    public partial class cambiosData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proveedores",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Apellido", "Direccion", "Nacimiento", "Nacionalidad", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 1, "Ramirez", "De la vuelta te embroco 2 cuadras a lago, Casa V2", new DateTime(1979, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuba", "Juan", "m", "89273898" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Costo", "Existencia", "Id_Proveedor", "Nombre", "Precio" },
                values: new object[] { 1, 800.00m, 1, 1, "PC gaming", 1000.00m });
        }
    }
}
