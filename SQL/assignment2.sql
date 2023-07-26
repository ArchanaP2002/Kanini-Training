use northwind;
SELECT CategoryName, Description FROM categories ORDER BY CategoryName;

SELECT ContactName, CompanyName, ContactTitle, Phone
	FROM Customers Order By ContactTitle DESC;

SELECT UPPER(FIRSTNAME) AS FirstName, UPPER(LastName) As LastName, HireDate
	FROM Employees ORDER BY HireDate DESC;

