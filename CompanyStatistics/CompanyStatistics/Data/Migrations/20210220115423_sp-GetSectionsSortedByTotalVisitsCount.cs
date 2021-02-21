using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyStatistics.Data.Migrations
{
    public partial class spGetSectionsSortedByTotalVisitsCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetSectionsSortedByTotalVisitsCount]
	                    @limit int
                    AS
                    BEGIN
	                    SELECT s.SectionId, s.Name
                        FROM (SELECT TOP(@limit) SectionId, COUNT(SectionId) AS TotalVisitsCount
		                        FROM [dbo].[Visits]
		                        GROUP BY SectionId
		                        ORDER BY TotalVisitsCount DESC) AS sv
                        INNER JOIN [dbo].[Sections] AS s ON sv.SectionId = s.SectionId	
                    END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE [dbo].[GetSectionsSortedByTotalVisitsCount]");
        }
    }
}
