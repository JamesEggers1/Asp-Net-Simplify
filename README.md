# Simplify
#### A (proof of concept) MVP Framework for ASP.Net Webforms

## Overview
This project is currently a proof of concept in building a MVP abstraction layer for ASP.Net WebForms. By applying a MVP framework onto ASP.Net, developers can write more decoupled code than the traditional codebehind model which increases the maintainability and testability of the code.

## The MVP Design Pattern
For those who may not be familiar with the Model-View-Presenter (MVP) design pattern, MVP provides a way of structuring your code into specific responsibilities similar to the Model-View-Controller (MVC) pattern.  Unlike MVC though, MVP distributes the repsonibilities a little bit differently in order to focus more on its use for developer user interfaces.

####Model
The Model is simply a data construct used to describe the data to display and be manipulated by the user interface.  This is very similar to the concept of a View Model or or Data Transfer Object (DTO).

####View
The View is a template used to display the data represented in the Model object in addition to routing events (e.g. button clicks) to the Presenter so such can be acted upon.

####Presenter
The Presenter is used to retrieve Model data from the data stores or repositories and formats it to display in the appropriate View.

## Components of Simplify
Simplify takes these concepts of the MVP design pattern and attempts to merge them with some of the constructs imposed by the ASP.Net WebForm framework.

####Page Routing
ASP.Net Webforms uses a page-based routing system (by default) where users browse to a specific resource in their and that page's code behind file invodes various server-side methods that correspond to it's own page life cycle.

With Simplify, the routing aspects of ASP.Net WebForms remains intact; however, the Page_Load event shifts responsibiltiy to the HandleRequest method of the Presenter object associated with the Page.

####Models
Models in Simplify are of type `dynamic`. Models are set by the Presenter and are used by the View in a similar manner of the ASP.Net MVC framework. 

####Views
Views in Simplify are slightly different from ASP.Net WebForms.  The same naming conventions and server tags still exist; however, Views in Simplify do not have a Code Behind file.  With Simplify, logic should be sent to the Presenter object that can be associated with the View.  To bind a Presenter to a View in Simplify, the Page directive at the top of each page needs to change to something similar to the following:

> &lt;%@Page Language="C#" Inherits="Simplify.Core.BasePage&lt;SimpleMVP.Contacts.ReadPresenter&gt;" %&gt;

In the above example, the View inherits from a Simplify BasePage generic class that takes an instance of an `IPresenter` class to bind the logic between the two components.

In addition to how a View is associated with a Presenter, Views can also tap into the Model object which the Presenter creates to send data to the View. All Views can access their Model in a manner similar to other following:

> &lt;div&gt;<br>
> &lt;label for="FirstName"&gt;First Name&lt;/label&gt;&lt;br /&gt;<br>
> &lt;span&gt;&lt;%=this.Model.FirstName %&gt;&lt;/span&gt;<br>
> &lt;/div&gt;
>
> &lt;div&gt;<br>
> &lt;label for="LastName"&gt;Last Name&lt;/label&gt;&lt;/br&gt;<br>
> &lt;span&gt;&lt;%=this.Model.LastName %&gt;&lt;/span&gt;<br>
> &lt;/div&gt;

####Presenter
Coming Soon.
