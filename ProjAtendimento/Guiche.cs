using System;
using System.Collections.Generic;
using System.Text;

namespace ProjAtendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int id)
        {
            Atendimentos = new Queue<Senha>();
            Id = id;
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            try
            {
                Senha senha = filaSenhas.Dequeue();
                senha.DataAtend = DateTime.Now.Date;
                senha.HoraAtend = DateTime.Now;

                atendimentos.Enqueue(senha);
                return true;
            } catch(Exception)
            {
                return false;
            }
        }
    }
}
