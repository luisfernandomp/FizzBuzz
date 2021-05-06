using System.Collections.Generic;

namespace DesafioDojo
{
    public class Pizza
    {
        public List<Sabores> Sabor { get; set; }
        public Pizza()
        {
            Sabor = new List<Sabores>();   
        }
    }
}