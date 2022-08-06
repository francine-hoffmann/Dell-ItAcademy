using Microsoft.EntityFrameworkCore;

public class CepDbContext : DbContext
{
    public DbSet<CepModel> Ceps {get;set;} = null!;
    public string CaminhoDoBD {get;set;}

    public CepDbContext()
    {
        var diretorio = Environment.SpecialFolder.LocalApplicationData;
        var caminho = Environment.GetFolderPath(diretorio);
        Console.WriteLine(caminho);
        CaminhoDoBD = Path.Join(caminho, "ceps.db");
        Console.WriteLine(CaminhoDoBD);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={CaminhoDoBD}");
        optionsBuilder.EnableSensitiveDataLogging();
        //EnableSensitive vai fazer o entity framework fazer o log do que esta sendo feito no console
        
    }
}
// Code first banco de dados é gerado a partir do codigo e anotações das classes em projetos
// um framework de migração atualiza o banco a aprtir de alterções no modelo 
// dotnet ef migrations add CriacaoInicial
   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

