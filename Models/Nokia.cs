
namespace ProjetoSistemaCelular.Models
{
    public class Nokia : SmartPhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando aplicativo {nomeApp} no SmatPhone Nokia..");

        }
    }
}