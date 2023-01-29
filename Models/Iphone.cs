namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        
        public Iphone(string nome, string modelo, string imei, int memoria): base(nome, modelo, imei, memoria)
        {
            
        }
         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado no Iphone.");
        }
    }
}