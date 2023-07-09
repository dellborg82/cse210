using System;

class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer){
        _products = products;
        _customer = customer;
    }

    public int CalculateTotalCost(){
        int totalCost = 0;
        foreach (Product product in _products){
            totalCost = totalCost + product.TotalPrice();

        }
        if (_customer.inUSA()){
            totalCost = totalCost + 5;

        }else if (!_customer.inUSA()){
            totalCost = totalCost + 35;
        }
        return totalCost;
    }

    public string LabelPacket(){
        string labelPacket= "-------Products-------\n";
        foreach(Product product in _products){        
        labelPacket = labelPacket + "Item: " + product.GetName() + " SKU Number: " + product.GetProductID() + " Price: $" + product.GetPrice() + " Quantity: " + product.GetQuantity() +"\n";            
        }        
        return labelPacket;
    }

    public string ShippingLabel(){
      return _customer.GetName() +"\n" + _customer.GetAddress();
    }
}