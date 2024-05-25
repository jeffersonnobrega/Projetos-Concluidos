# Documentação do Programa de Consentimento de Cookies

Este documento descreve o funcionamento e a finalidade do programa de consentimento de cookies desenvolvido em HTML, CSS e JavaScript.

## Introdução

O programa tem como objetivo informar os usuários sobre o uso de cookies no site e solicitar seu consentimento para tal uso, conforme exigido pelas regulamentações de privacidade online.

## Estrutura do Programa

O programa consiste em três arquivos principais:

- **HTML (index.html)**: Este arquivo contém a estrutura da página web e inclui os elementos necessários para exibir a mensagem de cookies e os botões de aceitação.
- **CSS (style.css)**: Este arquivo define o estilo visual da mensagem de cookies e dos botões na página. Ele também importa a fonte 'Poppins' do Google Fonts para uso no texto.
- **JavaScript (cookies.js)**: Este arquivo contém o script que controla o comportamento da mensagem de cookies. Ele define a lógica para exibir ou ocultar a mensagem com base no consentimento do usuário.

## Funcionalidades

O programa realiza as seguintes funcionalidades:

- **Exibição da Mensagem de Cookies**: Quando um usuário acessa o site, a mensagem de cookies é exibida na parte inferior da página.
- **Aceitação de Cookies**: O usuário pode aceitar o uso de cookies clicando no botão "Aceito". Quando isso acontece, uma variável chamada `localStorage.lgpd` é definida como "sim" para indicar que o consentimento foi dado.
- **Armazenamento do Consentimento**: O consentimento do usuário é armazenado localmente no navegador usando a API `localStorage`. Isso permite que o site reconheça se o usuário já consentiu com o uso de cookies durante visitas subsequentes.
- **Ocultação da Mensagem de Cookies**: Se o usuário já tiver aceitado os cookies anteriormente, a mensagem de cookies não será exibida novamente em visitas futuras ao site.

## Utilização

Para utilizar o programa, os desenvolvedores devem incluir os arquivos HTML, CSS e JavaScript em seus projetos. Eles podem modificar o conteúdo da mensagem de cookies e o estilo visual conforme necessário para se adequar ao design do site.

## Considerações de Privacidade

Este programa foi projetado para garantir conformidade com regulamentações de privacidade online, permitindo que os usuários tomem decisões informadas sobre o uso de cookies no site.
