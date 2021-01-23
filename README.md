# Conceitos

É necessário, primeiramente, entender um conceito básico sobre Cookie, Session e JWT. Você pode ler esta breve introdução [Aqui] (https://github.com/vitormoschetta/Help-AutenticacaoAutorizacao).


IdentityServer4 é um esquema de autenticação que implementa os padrões OAuth2.0 e OpenId Connect.


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


### JWT vs Cookies (Correto: JWT vs Session) - História

Diferente do LocalStorage e SessionStorage, Cookies podem ser armazenados por tempo indeterminado, permanecendo salvo mesmo ao fechar o browser. Graças aos Cookies podemos salvar nossas crendencias no navegador, e abrir nossas redes sociais no dia seguinte sem precisar informar o login novamente.

Como podemos observar, **Cookies nao estão diretamente ligados à autenticação**, mas na persistência de informações no browser. Acontece que essa capacidade de persistência duradoura do Cookie o associou à **autenticação baseada em Session**.

Neste formato de autenticação os dados do usuário não estão no Cookie, mas em uma Session na memória do Server. Esta session é criada com um
ID de identificação, e é justamente este ID que é passado para o Client persistir no Cookie. Logo o Cookie possui apenas o ID da Session que 
contém os dados do Usuário autenticado.

Perceba que na autenticação com Cookie/Session é necessário manter um estado na memória do Servidor. Por isso usamos o termo **autenticação com estado**.

Dentro do escopo de autenticação, a função do Cookie é similar ao JWT, porém, possuem casos de uso diferente.

Hoje em dia temos requisitos diferentes como aplicativos híbridos, SPA e Api's. Que podem depender de vários back-ends (divididos em servidores de autenticação de micro-services, bancos de dados, servidores de processamento de imagem, etc.). Nestes tipos de cenários mais elaborados, o cookie vai ser uma má decisão, pois a sessão que obtemos de um servidor não corresponde a do outro servidor.

Por este motivo foi necessário o desenvolvimento de um outro método de autenticação, **sem estado**, onde os dados do usuário pudessem trafegar em cada solicitação ao invés de ser mantida na memória do servidor, afinal, essa aplicação precisará "conversar" com diversos servidores.

A grande questão aqui é: Como saber que este Token que trafega com os dados do Usuário via HTTP é válido? Como os Servidores poderiam validar esta solicitação? 

É aí que entra o **Secret**, a Chave. O JWT é montado (ele não é criptografado, pois é um padrão aberto) a partir das informações/claims do Usuário + sequência de caracteres conhecidos como Secret/Chave. Qualquer um pode decifrar o conteúdo de um JWT, mas apenas quem possui esta Chave pode validá-lo.

Dá-se o início do  **OpenId Connect**, que é a capacidade de permitir que os usuários sejam autenticados por sites cooperantes (conhecidos como partes confiáveis ou RP) usando um serviço de autorização de terceiros.  

Outro conceito que passou a ser muito usado foi o **Federation Gateway**, que é exatamente a capacidade de se efetuar o login através de 
um provedor externo, como por exemplo, logar com suas redes sociais ou conta do Google.



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





 
