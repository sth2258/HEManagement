namespace HEManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SurveyItemExistings",
                c => new
                    {
                        SurveyItemExistingID = c.Guid(nullable: false),
                        ItemLocation = c.String(),
                        HardwireOrPlugLoad = c.Int(nullable: false),
                        InteriorOrExterior = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ExistingFixtureType = c.Int(nullable: false),
                        FixtureBaseType = c.Int(nullable: false),
                        PostInstallQuantityRecommended = c.Int(nullable: false),
                        SurveyID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyItemExistingID)
                .ForeignKey("dbo.Surveys", t => t.SurveyID, cascadeDelete: true)
                .Index(t => t.SurveyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SurveyItemExistings", "SurveyID", "dbo.Surveys");
            DropIndex("dbo.SurveyItemExistings", new[] { "SurveyID" });
            DropTable("dbo.SurveyItemExistings");
        }
    }
}
