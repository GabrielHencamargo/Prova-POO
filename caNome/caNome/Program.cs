
using caNome;

Console.WriteLine("Digite o nome: ");
string nome = Console.ReadLine();
NomeProprio name = new NomeProprio(nome);
name.geranomepaper();
Console.WriteLine(name.Nome_paper);