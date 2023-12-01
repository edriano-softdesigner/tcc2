--
-- Banco de dados: `mydb`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cofins`
--

CREATE TABLE `cofins` (
  `idCofins` int(11) NOT NULL,
  `Cofins` varchar(45) NOT NULL,
  `CSTCofins` varchar(45) NOT NULL,
  `idOperacao_Fiscal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `conta`
--

CREATE TABLE `conta` (
  `idConta` int(11) NOT NULL,
  `Numero_Banco` varchar(45) NOT NULL,
  `Agencia` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Numero_Conta` varchar(45) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `empresa`
--

CREATE TABLE `empresa` (
  `idEmpresa` int(11) NOT NULL,
  `Datadecriacao` date NOT NULL,
  `CRT` int(11) NOT NULL,
  `Nomefantasia` varchar(45) NOT NULL,
  `Razaosocial` varchar(45) NOT NULL,
  `CNPJ` int(11) NOT NULL,
  `inscricaoEstadual` int(11) NOT NULL,
  `inscricaoMunicipal` int(11) NOT NULL,
  `CEP` int(11) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  `Numero` int(11) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `Telefone` int(11) NOT NULL,
  `Email` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `endereco`
--

CREATE TABLE `endereco` (
  `idEndereço` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL,
  `idTPendereco` int(11) NOT NULL,
  `cep` varchar(8) NOT NULL,
  `Estado` varchar(20) NOT NULL,
  `Cidade` varchar(45) NOT NULL,
  `Logradouro` varchar(45) NOT NULL,
  `Numero` int(11) NOT NULL,
  `Bairro` varchar(45) NOT NULL,
  `Complemento` varchar(45) NOT NULL,
  `EnderecoPadrao` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `financeiro`
--

CREATE TABLE `financeiro` (
  `idFinanceiro` int(11) NOT NULL,
  `idMovimentoParcelas` int(11) NOT NULL,
  `idTPFinanceiro` int(11) NOT NULL,
  `idPlanoDeContas` int(11) NOT NULL,
  `idTPPagamento` int(11) NOT NULL,
  `idEmpresa` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL,
  `DTcadastro` date NOT NULL,
  `DTalteracao` date NOT NULL,
  `DTpagamento` date NOT NULL,
  `DTvencimento` date NOT NULL,
  `Valor` double NOT NULL,
  `Valorpago` double NOT NULL,
  `Desc_acresc` double NOT NULL,
  `Nrparcela` int(11) NOT NULL,
  `Observacao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `financeiro/cc`
--

CREATE TABLE `financeiro/cc` (
  `idMovimento_Conta` int(11) NOT NULL,
  `idFinanceiro` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `gradex`
--

CREATE TABLE `gradex` (
  `idGradex` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `gradey`
--

CREATE TABLE `gradey` (
  `idGradey` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `grupo`
--

CREATE TABLE `grupo` (
  `idGrupo` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `grupousuario`
--

CREATE TABLE `grupousuario` (
  `idGrupoUsuario` int(11) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Situacao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `grupo_tributario`
--

CREATE TABLE `grupo_tributario` (
  `idGrupo_Tributario` int(11) NOT NULL,
  `idEmpresa` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `ipi`
--

CREATE TABLE `ipi` (
  `idIPI` int(11) NOT NULL,
  `IPI` varchar(45) NOT NULL,
  `CSTIPI` varchar(45) NOT NULL,
  `idOperacao_Fiscal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `itemmovimento`
--

CREATE TABLE `itemmovimento` (
  `idItemMovimento` int(11) NOT NULL,
  `idProdutograde` int(11) NOT NULL,
  `idLocalizacao` int(11) NOT NULL,
  `idMovimento` int(11) NOT NULL,
  `Promocao_idPromocao` int(11) NOT NULL,
  `Quantidade` varchar(45) NOT NULL,
  `Saldoestoque` varchar(45) NOT NULL,
  `Datacadastro` date NOT NULL,
  `Dataalteracao` date NOT NULL,
  `Valorunitario` double NOT NULL,
  `DescontoAcrescimo` double NOT NULL,
  `ValorTotal` double NOT NULL,
  `idTributacao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `itemservico`
--

CREATE TABLE `itemservico` (
  `idItemServico` int(11) NOT NULL,
  `idServico` int(11) NOT NULL,
  `idMovimento` int(11) NOT NULL,
  `Promocao_idPromocao` int(11) NOT NULL,
  `Quantidade` int(11) NOT NULL,
  `Datacadastro` date NOT NULL,
  `Dataalteracao` date NOT NULL,
  `Valorunitario` double NOT NULL,
  `DescontoAcrescimo` double NOT NULL,
  `ValorTotal` double NOT NULL,
  `idTributacao` int(11) NOT NULL,
  `idItemMovimento` int(11) DEFAULT NULL,
  `idPrestador` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `localizacao`
--

CREATE TABLE `localizacao` (
  `idLocalizacao` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `movimento`
--

CREATE TABLE `movimento` (
  `idMovimento` int(11) NOT NULL,
  `idEmpresa` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL,
  `idTPMovimento` int(11) NOT NULL,
  `idOperacao` int(11) NOT NULL,
  `DataCadastro` date NOT NULL,
  `DataAlteracao` date NOT NULL,
  `Entregar(S/N)` tinyint(4) NOT NULL,
  `DataBaixa` date NOT NULL,
  `Desconto/acrescimo` double NOT NULL,
  `Situacao` varchar(45) NOT NULL,
  `idOperacao_Fiscal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `movimentoparcela`
--

CREATE TABLE `movimentoparcela` (
  `idMovimentoParcelas` int(11) NOT NULL,
  `idTPPagamento` int(11) NOT NULL,
  `idMovimento` int(11) NOT NULL,
  `DataVencimento` date NOT NULL,
  `Valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `movimento_conta`
--

CREATE TABLE `movimento_conta` (
  `idMovimento_Conta` int(11) NOT NULL,
  `Data_Cadastro` varchar(45) NOT NULL,
  `Data_Baixa` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Valor` varchar(45) NOT NULL,
  `Data_Conciliacao` date NOT NULL,
  `Conciliado` varchar(45) NOT NULL,
  `idConta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `nota`
--

CREATE TABLE `nota` (
  `idNota` int(11) NOT NULL,
  `NRNota` varchar(10) NOT NULL,
  `idMovimento` int(11) NOT NULL,
  `DataEmissao` datetime DEFAULT NULL,
  `Situacao` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `notaitem`
--

CREATE TABLE `notaitem` (
  `idNotaItem` int(11) NOT NULL,
  `idProdutoGrade` int(11) NOT NULL,
  `idNota` int(11) NOT NULL,
  `Quantidade` varchar(45) NOT NULL,
  `Valorunitario` double NOT NULL,
  `ValorTotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `operacao`
--

CREATE TABLE `operacao` (
  `idOperacao` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Entrada/Saida` double NOT NULL,
  `idPlanoDeContas` int(11) NOT NULL,
  `idTPFinanceiro` int(11) NOT NULL,
  `idMovimento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `operacao_fiscal`
--

CREATE TABLE `operacao_fiscal` (
  `idOperacao_Fiscal` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Desc_CFOP` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `permissao`
--

CREATE TABLE `permissao` (
  `idPermissao` int(11) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  `idTela` int(11) NOT NULL,
  `ALTERACAO` tinyint(4) NOT NULL,
  `INCLUSAO` tinyint(4) DEFAULT NULL,
  `EXCLUSAO` tinyint(4) DEFAULT NULL,
  `CONSULTA` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `idPessoa` int(11) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Datacriacao` date NOT NULL,
  `Nomefantasia` varchar(45) NOT NULL,
  `Razaosocial` varchar(45) NOT NULL,
  `IE_RG` varchar(15) NOT NULL,
  `CPF_CNPJ` varchar(60) NOT NULL,
  `Situacao` varchar(20) NOT NULL,
  `Telcomercial` varchar(15) NOT NULL,
  `Telresidencial` varchar(15) NOT NULL,
  `Celular` varchar(15) NOT NULL,
  `email` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pis`
--

CREATE TABLE `pis` (
  `idPIS` int(11) NOT NULL,
  `PIS` varchar(45) NOT NULL,
  `CSTPIS` varchar(45) NOT NULL,
  `idOperacao_Fiscal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `planodecontas`
--

CREATE TABLE `planodecontas` (
  `idPlanoDeContas` int(11) NOT NULL,
  `Classificacao` varchar(45) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `idPlanoDeContasPai` int(11) NOT NULL,
  `idConta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `idProduto` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  `idSubgrupo` int(11) NOT NULL,
  `idGrupo_Tributario` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `UnidadedeMedida` varchar(45) NOT NULL,
  `Situacao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtograde`
--

CREATE TABLE `produtograde` (
  `idProdutograde` int(11) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `idGradey` int(11) NOT NULL,
  `idGradex` int(11) NOT NULL,
  `Saldo` varchar(45) NOT NULL,
  `CodigodeBarras` int(11) NOT NULL,
  `PesoBruto` double NOT NULL,
  `PesoLiquido` double NOT NULL,
  `ValordeVenda` double NOT NULL,
  `CustoMedio` double NOT NULL,
  `CustoAtual` double NOT NULL,
  `EstoqueMinimo` double NOT NULL,
  `EstoqueMaximo` double NOT NULL,
  `Situacao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `promocao`
--

CREATE TABLE `promocao` (
  `idPromocao` int(11) NOT NULL,
  `idProdutograde` int(11) NOT NULL,
  `PorcentagemMinima` double NOT NULL,
  `PorcentagemMaxima` double NOT NULL,
  `DataInicio` date NOT NULL,
  `DataFim` date NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `servico`
--

CREATE TABLE `servico` (
  `idServico` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  `idSubgrupo` int(11) NOT NULL,
  `idGrupo_Tributario` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Situacao` varchar(1) NOT NULL,
  `ValorServico` decimal(8,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `subgrupo`
--

CREATE TABLE `subgrupo` (
  `idSubgrupo` int(11) NOT NULL,
  `idGrupo` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `telas`
--

CREATE TABLE `telas` (
  `idTela` int(11) NOT NULL,
  `NomeTela` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tpendereco`
--

CREATE TABLE `tpendereco` (
  `idTPendereco` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tpfinanceiro`
--

CREATE TABLE `tpfinanceiro` (
  `idTPFinanceiro` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tpmovimento`
--

CREATE TABLE `tpmovimento` (
  `idTPMovimento` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tppagamento`
--

CREATE TABLE `tppagamento` (
  `idTPPagamento` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL,
  `Conciliado` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tppessoa`
--

CREATE TABLE `tppessoa` (
  `idTPpessoa` int(11) NOT NULL,
  `Descricao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tppessoa_pessoa`
--

CREATE TABLE `tppessoa_pessoa` (
  `idTPpessoa` int(11) NOT NULL,
  `idPessoa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tributacao`
--

CREATE TABLE `tributacao` (
  `idTributacao` int(11) NOT NULL,
  `idOperacao_Fiscal` int(11) NOT NULL,
  `idGrupo_Tributario` int(11) NOT NULL,
  `icms` varchar(45) NOT NULL,
  `cfop` varchar(45) NOT NULL,
  `csosn` varchar(45) NOT NULL,
  `csticms` varchar(45) NOT NULL,
  `icmsst` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `CPF` int(11) NOT NULL,
  `Situacao` int(11) NOT NULL,
  `email` varchar(45) NOT NULL,
  `login` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `idGrupoUsuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cofins`
--
ALTER TABLE `cofins`
  ADD PRIMARY KEY (`idCofins`);

--
-- Índices de tabela `conta`
--
ALTER TABLE `conta`
  ADD PRIMARY KEY (`idConta`);

--
-- Índices de tabela `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`idEmpresa`);

--
-- Índices de tabela `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`idEndereço`);

--
-- Índices de tabela `financeiro`
--
ALTER TABLE `financeiro`
  ADD PRIMARY KEY (`idFinanceiro`);

--
-- Índices de tabela `financeiro/cc`
--
ALTER TABLE `financeiro/cc`
  ADD PRIMARY KEY (`idMovimento_Conta`,`idFinanceiro`);

--
-- Índices de tabela `gradex`
--
ALTER TABLE `gradex`
  ADD PRIMARY KEY (`idGradex`);

--
-- Índices de tabela `gradey`
--
ALTER TABLE `gradey`
  ADD PRIMARY KEY (`idGradey`);

--
-- Índices de tabela `grupo`
--
ALTER TABLE `grupo`
  ADD PRIMARY KEY (`idGrupo`);

--
-- Índices de tabela `grupousuario`
--
ALTER TABLE `grupousuario`
  ADD PRIMARY KEY (`idGrupoUsuario`);

--
-- Índices de tabela `grupo_tributario`
--
ALTER TABLE `grupo_tributario`
  ADD PRIMARY KEY (`idGrupo_Tributario`);

--
-- Índices de tabela `ipi`
--
ALTER TABLE `ipi`
  ADD PRIMARY KEY (`idIPI`);

--
-- Índices de tabela `itemmovimento`
--
ALTER TABLE `itemmovimento`
  ADD PRIMARY KEY (`idItemMovimento`);

--
-- Índices de tabela `itemservico`
--
ALTER TABLE `itemservico`
  ADD PRIMARY KEY (`idItemServico`);

--
-- Índices de tabela `localizacao`
--
ALTER TABLE `localizacao`
  ADD PRIMARY KEY (`idLocalizacao`);

--
-- Índices de tabela `movimento`
--
ALTER TABLE `movimento`
  ADD PRIMARY KEY (`idMovimento`);

--
-- Índices de tabela `movimentoparcela`
--
ALTER TABLE `movimentoparcela`
  ADD PRIMARY KEY (`idMovimentoParcelas`);

--
-- Índices de tabela `movimento_conta`
--
ALTER TABLE `movimento_conta`
  ADD PRIMARY KEY (`idMovimento_Conta`);

--
-- Índices de tabela `nota`
--
ALTER TABLE `nota`
  ADD PRIMARY KEY (`idNota`);

--
-- Índices de tabela `notaitem`
--
ALTER TABLE `notaitem`
  ADD PRIMARY KEY (`idNotaItem`);

--
-- Índices de tabela `operacao`
--
ALTER TABLE `operacao`
  ADD PRIMARY KEY (`idOperacao`);

--
-- Índices de tabela `operacao_fiscal`
--
ALTER TABLE `operacao_fiscal`
  ADD PRIMARY KEY (`idOperacao_Fiscal`);

--
-- Índices de tabela `permissao`
--
ALTER TABLE `permissao`
  ADD PRIMARY KEY (`idPermissao`);

--
-- Índices de tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`idPessoa`);

--
-- Índices de tabela `pis`
--
ALTER TABLE `pis`
  ADD PRIMARY KEY (`idPIS`);

--
-- Índices de tabela `planodecontas`
--
ALTER TABLE `planodecontas`
  ADD PRIMARY KEY (`idPlanoDeContas`);

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`idProduto`);

--
-- Índices de tabela `produtograde`
--
ALTER TABLE `produtograde`
  ADD PRIMARY KEY (`idProdutograde`);

--
-- Índices de tabela `promocao`
--
ALTER TABLE `promocao`
  ADD PRIMARY KEY (`idPromocao`);

--
-- Índices de tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`idServico`);

--
-- Índices de tabela `subgrupo`
--
ALTER TABLE `subgrupo`
  ADD PRIMARY KEY (`idSubgrupo`);

--
-- Índices de tabela `telas`
--
ALTER TABLE `telas`
  ADD PRIMARY KEY (`idTela`);

--
-- Índices de tabela `tpendereco`
--
ALTER TABLE `tpendereco`
  ADD PRIMARY KEY (`idTPendereco`);

--
-- Índices de tabela `tpfinanceiro`
--
ALTER TABLE `tpfinanceiro`
  ADD PRIMARY KEY (`idTPFinanceiro`);

--
-- Índices de tabela `tpmovimento`
--
ALTER TABLE `tpmovimento`
  ADD PRIMARY KEY (`idTPMovimento`);

--
-- Índices de tabela `tppagamento`
--
ALTER TABLE `tppagamento`
  ADD PRIMARY KEY (`idTPPagamento`);

--
-- Índices de tabela `tppessoa`
--
ALTER TABLE `tppessoa`
  ADD PRIMARY KEY (`idTPpessoa`);

--
-- Índices de tabela `tppessoa_pessoa`
--
ALTER TABLE `tppessoa_pessoa`
  ADD PRIMARY KEY (`idTPpessoa`,`idPessoa`);

--
-- Índices de tabela `tributacao`
--
ALTER TABLE `tributacao`
  ADD PRIMARY KEY (`idTributacao`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cofins`
--
ALTER TABLE `cofins`
  MODIFY `idCofins` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `financeiro`
--
ALTER TABLE `financeiro`
  MODIFY `idFinanceiro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `ipi`
--
ALTER TABLE `ipi`
  MODIFY `idIPI` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `movimento_conta`
--
ALTER TABLE `movimento_conta`
  MODIFY `idMovimento_Conta` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `nota`
--
ALTER TABLE `nota`
  MODIFY `idNota` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pis`
--
ALTER TABLE `pis`
  MODIFY `idPIS` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tpendereco`
--
ALTER TABLE `tpendereco`
  MODIFY `idTPendereco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;
