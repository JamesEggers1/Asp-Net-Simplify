<%@Page Language="C#" Inherits="Simplify.BasePage<Simplify.Sample.Contacts.ReadPresenter>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Read All Contacts</title>
</head>
<body>
    <form id="form1">
    <div>
    <table>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>City</th>
        <th>State</th>
    </tr>
    <% foreach (var c in this.Model)
       { %>
       <tr>
            <td><%=c.FirstName %></td>
            <td><%=c.LastName %></td>
            <td><%=c.City %></td>
            <td><%=c.State %></td>
       </tr>
    <% } %>
    </table>
    </div>
    <p>
    <a href="AddContact.aspx">Add a New Contact</a>
    </p>
    </form>
</body>
</html>
