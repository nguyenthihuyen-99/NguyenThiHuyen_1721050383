namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sachs",
                c => new
                    {
                        Masach = c.String(nullable: false, maxLength: 30),
                        Tensach = c.String(),
                        Tentacgia = c.String(),
                        Matacgia = c.String(),
                        Matheloai = c.String(),
                        NamXB = c.Int(nullable: false),
                        MaNXB = c.String(),
                    })
                .PrimaryKey(t => t.Masach);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sachs");
        }
    }
}
