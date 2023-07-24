using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5ex1
{
    public class Catalog
    {
        private string numeClasa;
        private List<Elev> listaElevi = new List<Elev>();
        
        public Catalog(string numeClasa)
        {
            this.numeClasa = numeClasa;
        }


        public void InscrieElev(Elev elev)
        {
            if (!listaElevi.Contains(elev))
            {
                listaElevi.Add(elev);
               
            }
        }

        public bool EsteElev(Elev elev)
        {
            return listaElevi.Contains(elev);
        }

        public string GetDescription()
        {
            StringBuilder descriere = new StringBuilder();
            descriere.Append($"Clasa:  {numeClasa} \n");
            descriere.Append($"Elevi: ");
            if (listaElevi.Count > 0)
            {
                foreach (var elev in listaElevi)
                {
                    descriere.AppendJoin(" ,", $"{elev.GetDescription()}, ");
                }
            }

            else
            {
                descriere.Append("fara elevi");
            }

            return descriere.ToString();
        }

       public string GetPremiantul()
        {
            
            Elev premiant= listaElevi.FirstOrDefault();

            foreach (var elev in listaElevi)
            {
                if (elev.GetMedia() > premiant.GetMedia())
                {
                    premiant = elev;
                }
            
            }

             return premiant.GetDescription();
        }
        
    }
}
