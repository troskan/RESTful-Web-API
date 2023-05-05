# RESTful-Web-API
Creating a RESTful-Web-API that will handle Persons and their Interests.


Tasks for school assignment

#1. Get all persons.
https://localhost:7228/api/Person

#2 Get all hobbys that is connected to a specefic person.
https://localhost:7228/api/Person/GetHobbysBy/11

#3 Get all Links that is connected to a specefic person.
https://localhost:7228/api/Person/GetLinksBy/11

#4 Connect a Person to a hobby.
https://localhost:7228/api/PersonHobby
{
  "personID": 3,
  "hobbyID": 4
}

#5 Add new links and hobbys to person.
{
  "personID": 3,
  "hobbyID": 4
  "linkID": 6
}
