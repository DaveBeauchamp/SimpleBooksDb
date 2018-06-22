This application is a basic database using a book catalogue as it's use case.
There are some repetitive uses of methods though in the situatons it was not 
worth writing the same thing when a different value from the form could be used.

The dgv is interactive with a double click event on a row the books area to the left
will show the values of the book selected. I have implemented this in lieu of a search 
function though I will be making a web service ASP.NET version of this.

I used for the navigation buttons an SQL approach to navigation in that it will 
work in the stateless environment in the web and also work well here in this desktop
environment.

I prefer this way instead of reading to a collection and navigating 
through that collection because once again in a stateless environment I would need 
to store the collection in a session and I don't like this for 2 reasons 

1. What if there are a lot of records
2. Storing anything in a session could be a vulnerability that could have potential
to be an insecurity which could lead to someone finding things out about your database.
however unlikey this might be, any information on the table structure could have a bad result.
DROP TABLE table_name; I would hope not

However the above concern in No. 2. I have mitigated that a bit with parameterized queries
in Dapper though still I prefer navigation this way. 

The rest of the application is pretty straight forward