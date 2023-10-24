namespace BlazorHm1.Models
{
    public class Catalog : ICatalog
    {
        private IReadOnlyList<Product> _catalog;

        public Catalog()
        {
            _catalog = new List<Product>() { new Product(250, "машина", "очень хорошая машина", "https://avatars.mds.yandex.net/get-autoru-reviews/1387785/Qa1HGuJ9G1w9NQ6v2BXCMLQuo17fmEPKr/1200x900"),
                                             new Product(350, "вертолет", "весьма неплохой вертолет", "https://upload.wikimedia.org/wikipedia/commons/e/e0/Vertical-T_Mil_Mi-8.jpg"),
                                             new Product(220, "мотоцикл", "быстрый новый мотоцикл", "https://atvarmor.ru/wp-content/uploads/2020/10/8b8fe188-7e07-4102-b210-2f26d353e022_bse_z7_green_blast_new_1.png")};
        }

        public Catalog(IReadOnlyList<Product> catalog)
        {
            _catalog = catalog;
        }

        public IReadOnlyList<Product> GetCatalog()
        {
            return _catalog;
        }
    }
}
