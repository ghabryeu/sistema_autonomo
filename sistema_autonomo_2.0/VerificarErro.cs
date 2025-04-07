using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo_2._0
{
    class VerificarErro
    {
        public bool VerificarNome(string retorno)
        {
            if (retorno == "")
            {
                MessageBox.Show("Não é possível prosseguir sem um nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(retorno, @"[^a-zA-Z\s]"))
            {
                MessageBox.Show("O nome contém caracteres inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool VerificarSenha(string retorno)
        {
            if (retorno == "")
            {
                MessageBox.Show("Não é possível prosseguir sem uma senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool VerificarID(string retorno)
        {
            if (retorno == "")
            {
                MessageBox.Show("Não é possível prosseguir sem um ID", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool VerificarIdPartida(string retorno)
        {
            if (retorno == null)
            {
                MessageBox.Show("Nenhuma partida foi selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
