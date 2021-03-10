namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Tabel_Theloai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Theloais",
                c => new
                    {
                        Matheloai = c.String(nullable: false, maxLength: 128),
                        Tentheloai = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Matheloai);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Theloais");
        }
    }
}
