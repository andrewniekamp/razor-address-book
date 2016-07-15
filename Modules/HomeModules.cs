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

        return View["contact_new.cshtml"]
      };

      Post["/contact_created"] = _ => {

        return View["contact_created.cshtml"]
      };
    }
  }
}
