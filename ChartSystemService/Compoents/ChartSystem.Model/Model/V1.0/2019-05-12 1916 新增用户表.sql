USE ChartDB
GO 

  IF OBJECT_ID ('T_Core_User') IS  NULL   
        BEGIN
		   CREATE TABLE T_Core_User
		   (
				[ID] VARCHAR(32) NOT NULL PRIMARY KEY,
				[CompoentID] VARCHAR(32) NOT NULL,
				[UserCode] VARCHAR(20) NOT NULL,
				[UserName] VARCHAR(50) NOT NULL,
				[UserPYM] VARCHAR(25) NOT NULL,
				[UserPWD] VARCHAR(20) NOT NULL,
				[UserSex] BIT NOT NULL,
				[UserNickname] VARCHAR(50) NOT NULL 
		   )
		END 
GO 