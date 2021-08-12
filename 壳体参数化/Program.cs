using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SldWorks;

namespace ParameterizationApplication
{
    static class Parameterization
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

namespace EnclsParam
{
    class EnclsParam
    {
        public ushort EnclsLength;
        public ushort EnclsBreadth;
        public ushort EnclsHeight;

        public void SetEnclsLength(ushort EnclsLen)
        {
            EnclsLength = EnclsLen;
        }

        public void SetEnclsBreadth(ushort EnclsBre)
        {
            EnclsBreadth = EnclsBre;
        }

        public void SetEnclsHeight(ushort EnclsHei)
        {
            EnclsHeight = EnclsHei;
        }
    }

}

namespace SldWorksMacro
{
    class SldWorksMacro
    {
        public SldWorks.SldWorks swApp;
        public void OpenFile(string FileName,ushort FileType)
        {

        }
    }
}
