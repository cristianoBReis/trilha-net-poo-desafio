namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }        
         protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }


        public Smartphone(string modelo, string numero,  string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;            
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

         public  void  ModeloCelular()
         {
            Console.WriteLine($"Modelo celular: {Modelo}");

         }
        public void  NumeroCelular()
         {
            Console.WriteLine($"Numero do celular: {Numero}");
         }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}