# Gopher_Payroll_Application

General Description:<br>
A Windows multi-form project that allows a user to navigate and review payroll entries in a database, add weekly payroll records, 
and output to an XML file or a printed page. 

File Arrangement:<br>
All project files were included to assist with downloading and running a copy of the project.  Note that the database and output 
files are located in ~\Gopher_Payroll\bin\Debug folder.  Listed below are the primary files to focus on for running the project 
and reviewing the code:
	
	-Solution File: 				~Gopher_Payroll.sln
	-Main Menu Form Code:			~Gopher_Payroll\MainMenuForm.cs
	-Payroll Review Form Code:		~Gopher_Payroll\PayrollReviewForm.cs
	-Add Records Form Code:			~Gopher_Payroll\AddPayrollRecordsForm.cs
	-Data Base Class Code:			~Gopher_Payroll\clsDatabase.cs

Detailed Description:<br>
The program begins at the Main form, giving the user the option to review payroll or add new records.  The first subform, called PayrollReviewForm, 
displays data from two tables in the Payroll database, consisting of employees' personal information and their weekly payroll records.  A first, next, 
previous, last navigiation allows the user to browse through the employee list while reviewing their payroll records.  The second subform, called 
AddPayrollRecordsForm, allows the user to input weekly payroll records for different employees, output to an XML file or printed page, and commit the  
records to the database. Database records are retrieved or inserted by using the clsDatabase class, which uses an App.config-stored connection string and  
SQL command objects to query and update via stored procedure.  

