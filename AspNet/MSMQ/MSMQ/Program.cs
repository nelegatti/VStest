using System;
using System.Collections.Generic;
using System.Messaging;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMQ
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
        
    }
    public struct Payment
    {
        public string Payor, Payee;
        public int Amount;
        public string DueDate;
    }
}
