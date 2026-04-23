// parte de listagem e exibição.
using System;

string[] user = ["João", "Maria", "Pedro", "Ana", "Lucas"]; // array de nomes de usuários cadastrados.
string[] cpf = ["123.456.789-00", "987.654.321-00", "111.222.333-44", "555.666.777-88", "999.000.111-22"]; // array de cpfs cadastrados.
string[] nomeCliente = ["João Silva", "Maria Souza", "Pedro Oliveira", "Ana Santos", "Lucas Pereira"]; // array de nomes de clientes cadastrados.
string[] email = ["everson@gmail.com", "adrian@yahoo.com", "zezinho@outlook.com"]; // array de e-mails cadastrados.




for (int i = 0; i < user.Length; i++) // listagem e exibição dos nomes de usuários cadastrados.
{
    Console.WriteLine($"Usuários cadastrados: {user[i]}");
}


Console.WriteLine("""



    *



    """);


for (int i = 0; i < email.Length; i++) // listagem e exibição dos e-mails cadastrados.
{
    Console.WriteLine($"E-mails cadastrados: {email[i]}");
}


Console.WriteLine("""



    *



    """);


for (int i = 0; i < cpf.Length; i++) // listagem e exibição dos cpfs cadastrados.
{
    Console.WriteLine($"CPFs cadastrados: {cpf[i]}");
}


Console.WriteLine("""



    *



    """);


for (int i = 0; i < nomeCliente.Length; i++) // listagem e exibição dos nomes de clientes cadastrados.
{
    Console.WriteLine($"Nomes cadastrados: {nomeCliente[i]}");
}
