using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The higher level abstraction containing all the database's values and keys
 * accessible and useable throughout the hole application
 */
namespace TabelamentoConstrucao.App {
    public class DBValues {

        public event Action<List<Construction>> OnConstructionDataUpdated;
        public event Action<List<string>> OnCategoryDataUpdated;
        public event Action<List<Product>> OnProductDataUpdated;

        public bool AreCollectionsValidated => constructionList != null && categoryList != null && productList != null;
        public List<Construction> Constructions { get => constructionList; set {
                constructionList = value;
                OnConstructionDataUpdated?.Invoke(constructionList);
            }
        }
        public List<string> Categories { get => categoryList; set {
                categoryList = value;
                OnCategoryDataUpdated?.Invoke(categoryList);
            }
        }
        public List<Product> Products { get => productList; set {
                productList = value;
                OnProductDataUpdated?.Invoke(productList);
            } 
        }

        private List<Construction> constructionList;
        private List<string> categoryList;
        private List<Product> productList;

        public DBValues() {

        }

        public bool ContainsProductByName(string name) {
            foreach (Product p in Products) {
                if (p.Name.Equals(name)) {
                    return true;
                }
            }

            return false;
        }
        public bool ContainsCategory(string cat) {
            foreach (var category in Categories) {
                if (category.Equals(cat)) {
                    return true;
                }
            }

            return false;
        }

        public int GetProductIndexByName(string name) {
            for (int i = 0; i < productList.Count; i++) {
                if (productList[i].Name.Equals(name)) {
                    return i;
                }
            }

            return -1;
        }
    }
}
