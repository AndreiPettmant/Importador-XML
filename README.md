
## Documentação do Projeto

#### Design Pattern Utilizado

```http
  MVC
```

#### Estrutura de Pastas

| Nome da Pasta| Descrição                           |
| :---------- | :---------------------------------- |
| `Model` | **Nesta pasta conterá todos as classes de comunicação com o banco e XML** |
| `Control` | **Nesta pasta conterá todos as classes de responsáveis pela comunicação Entre o Model e a View** |
| `View` | **Nesta pastá conterá as telas** |

#### Explicação da Solução

Solução desenvolvida em Windows Forms onde na tela inicial teremos dois botões, um responsável por trazer o arquivo do XML e outro responsável por fazer a importação do mesmo no banco de dados. Além disso, temos alguns campos para poder realizar a inserção de data e valor de custo além do campo responsável pelo número do cartório que está limitado a 7 caracteres. Possui também na aplicação um DataGridView responsável por trazer as informações do XML onde é possível alterar informações e deletar linhas se necessário. Quando importar o XML para o banco de dados, o botão de importação ficará inativo até um novo arquivo ser validado. Foi adicionado também um evento que ao clicar em uma das linhas abrirá um novo formulário trazendo as informações de forma invidividual do título clicado.

