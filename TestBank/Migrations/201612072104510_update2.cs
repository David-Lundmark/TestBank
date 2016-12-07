namespace TestBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "AccountId", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "AccountId" });
            DropColumn("dbo.Transactions", "AccountId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "AccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "AccountId");
            AddForeignKey("dbo.Transactions", "AccountId", "dbo.Accounts", "AccountId", cascadeDelete: true);
        }
    }
}
