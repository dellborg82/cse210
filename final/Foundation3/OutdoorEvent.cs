using System;

class OutdoorEvent : Event{
    private string _weather;

    public OutdoorEvent(string weather, string eventTitle, string description, string date, int time, Address address):base(eventTitle, description, date, time, address){
        _weather = weather;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType ="Outdoor";
    }    
    public string OutEvent(){
    return $"{_eventType}\n{_eventTitle}\n{_weather}\n{_description}\ndate: {_date}\n{_address.GetAddress()}";
    }    
}