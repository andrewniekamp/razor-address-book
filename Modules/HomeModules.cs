using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/contact_view_all"] = _ => {
        return View["contact_view_all.cshtml"];
      };

      Get["/contact_new"] = _ => {
        return View["contact_new.cshtml"];
      };

      Post["/contact_created"] = _ => {
        Contact newContact = new Contact( Request.Form["contact-name"],
                                          Request.Form["contact-number"],
                                          Request.Form["contact-address1"],
                                          Request.Form["contact-address2"],
                                          Request.Form["contact-city"],
                                          Request.Form["contact-state"],
                                          Request.Form["contact-zip"]);
        return View["contact_created.cshtml", newContact];
      };

      // List<Contact> allContacts = Contact.GetAll();


    }
  }
}
