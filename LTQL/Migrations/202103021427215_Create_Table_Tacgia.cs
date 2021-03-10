namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Tacgia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tacgias",
                c => new
                    {
                        Matacgia = c.String(nullable: false, maxLength: 128),
                        Tentacgia = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Matacgia);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tacgias");
        }
    }
}
