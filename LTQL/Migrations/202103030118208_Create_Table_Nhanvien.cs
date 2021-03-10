namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        HotenNV = c.String(),
                        Email = c.String(),
                        Sodienthoai = c.Int(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhanviens");
        }
    }
}
