using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address1;
    private string _address2;
    private string _city;
    private string _state;
    private string _zip;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact( string name, string number, string address1, string address2, string city, string state, string zip)
    {
      _name = name;
      _number = number;
      _address1 = address1;
      _address2 = address2;
      _city = city;
      _state = state;
      _zip = zip;
      //Add the Contact instance to the static list already created
      _instances.Add(this);
      //Log the ID of the Contact instance based on the count of the list (serial number order)
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(newName)
    {
      _name = newName;
    }

    public string GetNumber()
    {
      return _number;
    }
    public void SetNumber(newNumber)
    {
      _number = newNnumber;
    }

    public string GetAddress1()
    {
      return _address1;
    }
    public void SetAddress1(newAddress1)
    {
      _address1 = newAddress1;
    }

    public string GetAddress2()
    {
      return _address2;
    }
    public void SetAddress2(newAddress2)
    {
      _address2 = newAddress2;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(newCity)
    {
      _city = newCity;
    }

    public string GetState()
    {
      return _state;
    }
    public void SetState(newState)
    {
      _state = newState;
    }

    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(newZip)
    {
      _zip = newZip;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId -1];
    }


  }
}
