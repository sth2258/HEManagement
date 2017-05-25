namespace HEManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initia : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SurveyItemExistings", "CeilingHeight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SurveyItemExistings", "CeilingHeight", c => c.Int(nullable: false));
        }
    }
}
