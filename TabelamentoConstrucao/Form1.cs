using TabelamentoConstrucao.Controlls;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System;

namespace TabelamentoConstrucao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            constructionControl.SelectedIndex = 0;

            //List<EntryLine> entries = new List<EntryLine>();
            //for (int i = 0; i < 10; i++) {
            //    entries.Add(new EntryLine(i));
            //    entries[i].LoadComboBoxes(
            //        new string[] { "Cano 15mm", "Cano 30mm", "Cano 100mm"},
            //        new string[] {"Hidraulica", "Eletrica", "Esgoto"}
            //    );

            //    constructionControl.SelectedTab.Controls.Add(entries[i]);
            //}
        }
    }
}
