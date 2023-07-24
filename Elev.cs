using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5ex1
{
    public class Elev
    {
        private string prenume;
        private string nume;
        private List<int> listaNote = new List<int>();
        private Catalog catalog = null;
        

        public Elev( string prenume, string nume)
        {
            this.prenume = prenume;
            this.nume = nume;
            
        }

        public void AdaugaNota(int nota)
        {
            listaNote.Add(nota);
        }

        public void StergeNota(int nota)
        {
            listaNote.Remove(nota);
        }


        public string GetNote()
        {
            StringBuilder descriere = new StringBuilder();
            descriere.Append($"Elev:  {nume} {prenume} \n");
            descriere.Append($"Note: ");
            if (listaNote.Count > 0)
            {
                foreach (var nota in listaNote)
                {
                    descriere.AppendJoin(' ', $"{nota},");
                }
            }

            else
            {
                descriere.Append("fara note");
            }

            return descriere.ToString();
        }

        public string GetDescription()
        {
            return $"{prenume} {nume} ";
        }



       /* public double  GetMedia()
        {
            double media = 0;
            if (listaNote.Count > 0)
            {
                foreach (var nota in listaNote)
                {
                    media = media + nota;

                }
                media = media/listaNote.Count;

            }
            return media;
        }
        */

        public double GetMedia()
        {
            return listaNote.Average();
        }
        
    }
}
