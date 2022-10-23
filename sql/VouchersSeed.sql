USE [NerdStoreEnterpriseDB]

INSERT INTO [dbo].[Vouchers] ([Id], [Codigo], [Percentual], [ValorDesconto], [Quantidade], [TipoDesconto], [DataCriacao], [DataUtilizacao], [DataValidade], [Ativo], [Utilizado])
VALUES 
	(NEWID(), '150-OFF-GERAL', NULL, 150.00, 50, 1, GETDATE(), NULL, '2023-12-01T00:00:00', 1, 0),
	(NEWID(), '50-OFF-GERAL', 50.00, NULL, 45, 0, GETDATE(), NULL, '2023-12-01T00:00:00', 1, 0),
	(NEWID(), '10-OFF-GERAL', 10.00, NULL, 50, 0, GETDATE(), NULL, '2023-12-01T00:00:00', 1, 0)

--SELECT * FROM [dbo].[Vouchers]