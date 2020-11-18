/*
 * Class which encapsulates an entry into a construction page
 */
namespace TabelamentoConstrucao.App {
    public class Entry {
        public Entry() {

        }
        public Entry(int entryIndex) {
            this.EntryIndex = entryIndex;
        }

        public int EntryIndex { get; set; }
        public int ItemIndex { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public double Cost { get; set; }
        public string Date { get; set; }
    }
}
