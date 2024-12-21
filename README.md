Criar tabelas no banco de dados relacional sqlServer 
CREATE TABLE pessoa_fisica (
	id CHAR(36) NOT NULL, -- Campo para armazenar GUIDs, geralmente com 36 caracteres
    cpf VARCHAR(11) NOT NULL, -- CPF geralmente possui 11 caracteres
    nome VARCHAR(255) NOT NULL, -- Nome com tamanho padrão de até 255 caracteres
    dataNascimento DATE NOT NULL, -- Data de nascimento no formato DATE
    genero VARCHAR(50), -- Gênero com tamanho ajustável, por exemplo, até 50 caracteres
    estadoCivil VARCHAR(50), -- Estado civil com tamanho ajustável
    email VARCHAR(255), -- Email com tamanho padrão de até 255 caracteres
    PRIMARY KEY (id) -- Definindo o CPF como chave primária
);

CREATE TABLE pessoa_juridica (
    id CHAR(36) NOT NULL, -- Campo para armazenar GUIDs, geralmente com 36 caracteres
    cnpj VARCHAR(14) NOT NULL, -- CNPJ com 14 caracteres
    razaoSocial VARCHAR(255) NOT NULL, -- Razão social com até 255 caracteres
    dataFundacao DATE NOT NULL, -- Data de fundação no formato DATE
    nomeFantasia VARCHAR(255), -- Nome fantasia com até 255 caracteres
    atividadeDesenvolvida TEXT, -- Descrição da atividade desenvolvida
    PRIMARY KEY (id) -- Definindo o ID como chave primária
);

Modificar conenctString no arquivo "appsettings.json" referenciar o banco que as tabelas foram criadas
 "SqlConnection": {
   "SqlConnectionString": "Server=localhost;Database=DDD;User Id=sa;Password=1q2w3e4r@#$;"
 }

Imagem Swagger API

![image](https://github.com/user-attachments/assets/dc47aa39-3984-4ba3-ae84-6a3f8721957e)
