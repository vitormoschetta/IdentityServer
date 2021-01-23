# Conceitos

**IdentityServer4** é um esquema de autenticação que implementa os padrões OAuth2.0 e OpenId Connect.

É necessário, primeiramente, entender um conceito básico sobre Cookie, Session e JWT. 

Você pode ler esta breve introdução [Aqui](https://github.com/vitormoschetta/Help-AutenticacaoAutorizacao). Ela será de suma importância para prosseguir, pois contém conceitos também de **OpenId Connect** e **Federation Gateway**.



### Single Sign-On (SSO)
Login integrado. O SSO dá acesso a muitos aplicativos inserindo credenciais apenas uma vez.

### Single Sign-Out
Logout/sair de todas as aplicações, ou seja, logout integrado..


### OAuth2
O OAuth 2 é um framework de segurança. Descreve como permitir o acesso, limitado, aos dados dos usuários em um client, através do protocolo HTTP.  
Ele delega a autenticação a um server que hospeda a conta do usuário. E especifica como compartilhar as informações de autorização a outros aplicativos. Esssas informações de Autenticação e Autorização trafegam através de Web Tokens. 


### Bearer authentication 
Também conhecido como token authentication, é um Schema para autenticação HTTP (RC6750). O token deve ser uma _string_, que
representa uma autorização do Server emitida para o Client.


### JSON Web Token (JWT) 
O JSON Web Token (JWT) é o Token que acompanha o Bearer. Ele é um padrão aberto, definido pela RFC 7519. Estabelece uma maneira compactada para transmitir um objeto JSON, garante a segurança das informações e é utilizado para trafegar dados de autenticação entre dois clientes.

Ele é regido por um conjunto bem definido de instruções tanto para a emissão quanto para validação. O token possui as claims que serão usadas por um client para limitar o acesso do usuário.


### IdentityServer vs AspNetIdentity
O IdentyServer controla o acesso as APIs e o AspNetIdentity é para gerenciar os usuários.

Com o IdentityServer podemos controlar/determinar a quais APIs um determinado usuário/cliente/app poderá acessar, através de seus escopos informados em um Jason Web Token (JWT).


# Papeis / Atores
#### Resource Owner 
Dono do Recurso / Usuário

#### Client
Aplicação que consome o Recurso.

#### Resource Server
Conteúdo 

#### Authorization Server
Servidor de Autorização OAuth






## Referências:
<https://www.brunobrito.net.br/jwt-cookies-oauth-bearer/#:~:text=Bearer%20authentication%20(tamb%C3%A9m%20conhecido%20como,para%20autentica%C3%A7%C3%A3o%20HTTP%20(RC6750).&text=O%20Bearer%20identifica%20recursos%20protegidos,Server%20emitida%20para%20o%20client.>


# IdentityServer

Endpoint para consultar configurações identity server:

https://localhost:5001/.well-known/openid-configuration





 
