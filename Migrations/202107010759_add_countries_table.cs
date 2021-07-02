using Domain.Constants;
using FluentMigrator;
using Migrations.Framework;

namespace Migrations
{
    [Migration(202107010759)]
    public class _202107010759_add_countries_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.Countries);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Countries)
                .WithCommonColumns()
                .WithColumn("Iso2").AsString().NotNullable()
                .WithColumn("Name").AsString().NotNullable();
        }
    }
}
