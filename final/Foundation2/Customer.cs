using System;

class Customer{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address){     
     _customerName = customerName;
     _address = address;
    }

    public bool inUSA(){
        return _address.inUSA();      
    }

    public string GetName(){
        return _customerName;
    }

    public string GetAddress(){
        return _address.GetFullAddress();
    }
}