using System;
class Event{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected int _time;
    protected Address _address;
    protected string _eventType;

    public Event(string eventTitle, string description, string date, int time, Address address){
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;        
    }

    public string DefaultMessage(){
        return $"{_eventTitle}\n{_description}\n{_date}\n{_address.GetAddress()}";
    }

    public string ShortMessage(){
        return $"{_eventType}\n{_eventTitle}\n{_date}";
    }
}