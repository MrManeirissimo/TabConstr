using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelamentoConstrucao.App {
    public static class Database {
        public static List<Construction> ConstructionList { 
            get => DBAccess.Instance.Values.Constructions;
            set => DBAccess.Instance.Values.Constructions = value;
        }
        public static List<string> CategoryList => DBAccess.Instance.Values.Categories;
        public static List<Product> ProductList => DBAccess.Instance.Values.Products;
    }

    public class DBAccess {
        public static DBAccess Instance {
            get {
                if (instance_internal == null) {
                    instance_internal = new DBAccess();
                }

                return instance_internal;
            }
        }
        private static DBAccess instance_internal;

        public DBValues Values { get; private set; }
        public DBLinker Linker { get; private set; }


        private DBAccess() {
            Values = new DBValues();
            Linker = new DBLinker();

            Linker.OnConstructionRetrievalSuccessful += OnConstructionsLoaded;
            Linker.OnCategoriesRetrievalSuccessful += OnCategoriesLoaded;
            Linker.OnProductsRetrievalSuccessful += OnProductsLoaded;

            Linker.OnConstructionInsertionSuccessful += OnConstructionInsertionSuccessful;
            Linker.OnProductInsertionSuccessful += OnProductInsertionSuccessful;


            Linker.RetriveConstructions();
            Linker.RetriveCategories();
            Linker.RetrieveProducts();
        }


        private void OnConstructionInsertionSuccessful(Construction obj) => Linker.RetriveConstructions();
        private void OnProductInsertionSuccessful(Product p) => Linker.RetrieveProducts();


        private void OnConstructionsLoaded(List<Construction> constructionList) {
            Values.Constructions = constructionList;
        }

        private void OnCategoriesLoaded(List<string> categoryList) {
            Values.Categories = categoryList;
        }

        private void OnProductsLoaded(List<Product> productList) {
            Values.Products = productList;
        }


        public void RegisterNewConstruction(Construction c) {
            Linker.InsertNewConstruction(c, Values.Constructions.Count);
        }

        public void RegisterNewProduct(Product p) {
            Linker.InsertNewProduct(p, Values.Products.Count);
        }


        public void Start() { }
    }
}
