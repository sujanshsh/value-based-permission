# Role-Based Access Control using Values-based Functional Permissions
We may need a complex type of permissions which is very hard to define and implement in our applications. For cases like this, the value-based functional permissions using RBAC may solve the problem. I came up with the value-based idea to solve the complex fine-grained access requirement.  Some examples of such permissions are as follows:

- CanViewInvoice\<Branch\>:Own
- CanViewInvoice\<Branch\>:12;15
- CanViewInvoice\<Region\>:Own
- CanViewInvoice\<Region\>:Asia;Africa\<TimeRange\>:11:00-15:00
- CanCancelnvoice\<TimeRange\>:11:00-15:00
- CanCancelnvoice\<Branch\>:Own
- CanCancelnvoice\<Day\>:Mon;Tue;Wed;Thu;Fri

# Roles in Dot Notation
I think role names should be written in dot notation for better clarity and easy maintenance as follows:

- Sales.Central
- Accounts.Central
- Sales.Region.Asia
- Sales.Region.All
