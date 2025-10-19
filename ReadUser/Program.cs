Console.Write("Digite seu nome: ");
string nome = Console.ReadLine().Trim();
while (string.IsNullOrEmpty(nome))
{
    Console.Write("Nome inválido. Por favor, digite seu nome novamente: ");
    nome = Console.ReadLine().Trim();
}
nome = nome.Length > 0 ? nome : "Usuário";
Console.WriteLine($"Olá, {nome}! Seja bem-vindo.");
Console.ReadLine();
