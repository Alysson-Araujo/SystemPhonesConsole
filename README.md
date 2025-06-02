## Sistema Console de Celulares 

### Descrição
Este é um sistema simples de console para gerenciar celulares, permitindo adicionar celulares (Iphone e Nokia), ligar,
receber chamdas, e instalar aplicativosde um estoque. Foi feito com C# e utiliza conceitos de Programação Orientada a Objetos (POO).

### Funcionalidades
- Adicionar celulares (Iphone e Nokia).
- Ligar e receber chamadas.
- Instalar aplicativos.

---

### Descrição sobre a atividade

Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Você deve criar as suas classes de acordo com o diagrama abaixo:

### Diagrama classes
![Diagrama](./Images/diagrama.png)


### Regras e validações
A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
A classe Nokia e Iphone devem ser classes filhas de Smartphone.
O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.