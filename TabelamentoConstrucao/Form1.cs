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

using TabelamentoConstrucao.App;

namespace TabelamentoConstrucao
{
    public partial class MainWindow : Form
    {
        public MainWindow(string[] options)
        {
            InitializeComponent();

            mainControl.TabPages.Clear();

            try {
                if (options[0].Equals("debug")) {
                    Task.Run(() => {
                        //var dialogResult = MessageBox.Show(
                        //    "Running a  pplication in debug mode!",
                        //    "Message",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Warning
                        //);

                        DebugWindow debugWindow = new DebugWindow();
                        debugWindow.ShowDialog();
                    });
                }
            }
            catch (IndexOutOfRangeException) {

            }
        }

        private void button_newConstruction_Click(object sender, EventArgs e) {
            ConstructionCreator cCreatporWindow = new ConstructionCreator();
            cCreatporWindow.Show();
        }

        private void button_NewProduct_Click(object sender, EventArgs e) {
            ProductCreator pCreatorWindow = new ProductCreator();
            pCreatorWindow.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            DBAccess.Instance.Start();
            DBAccess.Instance.Values.OnConstructionDataUpdated += OnConstructionDataUpdated;
            DBAccess.Instance.Values.OnCategoryDataUpdated += OnCategoryDataUpdated;
            DBAccess.Instance.Values.OnProductDataUpdated += OnProductDataUpdaed;
        }


        private void OnConstructionDataUpdated(List<Construction> consturctionList) => TryUpdate();
        private void OnCategoryDataUpdated(List<string> obj) => TryUpdate();
        private void OnProductDataUpdaed(List<Product> obj) => TryUpdate();


        private void TryUpdate() {
            //DateTime.for
            mainControl.TabPages.Clear();
            if (DBAccess.Instance.Values.AreCollectionsValidated) {
                foreach (var construction in DBAccess.Instance.Values.Constructions) {
                    mainControl.TabPages.Add(construction.Name);

                    var itemNames = from p in DBAccess.Instance.Values.Products.ToArray() where p.Name != string.Empty select p.Name;
                    List<EntryLine> entries = new List<EntryLine>();
                    EntryLine currentEntry = null;

                    foreach (var e in construction.EntryList) {
                        entries.Add(new EntryLine(e.EntryIndex));
                        currentEntry = entries[e.EntryIndex];

                        currentEntry.LoadComboBoxes(new List<string>(itemNames).ToArray(), DBAccess.Instance.Values.Categories.ToArray());
                        currentEntry.ProductComboBox.SelectedIndex = e.ItemIndex;
                        currentEntry.CategoryComboBox.SelectedItem = Database.ProductList[e.ItemIndex].Category;
                        currentEntry.ProductQuantityTextBox.Text = e.Quantity.ToString();
                        currentEntry.TotalAmountTextBox.Text = e.Total.ToString();
                        currentEntry.UnitPriceTextBox.Text = e.Cost.ToString();
                        currentEntry.DateTextBox.Text = e.Date;


                        mainControl.TabPages[mainControl.TabPages.Count - 1].Controls.Add(currentEntry);
                    }
                }
            }
        }

        private void button_addProduct_Click(object sender, EventArgs e) {
            var newConstructionList = new List<Construction>(Database.ConstructionList);
            newConstructionList[mainControl.SelectedIndex].EntryList.Add(new Entry() {
                EntryIndex = newConstructionList[mainControl.SelectedIndex].EntryList.Count,
                Date = DateTime.Now.ToString("dd/MM/yyyy")
            });
            Database.ConstructionList = newConstructionList;
        }
    }
}
