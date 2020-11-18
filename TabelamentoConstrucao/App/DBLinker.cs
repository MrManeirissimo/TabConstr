using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// firebase validation response
using FireSharp.Response;

// firebase configuration and authentication
using FireSharp.Interfaces;
using FireSharp.Config;


using FireSharp;
using System.Net;
using System.Windows.Forms;

namespace TabelamentoConstrucao.App {
    public class DBLinker {
        public event Action<List<string>> OnCategoriesRetrievalSuccessful;
        public event Action<HttpStatusCode> OnCategoriesRetrievedFailed;

        public event Action<string> OnCategoryInsertionSuccessful;
        public event Action<HttpStatusCode> OnCategoryInsertionFailed;

        public event Action<Product> OnProductInsertionSuccessful;
        public event Action<HttpStatusCode> OnProductInsertionFailed;

        public event Action<List<Product>> OnProductsRetrievalSuccessful;
        public event Action<HttpStatusCode> OnProductsRetrievalFailed;

        public event Action<List<Construction>> OnConstructionRetrievalSuccessful;
        public event Action<HttpStatusCode> OnConstructionRetrievalFailed;

        public event Action<Construction> OnConstructionInsertionSuccessful;
        public event Action<HttpStatusCode> OnConstructionInsertionFailed;

        IFirebaseConfig config = new FirebaseConfig() {
            AuthSecret = "PISOmbwIUrq6luvZR3iwUHMgjw87r2XRBoqPIuE8",
            BasePath = "https://construction-app-d2b16.firebaseio.com/"
        };
        IFirebaseClient client;

        public DBLinker() {
            client = new FirebaseClient(config);
        }

        public async void InsertNewCategory(uint ID, string name) {
            SetResponse response = await client.SetAsync($"Categories/{ID}", name);
            if (RequestAccepted(response.StatusCode)) {
                OnCategoryInsertionSuccessful?.Invoke(response.ResultAs<string>());
            }
            else OnCategoryInsertionFailed?.Invoke(response.StatusCode);
        }

        public async void InsertNewProduct(Product product, int productCount) {
            SetResponse response = await client.SetAsync($"Products/{productCount}", product);

            if (RequestAccepted(response.StatusCode)) {
                OnProductInsertionSuccessful?.Invoke(response.ResultAs<Product>());
            }
            else OnProductInsertionFailed?.Invoke(response.StatusCode);
        }

        public async void InsertNewConstruction(Construction construction, int constructionCount) {
            SetResponse response = await client.SetAsync($"Constructions/{constructionCount}", construction);

            if (RequestAccepted(response.StatusCode)) {
                OnConstructionInsertionSuccessful?.Invoke(construction);
            }
            else OnConstructionInsertionFailed?.Invoke(response.StatusCode);
        }


        public async void RetriveConstructions() {
            FirebaseResponse response = await client.GetAsync("Constructions");

            if (RequestAccepted(response.StatusCode))
                OnConstructionRetrievalSuccessful?.Invoke(response.ResultAs<List<Construction>>());

            else OnConstructionRetrievalFailed?.Invoke(response.StatusCode);
        }

        public async void RetriveCategories() {
            FirebaseResponse response = await client.GetAsync("Categories");

            if (RequestAccepted(response.StatusCode)) 
                OnCategoriesRetrievalSuccessful?.Invoke(response.ResultAs<List<string>>());

            else OnCategoriesRetrievedFailed?.Invoke(response.StatusCode);
        }

        public async void RetrieveProducts() {
            FirebaseResponse response = await client.GetAsync("Products");
            if (RequestAccepted(response.StatusCode)) {
                OnProductsRetrievalSuccessful?.Invoke(response.ResultAs<List<Product>>());
            }
            else OnProductsRetrievalFailed?.Invoke(response.StatusCode);
        }


        private bool RequestAccepted(HttpStatusCode statusCode) {
            return statusCode.Equals(HttpStatusCode.OK) || statusCode.Equals(HttpStatusCode.Accepted);
        }
    }
}
