Builder 
=======

Creates .NET projects, with all the relationship between them.

Builder it's a command line program, that helps developers to build a solution from scratch, with all projects relation between them. 

Example:
=======

builder create -t csharp -a MySolution -e "MySolution.Web + (MySolution.Model + A + B + C) + (MySolution.Business + MySolution.Model + (MySolution.Dal + MySolution.Model))"

-t defines the template that builder will use

-a defines the name of solution

-e defines the mathematic expression to construct the projects



![Build](https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?retina=true)
