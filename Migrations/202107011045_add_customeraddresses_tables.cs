using Domain.Constants;
using FluentMigrator;
using Migrations.Framework;

namespace Migrations
{
    [Migration(202107011045)]
    public class _202107011045_add_customeraddresses_tables : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.CustomerAddresses);
        }

        public override void Up()
        {
            Create.Table(TableConstants.CustomerAddresses)
                .WithCommonColumns()
                .WithColumn("AddressType").AsInt32().NotNullable()
                .WithColumn("CountryId").AsInt32().NotNullable()
                .WithColumn("City").AsString().Nullable()
                .WithColumn("Street").AsString().Nullable()
                .WithColumn("ZipCode").AsString().Nullable()
                .WithColumn("IsMain").AsBoolean().NotNullable().WithDefaultValue(0)
                .WithColumn("Number").AsString().Nullable()
                .WithColumn("Sector").AsString().Nullable();
        }
    }
}
