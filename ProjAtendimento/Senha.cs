using System;
using System.Collections.Generic;
using System.Text;

namespace ProjAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public Senha(int id)
        {
            DataGerac = DateTime.Now.Date;
            HoraGerac = DateTime.Now;
            this.id = id;
        }

        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public string DadosParciais()
        {
            return $"{id} - {DataGerac.ToShortDateString()} - {HoraGerac:HH:mm:ss}";
        }

        public string DadosCompletos()
        {
            return $"{id} - {DataGerac.ToShortDateString()} - {HoraGerac:HH:mm:ss} - {dataAtend.ToShortDateString()} - {HoraAtend:HH:mm:ss}";
        }
    }
}
