using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class CLOC2:ILineFilter{
    
        #region ILineFilter Members

        public bool MatchCondition(string line)
        {
            return line.StartsWith("//");
        }
        #endregion
    }
}

