# Conceitos

### Single Sign-On 
Esquema de autenticação/login que permite ao usuário compartilhar credenciais de acesso de uma aplicação com diversas outras aplicações. 

### Federation Gateway
Processo de login através de um provedor externo. Ex: Logar com suas redes sociais ou conta do Google.

### Single Sign-Out
Logout/sair de todas as aplicações, ou seja, logout integrado..

## IdentityServer vs AspNetIdentity
O IdentyServer controla o acesso as APIs e o AspNetIdentity é para gerenciar os usuários.

Com o IdentityServer podemos controlar/determinar a quais APIs um determinado usuário/cliente/app poderá acessar, através de seus escopos informados em um Jason Web Token (JWT).




# IdentityServer

Endpoint para consultar configurações identity server:

https://localhost:5001/.well-known/openid-configuration


 
