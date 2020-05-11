using System;
using System.Threading;

namespace Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
