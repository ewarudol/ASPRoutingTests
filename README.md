# ASPRoutingTests
Base configuration for routing tests in ASP.NET.

Clone project or:

1. Get MvcRouteUnitTester from Nuget
2. Add in your testing class using of two refs → for downloaded lib (add ref to project firsty!) and System.Web.Routing 
3. Register routes from RouteTable (you don't run global.asax in your tests!) - once for all tests
4. Create tester object
5. Test!

For quick implementation use tests schema from repo insted of coding points above.

Examples:

→ External requests

tester.WithIncomingRequest("/Foo/Bar/5").ShouldMatchRoute("Foo", "Bar", new { id = 5 });

tester.WithIncomingRequest("/Foo/Bar/5/Baz").ShouldMatchNoRoute();

tester.WithIncomingRequest("/handler.axd/pathInfo").ShouldBeIgnored();

→ Internal links

 tester.WithRouteInfo("Home", "About", new { id = 5, someKey = "someValue" }).ShouldGenerateUrl("/Home/About/5?someKey=someValue");

More:
https://archive.codeplex.com/?p=mvcrouteunittester
