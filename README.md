# Boas-vindas ao repositório Guess Number Game.

# Orientações

  <summary><strong>‼️ Para executar o projeto ⏯️</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:Mathluiz23/guessNumberGame-csharp.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd guessNumberGame-csharp/`
  - Já dentro da pasta do repositório, entre na pasta src:
  - `cd src/`

  2. Instale as dependências

  - `dotnet restore`.
  
<details>
  <summary><strong>🛠 Testes</strong></summary><br />
  <h3>Executando todos os testes</h3>

  Para executar os testes com o .NET, execute o comando dentro do diretório `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```
</details>

# Projeto 🎥

Este projeto consiste em um o jogo de `Adivinhe o Número!` um jogo clássico!

As regras do jogo são bem simples:
- O jogador 1 escolhe um número aleatório;
- O jogador 2 tenta adivinhar esse número;
- O jogador 1 responde se a tentativa do jogador 2 foi correta, abaixo ou acima do número escolhido.
-Essa sequência se repete até que o jogador 2 acerte o número.

## Os requisitos foram construídos da seguinte forma:
  
 
### 1 - Imprima uma mensagem e receba a resposta da pessoa usuária.
_Lógica criada no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Ao ser executado, a primeira ação do programa irá imprimir uma mensagem de boas-vindas!</summary><br/>

 A mensagem será exatamente:
 ```
 "---Bem-vindo ao Guessing Game---"
 "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"
 ```
  
 > Lógica criada na função `Greet()`

</details>

<details>
  <summary>Em seguida, o programa irá esperar a entrada da pessoa usuária e armazenr na variável `response`.</summary><br />

> Se a pessoa usuária não inserir um número **inteiro**, ou se ele inserir um número **fora do range** (-100, 100), o programa irá imprimir a mensagem: `"Por favor, digite um número inteiro:"`
> 
    > E esperar uma nova entrada da pessoa usuária **até** a pessoa usuária inserir um número válido.
  
</details>

<details>
  <summary>O programa irá, então, converter a entrada da pessoa usuária em um tipo `int` e armazenar na variável `userValue`.</summary><br />

> Lógica criada na função `ChooseNumber()`
  
</details>

O programa pode ser executado usando
`dotnet run` na pasta `scr/guessing-number`.

<details>
  <summary> Criando os testes </summary><br/>
  
- Se o programa **imprime a mensagem correta**
- Se o programa **recebe a entrada da pessoa usuária**
- Se o programa **faz a validação do tipo `int`**
- Se o programa **faz a validação do range `-100 e 100`**

</details>

### 2 - O programa irá escolher um número aleatório.
_Criando a lógica do requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>O programa agora irá escolher um número aleatório `entre -100 e 100` e armazenar na variável `randomValue`.</summary><br/>

> Utilizado a função `random.GetInt(x, y)` para escolher números aleatórios.

</details>

<details>
  <summary>Agora, o programa irá comparar a entrada da pessoa usuária com o número aleatório e analisá-lo</summary><br />

- **Se** a entrada for **maior** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MENOR`
- **Se** a entrada for **menor** que o número aleatório, o programa deverá imprimir a mensagem: `Tente um número MAIOR`
- **Se** a entrada for **igual** ao número aleatório, o programa deverá imprimir a mensagem: `ACERTOU!`
 
</details>

<details>
  <summary> Criando os testes </summary><br/>

  - Se o programa **escolhe um número aleatório entre -100 e 100**
  - Se o programa **compara corretamente a entrada e o número escolhido**
  - Quando o número da pessoa usuária é **menor**
  - Quando o número da pessoa usuária é **maior**
  - Quando a pessoa usuária **acertar**

</details>

### 3 - O programa irá repetir a operação de escolha da pessoa usuária
_Criando a lógica do seu requisito no arquivo src/`guessing-number/GuessingGame.cs`._

<details>
  <summary>Se a pessoa usuária errar o número aleatório, seja para `MAIOR`, seja para `MENOR`, o programa deve receber uma nova tentativa.</summary><br/>

</details>

<details>
  <summary>O programa irá repetir esse procedimento **até** a pessoa usuária acertar o número escolhido aleatoriamente.</summary><br />
 
</details>

<details>
  <summary> Criando os testes </summary><br/>

  - Se o programa **repete o comportamento até a pessoa usuária acertar.**
  
</details>

# Exemplo

Um exemplo da execução do programa é:
Para um fluxo correto! 
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"10"
Tente um número MENOR
"0"
Tente um número MENOR
"-50"
Tente um número MAIOR
"-30"
Tente um número MAIOR
"-21"
ACERTOU!
```

Para um fluxo com verificações de tipo e range!
```
---Bem-vindo ao Guessing Game---
Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!
"teste"
Por favor, digite um número inteiro:
"nao"
Por favor, digite um número inteiro:
"10"
Tente um número MAIOR
"1000"
Por favor, digite um número inteiro:
"50"
Tente um número MAIOR
"77"
ACERTOU!
```

