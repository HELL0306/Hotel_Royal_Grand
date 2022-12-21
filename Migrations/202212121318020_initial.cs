namespace Hotel_Management_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        room_id = c.Int(nullable: false),
                        room_rate = c.Single(nullable: false),
                        room_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.room_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
        }
    }
}
