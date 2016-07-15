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


  }
}
