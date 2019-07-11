using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.PresentationsExceptions
{
    public class CorreoSinDestinatarioException : Exception

    {
        public CorreoSinDestinatarioException(string message) : base(message)
        {
        }
    }
}
