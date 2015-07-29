## Project Name

Project description.

Trial Project for work interview in Alfasoft Company. Objective was to create a simple user management Web API.

##Constraints

* Should be able to store user's identification, name and password.
* Business logic **MUST** be in the controller
* Controller should be create using option **Web API 2 Controller With Actions, using Entity Framework**
* Add a user only if there's none with supplied name or identification
  * In case of a fail, the response **MUST** be a Bad Request (400)
* Remove a user only if exists one with supplied name
  * In case of a fail, the response **MUST** be a Bad Request (400)
* For testing purposes, there should be 3 views:**(See below)**
  * Add View with input for identification, name and password
  * Remove View with input for name
  * List View with iddentification, name and password fields

## Missing Views

Unfortunatly due to Same-origin policy I am unable to provide Views with requests to another webpages. Still thinking on that problem.

## Run Locally
1. Download Zip file [HERE](https://github.com/isel-31612/AlfasoftExercise/archive/master.zip) OR clone from this repository
2. Double-click on AlfasoftExercise.sln to start Visual Studio OR Add it with the File > Open > Project/Solution (Ctrl+Shift+O)
3. Hit Run/Debug

## Deploying

* Project is deployed in AppHarbor and can be access in the following end-points:
 1. [List] (http://alfasoftexercise.apphb.com/api/users)
 2. [Add] (http://alfasoftexercise.apphb.com/api/users/new)
 3. [Remove] (http://alfasoftexercise.apphb.com/api/users/delete)
 
 *EDIT:* Still having some struggles with the deploy


Note: It may take up to 5 minutes for the application to load initially (due to project inactivity)
