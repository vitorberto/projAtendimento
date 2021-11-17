using System;
using System.Collections.Generic;
using System.Text;

namespace ProjAtendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        public Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }

        public Senhas()
        {
            FilaSenhas = new Queue<Senha>();
            ProximoAtendimento = 1;
        }

        public void Gerar()
        {
            Senha senha = new Senha(ProximoAtendimento);
            ProximoAtendimento += 1;
            FilaSenhas.Enqueue(senha);
        }
    }
}
