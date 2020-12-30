using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class AllLOC2 : SCLOC
    {

        #region ILineCounter Members

        public int Lines
        {
            get;
            set;
        }

        public void OnCodeLine(string line)
        {
            this.Lines++;
        }

        public void Reset()
        {
            Lines = 0;
        }
        #endregion
    }
}

