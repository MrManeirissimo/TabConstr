using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelamentoConstrucao.Controlls
{
    public partial class EntryLine : UserControl
    {
        public int Index { get; set; }

        public EntryLine() {
            InitializeComponent();
            
        }

        public EntryLine(int index) : this() {
            Index = index;
            itemIndex_label.Text = $"Item{Index + 1}";
            Location = new Point(0, Index * Height);
        }

        public void LoadComboBoxes(object[] itemNames, object[] itemCategories)
        {
            itemName_comboBox.Items.AddRange(itemNames);
            itemCategory_comboBox.Items.AddRange(itemCategories);
        }
    }
}
