# Introduction

Rotam is a full-stack progressive web application deigned for bike shops. It has includes 3 high-level level domains. Tasks, Retail, Content Management. 

Built with ASP.NET Core + SQL Server back-end and Angular front-end.

Project template based from ASP.NET Boilerplate to handle authentication, authorization, multitenancy and other infrastructural concerns. 

https://github.com/aspnetboilerplate
 
## Feature
New features should be submitted as a Azure DevOps backlog item. The item must be linked from a 

## SDLC Sequence
*Feature Management*
1. ~Identidify~ Create new feature or bug request as a ~backlog~ item under a feature item in Azure DevOps backlog - https://dev.azure.com/castriganoj/Rotam/_backlogs. 
2. ~Design~ Backlog item title should concisely describe the feature or bug. The description can be used to inlcude other contextual details. A complete card should have a linked branch.
3. ~Plan~ Document, plan and create a complete set of implementation steps for the backlog item. 
4. Estimate and commit tasks to a sprint iteration. A complete card should have a linked branch

*Branch Management*
5. Build. Each backlog item must have an assocated branch linked to it. Sub tasks of the back log item must have that branch or a sub branch of that branch linked to it. 
6. Once work is planned in a task and committed to in an iteration, commence with building the code.
7. Git. Once build work is complete, commit with a meaningful message. 
8. Push to remote repo which should automatically kick off the deploy process

## Databse
During the prototyping phase there will be only once database in an Azure instance. The intial features will only use in memory data. 



