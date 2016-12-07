namespace TestBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Name", c => c.String(nullable: false, maxLength: 60));
            AddColumn("dbo.Transactions", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "FromAccount", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "ToAccount", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "PreBalance");
            DropColumn("dbo.Transactions", "PostBalance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PostBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "PreBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "ToAccount");
            DropColumn("dbo.Transactions", "FromAccount");
            DropColumn("dbo.Transactions", "Amount");
            DropColumn("dbo.Accounts", "Name");
        }
    }
}
