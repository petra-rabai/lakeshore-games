CREATE VIEW [dbo].[vw_Active_User]
	AS SELECT * FROM mainframe.[User] WHERE IsDeleted = 0
