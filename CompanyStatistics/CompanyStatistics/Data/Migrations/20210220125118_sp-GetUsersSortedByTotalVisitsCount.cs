using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyStatistics.Data.Migrations
{
    public partial class spGetUsersSortedByTotalVisitsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetUsersSortedByTotalVisitsCount]
	                    @limit int
                    AS
                    BEGIN
	                    SELECT u.UserId, u.FirstName, u.LastName
                        FROM (SELECT TOP(@limit) UserId, COUNT(UserId) AS TotalVisitsCount
		                        FROM [dbo].[Visits]
		                        GROUP BY UserId
		                        ORDER BY TotalVisitsCount DESC) AS uv
                        INNER JOIN [dbo].[Users] AS u ON uv.UserId = u.UserId		
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE [dbo].[GetUsersSortedByTotalVisitsCount]");
        }
    }
}
