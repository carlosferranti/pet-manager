# Anima.Inscricao

Serviço responsável por gerenciamento das informações do processo de inscrição..

## Descrição do projeto

Explique aqui as responsabilidades do seu projeto. Forneça contexto e adicione um link para qualquer referência com a qual os visitantes possam não estar familiarizados. Uma lista de recursos ou uma subseção de Contexto também podem ser adicionadas aqui.

## Visuais

Dependendo do que você está construindo, pode ser uma boa ideia incluir capturas de tela ou até mesmo um vídeo (você verá com frequência GIFs em vez de vídeos reais). Ferramentas como o ttygif podem ajudar, mas confira o Asciinema para um método mais sofisticado.

## Instalação

Dentro de um ecossistema particular, pode existir uma maneira comum de instalar coisas, como usar Yarn, NuGet ou Homebrew. No entanto, considere a possibilidade de que quem está lendo seu README é um novato e gostaria de mais orientação. Listar etapas específicas ajuda a remover ambiguidades e faz com que as pessoas usem seu projeto o mais rápido possível. Se ele só é executado em um contexto específico, como uma versão de linguagem de programação ou sistema operacional específico ou tem dependências que precisam ser instaladas manualmente, adicione também uma subseção Requisitos.

## Uso

Sinta-se livre para dar exemplos, e mostre o resultado esperado, se puder. É útil ter descrito o menor exemplo de uso que você pode demonstrar, enquanto fornece links para exemplos mais sofisticados se eles forem muito longos para incluir razoavelmente no README.

## Autenticação via Azure AD

O template já vem com a autenticação via Azure AD configurada. Pode ser necessário substituir os valores nos arquivos Yaml presentes no repositório dados-configurações com os Client IDs corretos para sua aplicação.

Para obter estas configurações com o time de Identidade, abra um chamado nos canais de atendimento da Ânima solicitando o cadastro de um novo client no Azure AD e explique o tipo de aplicação que você está desenvolvendo.

Em um cenário multitenant, você deve descomentar uma linha no Program.cs que chama o método de extensão `AddAzureAdMultitenantValidation`.

## Suporte

Diga às pessoas onde elas podem ir para obter ajuda. Pode ser qualquer combinação nome de pessoas responsáveis, uma sala de bate-papo, um endereço de e-mail, etc.

## Contribuindo

Para pessoas que possam precsiar de fazer alterações neste projeto, é útil ter alguma documentação sobre como começar. Talvez haja um script que eles devam executar ou algumas variáveis de ambiente que precisam definir. Torne essas etapas explícitas. Essas instruções também podem ser úteis para o seu futuro eu.

Você pode também documentar comandos para formatar o código ou para rodar testes. Essas etapas ajudam a garantir alta qualidade de código e reduzem a probabilidade de que as alterações quebrem algo inadvertidamente.
