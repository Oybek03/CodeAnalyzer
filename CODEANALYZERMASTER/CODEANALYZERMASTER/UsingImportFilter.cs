using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class UsingImportFilter : ILineFilter
    {
        #region ILineFilter Members

        public bool MatchCondition(string line)
        {
            if (line.StartsWith("using") && line[line.Length - 1] == ';')
            {
                return true;
            }
            if (line.StartsWith("import"))
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
