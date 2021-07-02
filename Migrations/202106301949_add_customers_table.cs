using Domain.Constants;
using FluentMigrator;
using Migrations.Framework;

namespace Migrations
{
    [Migration(202106301949)]
    class _202106301949_add_customers_table : Migration
    {
        public override void Down()
        {
            Delete.Table(TableConstants.Customers);
        }

        public override void Up()
        {
            Create.Table(TableConstants.Customers)
                .WithCommonColumns()
                .WithColumn("PersonType").AsInt32().NotNullable()
                .WithColumn("FirstName").AsString().NotNullable()
                .WithColumn("LastName").AsString().NotNullable()
                .WithColumn("Phone").AsString().Nullable()
                .WithColumn("Email").AsString().Nullable()
                .WithColumn("BirthDate").AsDateTime().Nullable();
        }
    }
}
