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
        public ComboBox CategoryComboBox => itemCategory_comboBox;
        public ComboBox ProductComboBox => itemName_comboBox;
        public TextBox ProductQuantityTextBox => itemQuantity_textBox;
        public TextBox TotalAmountTextBox => totalAmount_textBox;
        public TextBox UnitPriceTextBox => unitPrice_textBox;
        public TextBox DateTextBox => textBox_dateTime;

        public double TotalCost => GetUnitPrice() * GetQuantity();
        public double UnitPrice => GetUnitPrice();
        public uint Quantity => GetQuantity();

        public int Index { get; set; }

        public EntryLine() {
            InitializeComponent();
            
        }

        public EntryLine(int index) : this() {
            Index = index;
            itemIndex_label.Text = $"Item {Index + 1}";
            Location = new Point(0, Index * Height);
        }

        public void LoadComboBoxes(object[] itemNames, object[] itemCategories)
        {
            itemName_comboBox.Items.AddRange(itemNames);
            itemCategory_comboBox.Items.AddRange(itemCategories);
        }

        private double GetUnitPrice() {
            if(double.TryParse(unitPrice_textBox.Text, out double value)){
                return value;
            }

            return default;
        }

        private uint GetQuantity () {
            if(uint.TryParse(itemQuantity_textBox.Text, out uint value)) {
                return value;
            }

            return default;
        }
    }
}
