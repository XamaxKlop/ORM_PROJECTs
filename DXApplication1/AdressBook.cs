using System;

public struct Phone 
{
    public long[] home;
    public long[] work;
    public long[] mobile;
}

public class Human : Phone
{
    public string name;
    public string organization;
    public string position;
    public string email;
    public Phone phones; 
}

public class AdressBook : Human
{
    public Human[] humen;
}