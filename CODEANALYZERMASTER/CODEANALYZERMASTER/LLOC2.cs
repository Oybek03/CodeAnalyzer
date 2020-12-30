using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEANALYZERMASTER
{
    class LLOC2
    {
        public LLOC2() {

            counters.Add(LOCLines);
            counters.Add(SCLOCLines);
            counters.Add(BLOCLines);
            counters.Add(NCLOCLines);
            counters.Add(CLOCLines);
        }
        #region ILineCounter Members
        List<SCLOC> counters = new List<SCLOC>();

        AllLOC2  LOCLines = new AllLOC2();
        FilterCounter SCLOCLines = new FilterCounter() { Filter = new NCLOC2() };
        FilterCounter BLOCLines = new FilterCounter() { Filter = new BracesFilter() };
        FilterCounter NCLOCLines = new FilterCounter { Filter = new UsingImportFilter() };
        FilterCounter CLOCLines = new FilterCounter { Filter = new CLOC2() };
        public void OnCodeLine(string line) {
            foreach (var counter in counters) {
                counter.OnCodeLine(line);
            }

        }
        public int LOC {
            get {
                return LOCLines.Lines;
            }
        }
        public int SCLOC {
            get {
                return SCLOCLines.Lines;
            }
        }
        public int BLOC {
            get {
                return BLOCLines.Lines;
            }
        }
        public int NCLOC {
            get {
                return NCLOCLines.Lines;
            }
        }
        public int CLOC {
            get {
                return CLOCLines.Lines;
            }
        }
        public int NormalLines {
            get {
                return LOCLines.Lines - SCLOCLines.Lines - BLOCLines.Lines - NCLOCLines.Lines - CLOCLines.Lines;
            }
        }
       

        #endregion

        #region ILineCounter Members



        #endregion
    }
}

   
