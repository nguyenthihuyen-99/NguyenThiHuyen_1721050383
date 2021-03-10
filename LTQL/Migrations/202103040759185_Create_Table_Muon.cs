namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Muon : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Muons", "Ngaymuon", c => c.String());
            AlterColumn("dbo.Muons", "Hanphaitra", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Muons", "Hanphaitra", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Muons", "Ngaymuon", c => c.DateTime(nullable: false));
        }
    }
}
