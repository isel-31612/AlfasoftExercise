## Project Name

Project description.

Trial Project for work interview in Alfasoft Company. Objective was to create a simple user management Web API.

##Constraints

* Should be able to store user's identification, name and password.
* Business logic MUST be in the controller
* Add a user only if there's none with supplied name or identification
** In case of a fail, the response MUST be a Bad Request (400)
* Remove a user only if exists one with supplied name
** In case of a fail, the response MUST be a Bad Request (400)
* For testing purposes, there should be 3 views:
** Add View with input for identification, name and password
** Remove View with input for name
** List View with iddentification, name and password fields


## Run Locally
1. Download Zip file OR clone from this repository
2. Double-click on AlfasoftExercise.sln to start Visual Studio OR Add it with the File > Import Project
3. Hit Run/Debug

## Deploying

1. Project is deployed in AppHarbor
2. Access it with the following link http://alfasoftexercise.apphb.com/ 

Note: It may take up to 5 minutes for the application to load initially (due to project inactivity)
