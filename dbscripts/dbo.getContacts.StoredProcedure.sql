USE [ContactManager2.0]
GO
/****** Object:  StoredProcedure [dbo].[getContacts]    Script Date: 14/02/2019 22:08:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getContacts]
AS 
    SELECT Id, FirstName, LastName, Email, Birthdate  
    FROM contacts;  
GO
