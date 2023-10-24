namespace BlazorHm1.Models
{
    public class Product
    {
        private int _price;
        private string _name;
        private string _description;
        private string _linkImg;

        public Product()
        {
            _price = 0;
            _name = string.Empty;
            _description = string.Empty;
            _linkImg = string.Empty;
        }

        public Product(int price, string name, string description, string linkImg)
        {
            _price = price;
            _name = name;
            _description = description;
            _linkImg = linkImg;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetPrice(int price)
        {
            _price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public string GetLinkImg()
        {
            return _linkImg;
        }

        public void SetLinkImg(string linkImg)
        {
            _linkImg = linkImg;
        }      
    }
}
