namespace MessageBoardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagereply : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        MessageToPost = c.String(),
                        From = c.String(),
                        DatePosted = c.DateTime(nullable: false),
                        Attachment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Replies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageId = c.Int(nullable: false),
                        ReplyFrom = c.String(),
                        ReplyMessage = c.String(),
                        ReplyDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Replies");
            DropTable("dbo.Messages");
        }
    }
}
