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
    //public class Image
    //{
    //    public string? url { get; set; }
    //}
    //public class Category
    //{
    //    public string[] name { get; set; }
    //}
    //"products": [
    //    {
    //  "id": 1,
    //"title": "iPhone 9",
    //"description": "An apple mobile which is nothing like apple",
    //"price": 549,
    //"discountPercentage": 12.96,
    //"rating": 4.69,
    //"stock": 94,
    //"brand": "Apple",
    //"category": "smartphones",
    //"thumbnail": "https://i.dummyjson.com/data/products/1/thumbnail.jpg",
    //"images": [
    //  "https://i.dummyjson.com/data/products/1/1.jpg",
    //  "https://i.dummyjson.com/data/products/1/2.jpg",
    //  "https://i.dummyjson.com/data/products/1/3.jpg",
    //  "https://i.dummyjson.com/data/products/1/4.jpg",
    //  "https://i.dummyjson.com/data/products/1/thumbnail.jpg"
    //}
    //]
}
