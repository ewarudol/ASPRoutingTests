# ASPRoutingTests
Base configuration for routing tests in ASP.NET.

Clone project or:

1. Get MvcRouteUnitTester and NUnit for Tests Project from Nuget
2. To your project add folowing asemblies: project to test, System.Web
3. Add necessery app.config (look repo)
4. Add in your testing class using of three refs → for downloaded lib, NUnit framework, System.Web.Routing 
5. Register routes from RouteTable (you don't run global.asax in your tests!) - once for all tests
6. Create tester object
7. Test!

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
