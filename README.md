# Bag-And-Shop-App API

Bem-vindo à documentação da **Bag-And-Shop-App API**!

Esta API foi desenvolvida para gerenciar as operações de usuários de um sistema de RPG de mesa, visando dar suporte em campanhas. Ela permite a criação, leitura e gerenciamento de items e dados referentes ao inventário e loja que os usuários podem interagir.

---

## Começando

Para começar a usar a API, você precisará ter o endpoint base.

**Endpoint Base:** `[URL-DO-SEU-SERVIDOR]`

---

## Autenticação

Bearer Token
---

## getAllUsers
| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **GET** | `/api/user` | Retorna uma lista com todos os usuários. |

#### Resposta de Sucesso (Status `200 OK`)
```json
{
    "error": false,
    "message": "",
    "data": [
        {
            "id": number,
            "username": string,
            "email": string
        }
    ]
}
````
#### Resposta de Falha (Status `500 Internal Server Error`)
```json
{
    "error": true,
    "message": string,
}
````



## register
| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **POST** | `/api/user/register` | Cadastra um novo usuário. |


#### Request 
```json
{
    "username": string, //Nome de usuário desejado.
    "email": string,    //Endereço de e-mail único do usuário.
    "Password": string  //Senha forte para o novo usuário.
}
````
#### Resposta de Sucesso (Status `201 Created`)
```json
{
    "error": false,
    "message": "Usuário cadastrado com sucesso",
    "data": {
        "id": 6,
        "username": "Claudio",
        "email": "Claudinho@gmail.com"
    }
}
````
#### Resposta de Falha (Status `400 Bad Request`)
```json
{
    "error": true,
    "message": string,
}
````




