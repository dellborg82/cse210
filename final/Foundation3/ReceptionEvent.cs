using System;

class ReceptionsEvent : Event{
    private string _rsvpEmail;

    public ReceptionsEvent(string rsvpEmail, string eventTitle, string description, string date, int time, Address address):base(eventTitle, description, date, time, address){
        _rsvpEmail = rsvpEmail;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "Receptions";
    }


   
    public string RecEvent(){
    return $"{_eventType}\n{_eventTitle}\n{_rsvpEmail}\n{_description}\ndate: {_date}\n{_address.GetAddress()}";
    }
}