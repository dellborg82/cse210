using System;

class LectureEvent : Event{
    private string _lecName;
    private int _atCapacity;


    public LectureEvent(string lecName, int atCapacity , string eventTitle, string description, string date, int time, Address address):base(eventTitle, description, date, time, address){
        _lecName = lecName;
        _atCapacity = atCapacity ;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType= "Lecture";
    }



    public string LectEvent(){
        return $"{_eventType}\n{_eventTitle}\nSpeaker: {_lecName}\nCapacity: {_atCapacity}\n{_description}\ndate: {_date}\n{_address.GetAddress()}";
    } 
}