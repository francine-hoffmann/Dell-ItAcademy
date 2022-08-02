public class Correntista
{
    public string Nome {get; set;} = String.Empty;
    public string Cpf { get; init;} = null!;
    private int anoNascimento;
    public int AnoNascimento 
    {
        get => anoNascimento;
        set => anoNascimento = value;
        // para alteração de value conta.nascimento = 2000
    }

    //string empty estou inicializando a  propriedade como vazia
    //PROPRIEDADE DE LEITURA QUE PODE SER INICILALIZADA
    
}