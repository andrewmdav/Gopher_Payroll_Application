# Gopher_Payroll_Application

**General Description:**<br>
A Windows multi-form project that allows a user to navigate and review payroll entries in a database, add weekly payroll records, 
and output to an XML file or a printed page. 

**File Arrangement:**<br>
Highlighted below are the critical files for running the project and reviewing the code:
	
	Program Execution:
	-Published Application: 		~PublishedApplication\setup.exe
	-Database File:					~DatabaseFiles\Payroll.mdf
	
	Code Review:
	-Solution File: 				~GopherPayrollCode\Gopher_Payroll.sln
	-Main Menu Form Code:			~GopherPayrollCode\Gopher_Payroll\MainMenuForm.cs
	-Payroll Review Form Code:		~GopherPayrollCode\Gopher_Payroll\PayrollReviewForm.cs
	-Add Records Form Code:			~GopherPayrollCode\Gopher_Payroll\AddPayrollRecordsForm.cs
	-Data Base Class Code:			~GopherPayrollCode\Gopher_Payroll\clsDatabase.cs
	
	New Payroll Record Output Examples:
	-PDF File: 						~OutputExamplesForNewRecords\NewPayrollRecords.pdf
	-XML File: 						~OutputExamplesForNewRecords\NewPayrollRecords.xml

**Detailed Description:**<br>
The program begins at the Main form, giving the user the option to review payroll or add new records.  The first subform, called PayrollReviewForm, 
displays data from two tables in the Payroll database, consisting of employees' personal information and their weekly payroll records.  A 
first/previous/next/last navigiation allows the user to browse through the employee list while reviewing their payroll records.  The second subform, 
called AddPayrollRecordsForm, allows the user to input weekly payroll records for different employees, output to an XML file or printed page, and 
commit the records to the database. Database records are retrieved or inserted by using the clsDatabase class, which uses an App.config-stored 
connection string and SQL command objects to query and update via stored procedure.  

