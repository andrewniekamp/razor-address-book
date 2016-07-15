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

      Get["/contact_create"] = _ => {

        return View["contact_create.cshtml"]
      };
    }
  }
}
