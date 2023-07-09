using System;
class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public List<Product> productList = new List<Product>();
    public Product(string name, string productID, int price, int quantity){
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public int TotalPrice()
    {
        return _price*_quantity;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetName(){
        return _name;
    }
    
    public string GetProductID(){
        return _productID;
    }
}