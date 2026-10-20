namespace Route_adv_02;

public class Product
{

    #region properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
    public double Price { get; set; }
    public int Stock { get; set; }
    #endregion

    #region methods
    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        List<Product> result = new List<Product>();
        foreach (Product product in products)
        {
            if(filter(product))
                result.Add(product);
        }
        return result;
    }

    public static void PrintReport(List<Product> products, Action<Product> action)
    {
        foreach (var p in products)
        {
            action(p);
        }
    }

    public static List<string> TransformProducts(List<Product> products, Func<Product, string> transformer)
    {
        List<string> result = new List<string>();
        foreach (var p in products)
        {
            result.Add(transformer(p));
        }
        return result;
    }

    public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
    {
        List<Product> result = new List<Product>();
        foreach (var p in products)
        {
            if (predicate(p))
            {
                result.Add(p);
            }
        }
        return result;
    }
    #endregion
}
