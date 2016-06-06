USE [Quiron]
GO

/****** Object:  View [dbo].[ProdutoVitrine]    Script Date: 27/09/2015 12:43:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ProdutoVitrine]
AS
SELECT DISTINCT 
                         MIN(LEFT(dbo.Produto.ProdutoCodigo, 8)) AS ProdutoModeloCor, dbo.Produto.ProdutoDescricao, dbo.Produto.MarcaDescricao, dbo.Produto.Preco, dbo.ProdutoModelo.GrupoCodigo, 
                         dbo.ProdutoModelo.SubGrupoCodigo, dbo.ProdutoModelo.CategoriaCodigo, dbo.ProdutoModelo.MarcaCodigo, dbo.ProdutoModelo.GeneroCodigo, dbo.ProdutoModelo.FaixaEtariaCodigo, 
                         dbo.ProdutoModelo.ModalidadeCodigo, dbo.ProdutoModelo.LinhaCodigo
FROM            dbo.ProdutoModelo INNER JOIN
                         dbo.Produto ON dbo.ProdutoModelo.ProdutoModeloCodigo = dbo.Produto.ProdutoModeloCodigo
GROUP BY dbo.Produto.ProdutoDescricao, dbo.Produto.MarcaDescricao, dbo.Produto.Preco, dbo.ProdutoModelo.GrupoCodigo, dbo.ProdutoModelo.SubGrupoCodigo, dbo.ProdutoModelo.CategoriaCodigo, 
                         dbo.ProdutoModelo.MarcaCodigo, dbo.ProdutoModelo.GeneroCodigo, dbo.ProdutoModelo.FaixaEtariaCodigo, dbo.ProdutoModelo.ModalidadeCodigo, dbo.ProdutoModelo.LinhaCodigo

GO



