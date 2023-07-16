using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("123 Ebby Street","Ebbyville","Utah","USA");
        Address address2 = new Address("456 Ebby Street","Ebbyville","Utah","USA");
        Address address3 = new Address("984 Ebby Street","Ebbyville","Utah","USA");


        
        LectureEvent lecture = new LectureEvent("Ebby Anne", 150, "Shi-Tzu 101", "This lecture wil cover how to care for your Shi-Tzu.","6/24/2023",120, address1);
        OutdoorEvent outdoor =  new OutdoorEvent("Ham Radio Field Day", "Field Day", "Ham Radio Field Day. Do you want to know about Ham Radio?", "7/23/2023", 360, address2);
        ReceptionsEvent receptions = new ReceptionsEvent("aastevens@starshipfrontier.org", "Artemis Bridge Simulator", "Artemis Bridge Simulator. Have you ever wanted to be the Captain of a Starship?", "9/5/2023", 150, address3);

        Console.WriteLine(lecture.ShortMessage());
        Console.WriteLine();
        Console.WriteLine(lecture.DefaultMessage());
        Console.WriteLine();
        Console.WriteLine(lecture.LectEvent());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(outdoor.ShortMessage());
        Console.WriteLine();
        Console.WriteLine(outdoor.DefaultMessage());
        Console.WriteLine();
        Console.WriteLine(outdoor.OutEvent());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(receptions.ShortMessage());
        Console.WriteLine();
        Console.WriteLine(receptions.DefaultMessage());
        Console.WriteLine();
        Console.WriteLine(receptions.RecEvent());
    }
}