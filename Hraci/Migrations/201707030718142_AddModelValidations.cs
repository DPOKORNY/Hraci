namespace Hraci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Soupiskas", "Jmeno", c => c.String(nullable: false));
            AlterColumn("dbo.Soupiskas", "Prijmeni", c => c.String(nullable: false));
            AlterColumn("dbo.Soupiskas", "Narodnost", c => c.String(nullable: false));
            AlterColumn("dbo.Soupiskas", "Post", c => c.String(nullable: false));
            AlterColumn("dbo.Soupiskas", "Popis", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Soupiskas", "Popis", c => c.String());
            AlterColumn("dbo.Soupiskas", "Post", c => c.String());
            AlterColumn("dbo.Soupiskas", "Narodnost", c => c.String());
            AlterColumn("dbo.Soupiskas", "Prijmeni", c => c.String());
            AlterColumn("dbo.Soupiskas", "Jmeno", c => c.String());
        }
    }
}
