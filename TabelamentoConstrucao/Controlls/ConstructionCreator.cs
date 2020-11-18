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
    public partial class ConstructionCreator : Form {
        public ConstructionCreator() {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_name.Text) ||
                string.IsNullOrEmpty(textBox_address.Text)) {

                Task.Run(() => {
                    MessageBox.Show("Nome e endereço não podem ser campos vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
            else {
                Construction construction = new Construction() {
                    Name = textBox_name.Text,
                    Address = textBox_address.Text,
                    EntryList = new List<Entry>()
                };

                construction.EntryList.Add(new Entry() {
                    Cost = 100,
                    ItemIndex = 1,
                    EntryIndex = 0,
                    Quantity = 10,
                    Total = 10 * 100,
                    Date = DateTime.Now.ToString("dd/MM/yyyy")
                });

                try {
                    DBAccess.Instance.RegisterNewConstruction(construction);
                    Close();
                }
                catch(Exception) {
                    Task.Run(() => {
                        MessageBox.Show("Error!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            }
        }
    }
}
