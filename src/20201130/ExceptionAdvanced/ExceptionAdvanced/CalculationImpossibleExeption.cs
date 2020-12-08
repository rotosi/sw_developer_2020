using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAdvanced
{
    class CalculationImpossibleExeption : Exception
    {
        private string _invialidParameter;
        public CalculationImpossibleExeption(string invalidParamenter)
            : base ()
        {
            _invialidParameter = invalidParamenter;
        }

        public override string Message
        {
            get { return $"Paramenter '{_invialidParameter}' hat einen ungültigen Inhalt."; }
        }
    }

}
