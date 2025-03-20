This is a readme for Cortana a notification assist to help you on your day! And not an AI used to hack Covenant battle network!

2025/03/20 - This is the first commit, Cortana is working fine, needs a Maria DB database and need an update on code, API to make the connections with your social Network!



![look_right](https://github.com/user-attachments/assets/1a7fa5db-6e04-478c-adb3-b015b1d9fb4e)

******************************************* English !!! Attention !!! English ****************************************************************************************

This Cortana is very diferent from the windows assistant who gave the character a bad reputation, this is not a persinal assistant, more like a virtual pet, a big tamagochi encapsuled in a Super Deformed Cortana Body, you keep in your second or third monitor (I just have 2) and it stay there in idle, breathing (yes she has breathing animation), she is in the middle of lots of icons of social networks, games store, and instant messengers. When someone send you a message or that game you wanted a long time in your wishlist enters on sale, the icon blinks and Cortana look toward it. Nothing fully operational, still need some code on API to conect with apps and social networks. She is made in .NET 4.7.2 and i wanna keep that way for now.(yes i still use old windows, i don't live in a developed imperialist country so my computer is old, and i like to keep it old so more people can use!). The real advantage and purpose is you don't have to take your smartphone and turn on to see where the notification is comming!

                                    Database !!!! Attention !!!! Database

Basicaly Cortana is a windows form with some nice Sounds and graphics, to make her work you gonna need a MySQL database, you can edit in the Login form: 

public partial class LoginForm : Form
    {
        // String de Conexão com o banco de dados
        string connectionString = "Server=localhost;Database=otames_db;Uid=root;Pwd=;";

I utilized the database from XAMPP for pratical reasons! And also i want to use a Database in her for future development and aditions to the assistant!



************************************************************* PT-BR !!! Atenção !!! PT-BR ***************************************************************************


                                                !!!Atenção!!!
Esta Cortana, diferentemente do assistente do windows com que fez ela pegar má fama, não é um assistente pessoal, é mais como um bichinho virtual, um tamgochi grande que você deixa em atividade no seu segundo ou terceiro monitor (eu só tenho 2 não sei quantos você tem!), ela fica parada ociosa e respirando (sim eu fiz animação dela respirando), ela fica no meio de um monte de icones de redes sociais, jogos (Steam, epic, gog) e mensageiros (Whatsapp, instagram direct, etc) quando alguma de suas redes sociais ou seus apps de mensagem notificam, ela reage mostrando de onde vem a notificação, não é nada muito complexo ou operacional, ainda falta o código da API para que ela conecte com as plataformas e redes sociais. Ela é feita em .NET 4.7.2 eeu quero manter assim por enquanto. (sim, eu uso windows velho e meu computador é antigo, eu não moro em um país imperialista desenvolvido então meu computador é velho! E eu quero manter assim, para que mais pessoas usem!). A real vantagem e propósito desta Cortana é não ter que pegar o seu smartphone e ter que ficar ligando tela, toda vez que quer saber de qual app vem a notificação!

                          Banco de Dados        !!!! Atenção !!!!           Banco de Dados

Basicamente Cortana é um WindowsForm, com alguns barulinhos e uns gráficos bonitos, pra fazer ela funcionar, você vai precisar de um banco de dados MySQL, você pode editar este trecho de código no LoginForm:

public partial class LoginForm : Form
    {
        // String de Conexão com o banco de dados
        string connectionString = "Server=localhost;Database=otames_db;Uid=root;Pwd=;";

Eu usei um banco de dados do XAMPP por razões práticas! E também quero usar um banco de dados em seu futuro desenvolvimento e adições para a assistente!



