public class Pessoa : IEquatable<Pessoa>, ICloneable
//primeira é a classe as outras são interfaces
{
    private string nome;
    private int idade;
    public Pessoa (string n, int i)
    {
        nome = n;
        idade = i;
    
    }
    public string Nome
    {
        get {return nome;}

    }
    public int Idade 
    {
        get{return idade;}
    }

    public object Clone()
    // NÃO COPIA REFENCIAS , COPIA DADOS
    {
       Pessoa other = (Pessoa) MemberwiseClone();
       // gerou uma copia de nome e idade falta a copia profunda ou deep copy
       other.nome = new String(nome);
       return other;
    }

    public bool Equals(Pessoa? other)
    //verifica se a outra pessoa é igual a pessoa
    {
        if(other == null)
        // resolover o problema que pode ser null pessoa
        return false;
        return (nome == other.nome && idade == other.idade);
        //this é referencia pra classe que esta sendo utilizada
    }

    public override bool Equals(object? obj)
    {
        Pessoa? other = obj as Pessoa; 
        return Equals(other);
    }
    public override int GetHashCode()
    {
        return nome.GetHashCode() + idade.GetHashCode();
    }
}
