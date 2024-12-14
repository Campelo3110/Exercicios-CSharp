using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo13
    {
        public static void Main(string[] args)
        {

            string[] carros = {
                "Volvo", "BMW", "Ford", "Mazda", "Toyota", "Honda", "Chevrolet", "Nissan", "Hyundai", "Kia", 
                "Volkswagen", "Audi", "Mercedes-Benz", "Jaguar", "Porsche", "Lexus", "Subaru", "Dodge", "Jeep", "Ram",
                "GMC", "Buick", "Cadillac", "Acura", "Infiniti", "Mitsubishi", "Tesla", "Fiat", "Peugeot", "Citroën",
                "Alfa Romeo", "Renault", "Mini", "Suzuki", "Skoda", "Land Rover", "Bentley", "Rolls-Royce", "Maserati",
                "Ferrari", "Lamborghini", "Bugatti", "Pagani", "Koenigsegg", "Genesis", "Chrysler", "Hummer", "Pontiac",
                "Saturn", "Oldsmobile", "Saab", "Aston Martin", "McLaren", "Opel", "Seat", "Daihatsu", "Isuzu", "Lancia",
                "Mahindra", "Tata", "Perodua", "Proton", "Scion", "Smart", "SsangYong", "Geely", "Great Wall", "BYD",
                "Chery", "Foton", "Dongfeng", "Lifan", "Rivian", "Lucid", "Fisker", "Polestar", "VinFast", "MG", "Holden",
                "HSV", "Zotye", "Wuling", "Baojun", "Weilai (NIO)", "XPeng", "Li Auto", "Bollinger", "Canoo", "Faraday Future",
                "GAC", "Haval", "Wey", "Ora", "Karma", "Datsun", "Eagle", "Hudson", "Mercury", "Studebaker", "Packard",
                "AMC", "DeLorean", "Plymouth", "Tucker", "Daewoo", "Moskvitch", "ZAZ", "UAZ", "GAZ", "Marussia", "Spyker"
                };

            int contador = 1;

            foreach (string passando in carros)
            {
                Console.WriteLine(contador + " " + passando);
                contador++;
            }
        }
    }
}
