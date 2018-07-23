# Fast Food Randomizer App
The Fast Food Randomizer App selects and displays a fast food chain that is stored a local SQL server databse. From there, the user can choose to go to a detail page that displays the name of the restaurant and a picture of the chain that is collected by the Flickr API. Users also have the option of going to a page that allow them to add, but not removing new fast food locations to the database. The page also validates that any location being added contains only letters, numbers, and spaces.  

### Installation Instructions

1.) Download the zip file off of this page

2.) Extract the the project to a folder on your hard drive

3.) Copy the Fat Food Randomizer DB.bak file and paste it into C:\Program Files\Microsoft Sql Server\MSSQL14.YOURSQLSERVER\MSSQL\Backup

4.) Open Sql Server Management studio and navigate to the servers that you wish to put the database on. Right click on the databases tab and then select Restore Database. Under source choose Device and then pick the file Fast Food Randomizer DB.bak

5.) Run FastFoodRandomizerApp.sln

6.) Adjust the connection strings under Mainpage.cs and AddLocationPage.cs to match your server. 

7.) Start the project in visual studio.

### Open Source and Example Code

Flickr Api 

1.) https://github.com/samjudson/flickr-net

2.) https://www.youtube.com/watch?v=jXvHzLIJwRg
