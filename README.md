Builder  
=======
![Build](https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva)

Creates .NET projects, with all the relationship between them.

Builder it's a command line program, that helps developers to build a solution from scratch. 

Example:
=======

builder create -t csharp -a MySolution -e "MySolution.Web + (MySolution.Model + A + B + C) + (MySolution.Business + MySolution.Model + (MySolution.Dal + MySolution.Model))"


1. -t defines the template that builder will use
2. -a defines the name of solution
3. -e defines the mathematic expression to construct the projects

The principal goal it's that builder supports many others languages (templates).


