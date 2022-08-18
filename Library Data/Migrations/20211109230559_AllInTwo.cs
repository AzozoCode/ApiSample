using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Data.Migrations
{
    public partial class AllInTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(type: "varchar(5)", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "varchar(40)", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staffs_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_Faculties_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowRequests",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Lastname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Firstname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Middlename = table.Column<string>(type: "varchar(30)", nullable: true),
                    GradeID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowRequests", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_BorrowRequests_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowRequests_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowRequests_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BorrowRequests_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Middlename = table.Column<string>(type: "varchar(30)", nullable: true),
                    Lastname = table.Column<string>(type: "varchar(30)", nullable: false),
                    GradeID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<int>(type: "int", nullable: false),
                    Lastname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Firstname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Middlename = table.Column<string>(type: "varchar(30)", nullable: true),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    DateBorrowed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_BorrowRequests_RequestID",
                        column: x => x.RequestID,
                        principalTable: "BorrowRequests",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeclinedRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestID = table.Column<int>(type: "int", nullable: false),
                    Lastname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Firstname = table.Column<string>(type: "varchar(30)", nullable: false),
                    Middlename = table.Column<string>(type: "varchar(30)", nullable: true),
                    Contact = table.Column<string>(type: "varchar(15)", nullable: false),
                    DateBorrowed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeclinedRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeclinedRequests_BorrowRequests_RequestID",
                        column: x => x.RequestID,
                        principalTable: "BorrowRequests",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_RequestID",
                table: "BorrowedBooks",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRequests_DepartmentID",
                table: "BorrowRequests",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRequests_GradeID",
                table: "BorrowRequests",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRequests_StaffID",
                table: "BorrowRequests",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRequests_StudentID",
                table: "BorrowRequests",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DeclinedRequests_RequestID",
                table: "DeclinedRequests",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentID",
                table: "Staffs",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_FacultyID",
                table: "Staffs",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GradeID",
                table: "Users",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StaffID",
                table: "Users",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentID",
                table: "Users",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "DeclinedRequests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BorrowRequests");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
