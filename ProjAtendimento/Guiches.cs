using System;
using System.Collections.Generic;
using System.Text;

namespace ProjAtendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void Adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
    }
}
