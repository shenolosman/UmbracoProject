namespace UmbracoProject
{
    public class DummyApi
    {
        static HttpClient client = new();
        public static async Task<Root?> GetProducts()
        {
            return await client.GetFromJsonAsync<Root?>("https://dummyjson.com/products");
        }
        public static async Task<Product?> GetProductById(int id)
        {
            return await client.GetFromJsonAsync<Product?>($"https://dummyjson.com/products/{id}");
        }
        public static async Task<string[]> GetCategories()
        {
            return await client.GetFromJsonAsync<string[]>("https://dummyjson.com/products/categories");
        }
    }
    public class Product
    {
        public int id { get; set; }
        public string? title { get; set; }
        public double? price { get; set; }
        public double? discountPercentage { get; set; }
        public string? description { get; set; }
        public double? rating { get; set; }
        public int? stock { get; set; }
        public string? brand { get; set; }
        public string? category { get; set; }
        public string? thumbnail { get; set; }
        public string[]? images { get; set; }
    }
    public class Root
    {
        public List<Product>? products { get; set; }
    }
}
