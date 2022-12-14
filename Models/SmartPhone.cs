

namespace ProjetoSistemaCelular.Models
{
    public abstract class SmartPhone
    {

        public SmartPhone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }
        
        
        public virtual void Ligar() {
            Console.WriteLine($"Ligando...");
            
        }
        public virtual void ReceberLigacao(){
            Console.WriteLine($"Recebendo ligação...");
            
        }
        public abstract void InstalarAplicativo(string nomeApp);
        
        
    }
}