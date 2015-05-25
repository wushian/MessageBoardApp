namespace MessageBoardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAttachment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Messages", "Attachment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Attachment", c => c.String());
        }
    }
}
