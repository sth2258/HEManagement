namespace HEManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SurveyItemExistings", "SurveyID", "dbo.Surveys");
            DropIndex("dbo.SurveyItemExistings", new[] { "SurveyID" });
            DropTable("dbo.SurveyItemExistings");
        }
        
        public override void Down()
        {
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
                        SurveyID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyItemExistingID);
            
            CreateIndex("dbo.SurveyItemExistings", "SurveyID");
            AddForeignKey("dbo.SurveyItemExistings", "SurveyID", "dbo.Surveys", "SurveyID", cascadeDelete: true);
        }
    }
}
