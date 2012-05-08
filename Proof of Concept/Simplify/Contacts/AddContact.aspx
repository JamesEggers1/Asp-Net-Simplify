<%@ Page Language="C#" Inherits="Simplify.Core.BasePage<SimpleMVP.Contacts.CreatePresenter>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form id="form1" method="POST" action="AddContact.aspx">
    <div>
    <label for="id">ID:</label> <input type="text" id="id" name="id" />
    </div>
    <div>
    <label for="firstName">First Name:</label> <input type="text" id="firstName" name="firstName" />
    </div>
    <div>
    <label for="lastName">Last Name:</label> <input type="text" id="lastName" name="lastName" />
    </div>
    <div>
    <label for="city">City:</label> <input type="text" id="city" name="city" />
    </div>
    <div>
    <label for="state">State:</label> <input type="text" id="state" name="state" />
    </div>
    <div>
    <input type="submit" id="submit" value="submit" />
    </div>
    <div> <a href="Default.aspx">Return to list.</a></div>
    </form>
</body>
</html>
