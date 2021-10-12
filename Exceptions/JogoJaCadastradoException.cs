using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogojaCadastradoException : Exception
    {

        public JogojaCadastradoException()
            : base("Este jogo já está cadastrado")
        { }
    }
}
