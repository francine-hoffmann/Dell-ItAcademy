public class Figura
// se o readonly estiver aqui é structy , as regras abaixo não se aplicam
{
    private readonly string nomeDaClasse;
    // isso vale no contesto do campo 
    //não é obrigado a inicializar , porem depois de inicializado não pode ser alterado
    public string NomeDaClasse => nomeDaClasse;
    
    public Figura()
    {
        nomeDaClasse = this.GetType().AssemblyQualifiedName ?? String.Empty;
        //metodo assembly retarna uma string anulavel  e estamos fazendo uma string que pode ser anulavel entaão colcoamos ?? posteriomente a string. empty 
        //que retorna uma string vazia
    }
    public void AlterarNome(string nome)
    {
        //erro de compilaçaõ
        //nomeDaClasse = banana
    }
}