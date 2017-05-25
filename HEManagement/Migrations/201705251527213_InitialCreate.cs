namespace HEManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyID = c.Guid(nullable: false),
                        SurveyDateTime = c.DateTime(nullable: false),
                        CustomerID = c.Guid(nullable: false),
                        CeilingHeight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyID);
            
            CreateTable(
                "dbo.SurveyItemExistings",
                c => new
                    {
                        SurveyItemExistingID = c.Guid(nullable: false),
                        ItemLocation = c.String(),
                        CeilingHeight = c.Int(nullable: false),
                        HardwireOrPlugLoad = c.Int(nullable: false),
                        InteriorOrExterior = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ExistingFixtureType = c.Int(nullable: false),
                        FixtureBaseType = c.Int(nullable: false),
                        PostInstallQuantityRecommended = c.Int(nullable: false),
                        Survey_SurveyID = c.Guid(),
                    })
                .PrimaryKey(t => t.SurveyItemExistingID)
                .ForeignKey("dbo.Surveys", t => t.Survey_SurveyID)
                .Index(t => t.Survey_SurveyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SurveyItemExistings", "Survey_SurveyID", "dbo.Surveys");
            DropIndex("dbo.SurveyItemExistings", new[] { "Survey_SurveyID" });
            DropTable("dbo.SurveyItemExistings");
            DropTable("dbo.Surveys");
        }
    }
}
