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
    public partial class DebugWindow : Form {
        public DebugWindow() {
            InitializeComponent();
        }

        private void DebugWindow_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.Equals(Keys.Return)) {
                button_run_Click(sender, e);
            }
        }

        private void DebugWindow_Load(object sender, EventArgs e) {
            consoleOut.Focus();
        }

        private void button_run_Click(object sender, EventArgs e) {
            CommandParser parser = new CommandParser(textLine_console.Text);
            WriteToConsoleOut($"Run >> {parser.Command}");

            if (parser.ContainsArgument("quit")) {
                Application.Exit();
            }

            if (parser.Command.Equals("put_p")) {
                //put id=0 name=testP category=testCat
                if (parser.ContainsArgument("id") && parser.ContainsArgument("name") && parser.ContainsArgument("category")) {
                    Product p = new Product();
                    p.Name = parser.GetArgumentValue("name");
                    p.Category = parser.GetArgumentValue("category");

                    WriteToConsoleOut($"New product:");
                    WriteToConsoleOut($"Name -> {p.Name}");
                    WriteToConsoleOut($"Category -> {p.Category}");

                    DBAccess.Instance.RegisterNewProduct(p);
                }
            }

            if(parser.Command.Equals("put_c")) {
                if (parser.ContainsArgument("id") && parser.ContainsArgument("name")) {
                    (string, string) id_name_pair = (parser.GetArgumentValue("id"), parser.GetArgumentValue("name"));

                    WriteToConsoleOut("");
                    WriteToConsoleOut($"New category:");
                    WriteToConsoleOut($"ID -> {id_name_pair.Item1}");
                    WriteToConsoleOut($"Name -> {id_name_pair.Item2}");

                    DBAccess.Instance.Linker.InsertNewCategory(uint.Parse(id_name_pair.Item1), id_name_pair.Item2);
                }
            }

            ClearConsoleOut();
        }

        private void WriteToConsoleOut(string s) {
            consoleOut.Text += $"{s}{Environment.NewLine}";
        }
        private void ClearConsoleOut() {
            consoleOut.Text = string.Empty;
        }


        class CommandParser {
            public string Command => argumentsList.Count > 0 ? argumentsList[0] : "Null";
            public string[] Arguments => argumentsList.ToArray();

            private List<string> argumentsList = new List<string>();
            private Dictionary<string, string> valueByArgument = new Dictionary<string, string>();

            public CommandParser(string commandLine) {
                argumentsList = new List<string>(SplitCommandLine(commandLine));

                foreach (var item in argumentsList) {
                    if (item.Contains('=')) {
                        var pair = item.Split('=');
                        valueByArgument.Add(pair[0], pair[1]);
                    }
                }
            }

            public bool ContainsArgument(string argument) => argumentsList.Contains(argument) || valueByArgument.ContainsKey(argument);
            public string GetArgumentValue(string argument) => valueByArgument.ContainsKey(argument) ? valueByArgument[argument] : string.Empty;

            string[] SplitCommandLine(string input) {
                return input.Split(' ');
            }
        }
    }
}
