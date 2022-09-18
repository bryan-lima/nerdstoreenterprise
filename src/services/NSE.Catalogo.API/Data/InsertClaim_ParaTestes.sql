USE [NerdStoreEnterpriseDB]

-- Primeiramente, deve-se ter criado um usuário com o email: teste@email.com
-- SELECT * FROM [dbo].[AspNetUsers]

SELECT * FROM [dbo].[AspNetUserClaims]

INSERT INTO [dbo].[AspNetUserClaims] 
	([UserId], [ClaimType], [ClaimValue])
VALUES 
	((SELECT TOP 1 [Id] FROM [dbo].[AspNetUsers] WHERE [UserName] = 'teste@email.com'), 'Catalogo', 'Ler')