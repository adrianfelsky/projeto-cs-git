// busca
string opcao = "";
string busca = "";
int tam = 5;
bool exit = false;

string[] nomes = { "João", "Maria", "Carlos", "Ana", "Pedro" };
string[] emails = { "joao@email.com", "maria@email.com", "carlos@email.com", "ana@email.com", "pedro@email.com" };
string[] cpfs = { "123.456.789-00", "987.654.321-00", "456.789.123-00", "789.123.456-00", "321.654.987-00" };
string[] usernames = { "joao", "maria", "carlos", "ana", "pedro" };

while (!exit)
{
    Console.Write("Buscar por nome(1), email(2), cpf(3) ou username(4)?\n >> ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite o nome do usuário:\n >> ");
            busca = Console.ReadLine();
            exit = true;
            break;
        case "2":
            Console.Write("Digite o email do usuário: \n >> ");
            busca = Console.ReadLine();
            exit = true;
            break;
        case "3":
            Console.Write("Digite o CPF do usuário: \n >> ");
            busca = Console.ReadLine();
            exit = true;
            break;
        case "4":
            Console.Write("Digite o username de usuário: \n >> ");
            busca = Console.ReadLine();
            exit = true;
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

}

switch (opcao, busca)
{
    case ("1", _):
        Console.WriteLine($"Buscando por {busca} ...");
        for (int i = 0; i < tam; i++)
        {
            if (nomes[i] == busca)
            {
                Console.WriteLine($"Usuário encontrado: {nomes[i]}, {emails[i]}, {cpfs[i]}, {usernames[i]}");
                break;
            }
            else if (i == tam - 1)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
        break;

    case ("2", _):
        Console.WriteLine($"Buscando por {busca} ...");
        for (int i = 0; i < tam; i++)
        {
            if (emails[i] == busca)
            {
                Console.WriteLine($"Usuário encontrado: {nomes[i]}, {emails[i]}, {cpfs[i]}, {usernames[i]}");
                break;
            }
            else if (i == tam - 1)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        break;
    case ("3", _):
        Console.WriteLine($"Buscando por {busca} ...");
        for (int i = 0; i < tam; i++)
        {
            if (cpfs[i] == busca)
            {
                Console.WriteLine($"Usuário encontrado: {nomes[i]}, {emails[i]}, {cpfs[i]}, {usernames[i]}");
                break;
            }
            else if (i == tam - 1)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        break;
    case ("4", _):
        Console.WriteLine($"Buscando por {busca} ...");
        for (int i = 0; i < tam; i++)
        {
            if (usernames[i] == busca)
            {
                Console.WriteLine($"Usuário encontrado: {nomes[i]}, {emails[i]}, {cpfs[i]}, {usernames[i]}");
                break;
            }
            else if (i == tam - 1)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        break;
}
