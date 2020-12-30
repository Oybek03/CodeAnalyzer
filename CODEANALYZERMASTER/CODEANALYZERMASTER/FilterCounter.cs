using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class FilterCounter : SCLOC
    {
        #region ILineCounter Members

        public int Lines
        {
            get;
            set;
        }

        public void OnCodeLine(string line)
        {
            if (this.Filter.MatchCondition(line))
            {
                this.Lines++;
            }
        }
        public void Reset()
        {
            Lines = 0;
        }
        #endregion
        public ILineFilter Filter { get; set; }
    }
}
