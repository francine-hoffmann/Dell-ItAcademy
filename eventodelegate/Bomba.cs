public class Bomba
{
    private int tics;
    //contador de tics da bomba, contador interno, pois esta privado
    public int TempoLimite {get; init;}
    //pode ser inicializado , mas não pode ser alterado
    public bool Explodiu {get; private set;}
    // a propriedade de leitura é publica e a propriedade de escrita sera privada 
    public event EventHandler? FezBum;
    // esse cara pode ser null, so vai disparar se ele não for null
    // escolher um tipo delegate para o evento nesse caso eventhandler
    //eventHendler não retorna nada ( dois objetos como parametro - sender ,eventArgs)
    public Bomba(int limite)
    {
        TempoLimite = limite;
    }

    public void Tic()
    {
        tics++;
        if(tics >TempoLimite && !Explodiu)
        //se o numero de tics for maior que o tempolimite ela deve explodir
        {
            FazerBum();
            //ela so fazbum se esse metodo acontecer
        }
    }
    private void FazerBum()
    //disparar nosso evento
    {
        Explodiu = true;
        if (FezBum !=null)
        {
            FezBum(this,EventArgs.Empty);
            //this é quem explodiu, eu mesma (sender)
            // segundo é eventargs
        }
    }


}