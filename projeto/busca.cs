int tam = 5;

string[] nomes = { "João", "Maria", "Carlos", "Ana", "Pedro" };
string[] emails = { "joao@email.com", "maria@email.com", "carlos@email.com", "ana@email.com", "pedro@email.com" };
string[] cpfs = { "123.456.789-00", "987.654.321-00", "456.789.123-00", "789.123.456-00", "321.654.987-00" };
string[] usernames = { "joao", "maria", "carlos", "ana", "pedro" };

while (true)
{
    Console.Write("\nBusca ou Exclusão? (b/e)\n >> ");
    string operacao = Console.ReadLine();

    if (operacao != "b" && operacao != "e")
    {
        Console.WriteLine("Opção inválida. Digite 'b' ou 'e'.");
        continue;
    }

    string operacaoNome = "";
    if (operacao == "b") operacaoNome = "Buscar";
    if (operacao == "e") operacaoNome = "Excluir";

    string opcao = "";
    bool menuValido = false;

    while (!menuValido)
    {
        Console.Write($"{operacaoNome} por nome(1), email(2), cpf(3) ou username(4)?\n >> ");
        opcao = Console.ReadLine();

        if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4")
        {
            menuValido = true;
        }
        else
        {
            Console.WriteLine("Opção inválida, tente novamente.");
        }
    }

    Console.Write("Digite o termo que deseja procurar:\n >> ");
    string busca = Console.ReadLine();
    Console.WriteLine($"Procurando por {busca} ...");

    bool usuarioEncontrado = false;
    int indiceEncontrado = -1;

    for (int i = 0; i < tam; i++)
    {
        if (nomes[i] == "")
        {
            continue;
        }

        if (opcao == "1" && nomes[i] == busca) { usuarioEncontrado = true; indiceEncontrado = i; }
        if (opcao == "2" && emails[i] == busca) { usuarioEncontrado = true; indiceEncontrado = i; }
        if (opcao == "3" && cpfs[i] == busca) { usuarioEncontrado = true; indiceEncontrado = i; }
        if (opcao == "4" && usernames[i] == busca) { usuarioEncontrado = true; indiceEncontrado = i; }

        if (usuarioEncontrado == true)
        {
            break;
        }
    }

    if (usuarioEncontrado == true)
    {
        Console.WriteLine($"Usuário encontrado: {nomes[indiceEncontrado]}, {emails[indiceEncontrado]}, {cpfs[indiceEncontrado]}, {usernames[indiceEncontrado]}");

        if (operacao == "e")
        {
            Console.Write("Deseja excluir este usuário? (s/n)\n >> ");
            if (Console.ReadLine() == "s")
            {
                nomes[indiceEncontrado] = "";
                emails[indiceEncontrado] = "";
                cpfs[indiceEncontrado] = "";
                usernames[indiceEncontrado] = "";
                Console.WriteLine("Usuário excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Exclusão cancelada.");
            }
        }
    }
    else
    {
        Console.WriteLine("Usuário não encontrado.");
    }
}
