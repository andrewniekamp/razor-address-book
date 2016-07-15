# Simple Address Book

##### By Andrew Niekamp

## Description

_Allows the user to create and store address records._

## Setup/Installation

_Files can be cloned from https://github.com/aniekamp/razor-address-book.git and run in a browser (requires a server environment)._

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
| Store inputs into Contact class | "Clementine S." | (saved to object instance) |
| Creates private properties with getter/setter | newContact.GetName() | return "Clementine S."|
| Add methods for saving, getting all, and clearing all | Contact.ClearAll() | return View["cleared.cshtml"] |
| Create view with links from root to route to contact viewing and another for contact creation | View["create_new.cshtml"] | "create a new contact here!" |
| Save new contact to static List and route to confirmation | View["contact_created.cshtml"] | "Contact created!" |
| Additional form to clear List on submission | View["contacts_deleted.cshtml"] | "Address book cleared!" |
| styling| -- | -- |

## Known Bugs

_None known._

## Technologies Used

_C#, Razor, Nancy, HTML, CSS, JavaScript, JQuery, Bootstrap._

### License

Copyright (c) 2016 Andrew Niekamp

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
