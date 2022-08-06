using var bd = new CepDbContext();
Console.WriteLine("Inserir dados");
bd.Add(new CepModel{
    Cep="123456789",
    Estado="RS",
    Cidade="Porto Alegre",
    Bairro="Centro",
    Logradouro="Borges de Medeiros",

});
bd.SaveChanges();
// esse metodo salva de fato no banco de dados
Console.WriteLine("Consultar dados");
var todosCeps = bd.Ceps.OrderBy(c=>c.Cidade);
foreach (var cep in todosCeps)
{
    Console.WriteLine("$Id={cep.Id}, Cep={cep.Cep}, Cidade={cep.Cidade}");
} 
Console.WriteLine("Alterar dados");
var umcep = bd.Ceps.Find(2);
if (umcep != null)
{
    Console.WriteLine($"Id={umcep!.Id}, Cep={umcep.Cep}, Cidade={umcep.Cidade}");
    umcep.Cidade = "Canoas";
}
Console.WriteLine("Remover dados");
var outrocep = bd.Ceps.Find(2);
