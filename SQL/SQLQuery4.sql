 SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		 Archana
-- Create date: 13/03/2023
-- Description:	
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[EmpNameDisplay]
	-- Add the parameters for the stored procedure here
	@enum int, @ena nvarchar(20), @phno int, @eno int, @ename nvarchar(20), @cou int = 0 out, @cou1 int = 10 OUT
	
AS
DECLARE @oldcount int =0;
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	set @oldcount =(select count(*) from emp);
	begin transaction;
	insert emp(eno,ename,ph)values(@enum, @ena, @phno);
	commit;
	SELECT eno, ename from emp;
	set @cou = (@oldcount + 1);
	set @cou1 =(@cou);
END
GO