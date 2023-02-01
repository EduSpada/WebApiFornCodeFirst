# WebApiFornCodeFirst
API .NET CORE 6 baseado no Entity FrameWork e SQL Server com o método Code First


# Para dar Início a API rodar o comando

<EntityFrameworkCore\Add-Migration init>

e em seguida

<EntityFrameworkCore\Update-Database>

Após isso o banco de dados será criado

Dar início a depuração do Visual Studio 2022

# Swagger

Geralmente ele iniciará automáticamente no enderelço abaixo

http://localhost:5118/swagger/index.html

Pode haver auteração da porta 


# Requisições

## FornecedoresByName

GET /api/FornecedoresByName
- retorna todos os fornecedores

POST /api/FornecedoresByName
- Insere um fornecedor e um ou mais endereços

 Obs: Não cadastrar o CNPJ com pontos, ifens ou barras.

GET /api/FornecedoresByName/{name}
- Retorna um fornecedor pelo nome

PUT /api/FornecedoresByName/{id}
- Edita um fornecedor e endereços pelo id

DELETE /api/FornecedoresByName/{id}
- Deleta um fornecedor pelo id

## FornecedoresByCnpj

GET /api/FornecedoresByCnpj/{cnpj}
- Retorna um fornecedor pelo cnpj

 Obs: O parametro do CNPJ sem pontos, ifens ou barras.

## FornecedoresByCidade

GET /api/FornecedoresByCidade/{cidade}
- Retorna um endereço por cidade

## Enderecos

GET /api/Enderecos
- retorna todos os endereços

POST /api/Enderecos
- Insere um ou mais endereços

GET /api/Enderecos/{id}
- Retorna um endereço pelo id

PUT /api/Enderecos/{id}
- Edita um endereço pelo id

DELETE /api/Enderecos/{id}
- Deleta um endereço pelo id