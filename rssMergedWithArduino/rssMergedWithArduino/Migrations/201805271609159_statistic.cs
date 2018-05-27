namespace rssMergedWithArduino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statistic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StatisticDataBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Economy = c.Int(nullable: false),
                        Sport = c.Int(nullable: false),
                        Science = c.Int(nullable: false),
                        Life = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StatisticDataBases");
        }
    }
}
