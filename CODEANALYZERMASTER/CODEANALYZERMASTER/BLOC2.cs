using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class BracesFilter : ILineFilter
    {
        #region ILineFilter Members

        public bool MatchCondition(string line)
        {
            if (line.Length == 1)
            {
                if (line[0] == '{' || line[0] == '}')
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}

