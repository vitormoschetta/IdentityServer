# Conceitos

### Single Sign-On 
Esquema de autenticação/login que permite ao usuário compartilhar credenciais de acesso de uma aplicação com diversas outras aplicações. 

### Federation Gateway
Processo de login através de um provedor externo. Ex: Logar com suas redes sociais ou conta do Google.

### Single Sign-Out
Logout/sair de todas as aplicações, ou seja, logout integrado.

# IdentityServer

Endpoint para consultar configurações identity server:

https://localhost:5001/.well-known/openid-configuration


## O que o IdentityServer nos Oferece que o Identity não faz?

O Identityserver nos possibilita controlar não só a autenticação e autorização, mas também controlar/determinar a quais APIs um determinado usuário poderá acessar. 
