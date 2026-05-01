# 🛒 Order Management System

Aplicação console desenvolvida em **C#** que simula um sistema de gerenciamento de pedidos, com base em um diagrama UML de classes.

---

## 📋 Sobre o Projeto

O sistema permite cadastrar um cliente, criar um pedido com múltiplos itens e exibir um sumário completo com o valor total da compra.

---

## 🗂️ Estrutura do Projeto

```
Ex10/
│
├── Entities/
│   ├── Client.cs
│   ├── Order.cs
│   ├── OrderItem.cs
│   └── Product.cs
│
├── Enums/
│   └── OrderStatus.cs
│
└── Program.cs
```

---

### Classes

- **Client** — representa o cliente do pedido (`name`, `email`, `birthDate`)
- **Order** — representa o pedido, contendo o momento, status, cliente e lista de itens. Possui os métodos `AddItem()`, `RemoveItem()` e `Total()`
- **OrderItem** — representa um item do pedido, com referência ao produto, quantidade e preço no momento da compra. Possui o método `SubTotal()`
- **Product** — representa o produto com nome e preço atual

### Enum

- **OrderStatus** — `PENDING_PAYMENT`, `PROCESSING`, `SHIPPED`, `DELIVERED`

---

## ⚙️ Como Executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/seu-repositorio.git

# Acesse a pasta do projeto
cd seu-repositorio

# Execute o projeto
dotnet run
```

---

## 💻 Exemplo de Uso

**Entrada:**
```
Enter client data
Name: Alex Green
Email: alex@gmail.com
Birth date (DD/MM/YYYY): 15/03/1985
Enter order data:
Status: Processing
How many items to this order? 2
Enter #1 item data:
Product name: TV
Product price: 1000.00
Quantity: 1
Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2
```

**Saída:**
```
ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00
```

---

## 🧠 Conceitos Aplicados

- Orientação a Objetos (POO)
- Associação e Composição entre classes
- Enumerações (`enum`)
- Coleções (`List<T>`)
- Padrão de responsabilidade única — cada classe calcula seu próprio subtotal

---

## 📄 Licença

Este projeto é de uso educacional.