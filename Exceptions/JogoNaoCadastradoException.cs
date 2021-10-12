using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoexception : Exception
    {

        public JogoNaoCadastradoexception()
            : base("Este jogo já está cadastrado")
        { }
    }
}
