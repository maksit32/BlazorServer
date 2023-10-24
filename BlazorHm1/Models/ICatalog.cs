namespace BlazorHm1.Models
{
    public interface ICatalog
    {
        IReadOnlyList<Product> GetCatalog();
    }
}