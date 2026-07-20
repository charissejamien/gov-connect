1. Project Title & Description
   GovConnect is an online portal built using .NET 8 (Blazor Interactive Server) and Supabase (PostgreSQL). It simplifies public service transactions by providing a centralized hub where citizens can search for government documents (such as Birth Certificates, Driver's Licenses, and Passports), submit applications, book identity-verification appointments, and track request progress in real time using unique reference identifiers. It also features an administrative overview dashboard for managing incoming request queues.

2. Group Members & Roles/Responsibilities
   Member 1:
   Name: Charisse Jamien Alagbay
   Role: Full-stack Developer

Member 2:
Name: Princess Mikaela Borbajo
Role: UI/UX Designer, Frontend Developer

Member 2:
Name: Zoie Christle Estorba
Role: UI/UX Designer, Frontend Developer

3. How to Restore Packages & Run the Project
   Prerequisites:
   NET 8.0 SDK installed.  
   Git installed.

Steps to run:
a. Clone the Repository:
git clone https://github.com/charissejamien/gov-connect.git
cd gov-connect

b. Restore NuGet packages:
dotnet restore

c. Build and Run the application:
dotnet build
dotnet run

d. Access the application:
Open your browser and navigate to http://localhost:5084

4. How to Create/Update the Database Using Migrations
   GovConnect utilizes a PostgreSQL database managed via Supabase. Database schema initializations and subsequent structure updates can be executed using
   Supabase SQL Editor: Access the project's Supabase Web Dashboard, open the SQL Editor, and execute the repository's schema creation script. This process sets up the documents catalog table and the relational requests table (configured with foreign key references to auth.users for registered citizen accounts). Standard seeding queries should be executed immediately afterward to populate initial government document fees, processing times, and issuing agency metadata.

5. How to Run Unit Tests
   a. To execute the automated test:
   dotnet test

6. Default / Test Login Accounts
   a. Citizen User Account:
   Email: citizen@govconnect.ph
   Password: citizen

b. Admin Account
Email: admin@govconnect.ph
Password: admin

7. Known Issues & Incomplete Features
   a. Password Reset Mechanism
   The "Forgot password?" trigger on the sign-in page is a static UI placeholder and is not currently linked to Supabase Auth reset emails.

b. Citizen Editing/Cancellation
The citizen dashboard does not currently grant users the ability to edit or cancel a request once it has been submitted.
