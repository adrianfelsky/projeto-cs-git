int qtdCadastro = 5;
string[] nomes = new string[qtdCadastro];
string[] email = new string[qtdCadastro];
string[] cpf = new string[qtdCadastro];
string[] usuario = new string[qtdCadastro];
int opcao = 0;
int i = 0;

while (opcao != 3)
{
    Console.WriteLine("""
    
    1) Novo usuário:
    2) Buscar usuário:
    3) Sair.

    """);

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite seu nome completo: ");
            nomes[i] = Console.ReadLine().ToUpper();
            Console.Write("Informe seu e-mail: ");
            email[i] = Console.ReadLine().ToUpper();
            Console.Write("Insira o número do seu CPF: ");
            cpf[i] = Console.ReadLine();
            Console.Write("Defina o nome do seu usuário: ");
            usuario[i] = Console.ReadLine();
            Console.WriteLine("Cadastro concluído com sucesso!");
            opcao = 0;
            break;
        case 2:
            Console.WriteLine("Digite o nome do usuário que você deseja buscar: ");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Número inválido.");
            break;
    }
}
