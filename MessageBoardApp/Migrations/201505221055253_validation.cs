namespace MessageBoardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Subject", c => c.String(nullable: false));
            AlterColumn("dbo.Messages", "MessageToPost", c => c.String(nullable: false));
            AlterColumn("dbo.Replies", "ReplyMessage", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Replies", "ReplyMessage", c => c.String());
            AlterColumn("dbo.Messages", "MessageToPost", c => c.String());
            AlterColumn("dbo.Messages", "Subject", c => c.String());
        }
    }
}
