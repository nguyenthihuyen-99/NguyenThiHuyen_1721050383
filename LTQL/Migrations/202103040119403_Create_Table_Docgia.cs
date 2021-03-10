namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Docgia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Docgias", "Tendocgia", c => c.String());
            AddColumn("dbo.Docgias", "Mamuon", c => c.String());
            AddColumn("dbo.Docgias", "Ghichu", c => c.String());
            AlterColumn("dbo.Docgias", "Ngaysinh", c => c.String());
            DropColumn("dbo.Docgias", "HoTendocgia");
            DropColumn("dbo.Docgias", "Donvi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Docgias", "Donvi", c => c.String());
            AddColumn("dbo.Docgias", "HoTendocgia", c => c.String());
            AlterColumn("dbo.Docgias", "Ngaysinh", c => c.DateTime(nullable: false));
            DropColumn("dbo.Docgias", "Ghichu");
            DropColumn("dbo.Docgias", "Mamuon");
            DropColumn("dbo.Docgias", "Tendocgia");
        }
    }
}
