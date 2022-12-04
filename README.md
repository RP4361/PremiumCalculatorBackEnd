# PremiumCalculatorBackEnd

I am using EFCore as ORM mapper tool.
As per data provided in mail it is Seeded on first migration along with table creation.
API is built on .NetCore6

The BACKEND is divided into 3 layers :
	1. Domain
	2. DataAccess
	3. API

Below Principles and Design Pattern is used in creating this framework :
	1. Dependency Inversion
	2. Interface Segregation
	3. Open Closed
	4. Repository Pattern with Unit Of Work
	



---------------------------------------------------------------------------------------------

Domain class lib is used to describe Models and Interfaces for Repository and UnitOfWork.
DataAccess lib is actual implementation of Repository and UnitOfWork.
PremiumCalculatorApi is the api project which has the real endpoint for populating Occupation
dropdown.

If we take a closer look at the code we will see that "Domain" interfaces are implemented
in "DataAccess" to preserve Dependency Inversion.
Then all the concrete classes are implementing their Interfaces.

Also, a Generic Repository is created which can be used to handle all the basic operations
related to CRUD.
We do not be wanting to implement all the basic crud operations like Get, GetAll, Create,
Delete etc again and again in multiple repositories hence every time only GenericRepository
will be used.
For any individual Entity need we can make use of Entity specific repository in this case
it is "IOccupationRepository".

Finally we are implementing UnitOfWork to allow multiple operations to be clubbed into one.
Microsoft also suggests to make use of such pattern.
And lastly this is covered by implementing an IDisposable interface to mark for Garbage Collection.




