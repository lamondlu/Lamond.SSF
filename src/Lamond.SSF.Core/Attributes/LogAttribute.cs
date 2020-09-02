using System;
using System.Collections.Generic;
using System.Text;

namespace Lamond.SSF.Core.Attributes
{

    public class LogAttribute : Attribute
    {
        private string _message;

        public LogAttribute(string message)
        {
            _message = message;
        }

        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
