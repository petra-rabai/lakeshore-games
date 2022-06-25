CREATE VIEW [dbo].[vw_Deleted_User]
	AS SELECT LoginName,DeletedDate FROM mainframe.[User] WHERE IsDeleted = 1
