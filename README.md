# FamilyBudgetService

Budget management application. Developed in multi layer architecture using REST API, and CQRS, Entity framework and docker.


To succesfull run application reuqires LocalDb on local compuer.

1. Install LocalDB
Install SQL Server Express with LocalDB:
You can download the SQL Server Express installer from the official Microsoft website.
During the installation process, choose the "SQL Server Express Edition" and ensure that the "LocalDB" option is selected.

2. Verify LocalDB Installation

Open a command prompt or PowerShell window.
Run the following command to check if LocalDB is installed: 
 sqllocaldb v

You should see a version number if LocalDB is installed.


You can start LocalDB by running the following command:

sqllocaldb s MSSQLLocalDB
If LocalDB is not running, this command will start it.


Database containerization, needs to be added in next comits






