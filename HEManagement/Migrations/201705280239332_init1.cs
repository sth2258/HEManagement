namespace HEManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SurveyItemExistings", "CeilingHeight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SurveyItemExistings", "CeilingHeight");
        }
    }
}
