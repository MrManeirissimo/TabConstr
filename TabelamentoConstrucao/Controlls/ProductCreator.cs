using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelamentoConstrucao.App;

namespace TabelamentoConstrucao.Controlls {
    public partial class ProductCreator : Form {
        public ProductCreator() {
            InitializeComponent();
        }

        private void ProductCreator_Load(object sender, EventArgs e) {
            comboBox_category.Items.AddRange(DBAccess.Instance.Values.Categories.ToArray());
            comboBox_category.SelectedIndex = 0;
        }

        private void button_create_Click(object sender, EventArgs e) {
            DBAccess.Instance.RegisterNewProduct(new Product {
                Category = comboBox_category.SelectedItem.ToString(),
                Name = textBox_productName.Text
            });

            Close();
        }
    }
}
