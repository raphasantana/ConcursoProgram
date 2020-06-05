using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario2
{
    public partial class OpenPDF : Form
    {
        public OpenPDF()
        {
            InitializeComponent();
        }
        public OpenPDF(string pathfile)
        {
            InitializeComponent();

            axAcroPDF1.src = pathfile; // Abrir o arquivo em adobe de acordo com o pathfile passado.
        }

    }
}
