using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TB.Migrations
{
    public partial class db_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_MS_AMPUR");

            migrationBuilder.DropTable(
                name: "TBL_MS_CHANGWAT");

            migrationBuilder.DropTable(
                name: "TBL_MS_TAMBON");
        }
    }
}
