using System;

class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country){

        _address = address;
        _city = city;
        _state = state;
        _country = country;
    } 

    public bool inUSA(){
        if (_country.ToUpper() == "USA"|| _country.ToUpper() == "UNITED STATES"|| _country.ToUpper() == "US"){
            return true;
        }
        return false;
    }

    public string GetFullAddress(){
        string fullAdress = $"Street Address: {_address}\nCity: {_city}\nState: {_state}\nCountry: {_country}\nShipping to USA: {inUSA()}";
        return fullAdress;
    }
}