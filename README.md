# Role-Based Access Control using Values-based Functional Permissions
We may need a complex type of permissions which is very hard to define and implement in our applications. For cases like this, the value-based functional permissions using RBAC may solve the problem. I came up with the value-based idea to solve the complex fine-grained access requirement. The permisions will have additional fiels: `suffix` and `value_type_id`. Some examples of such permissions are as follows [Format: permission [suffix] [value_type] [values]]:

- View_Invoice_Access
- Region_Level_Access
- Multiple_Department_Access DepartmentGroup1 \<Department\> 1,2,3
- Multiple_Department_Access DepartmentGroup2 \<Department\> 4,5,6
- Create_Invoice
- Cancel_Invoice

# Roles in Dot Notation
I think role names should be written in dot notation for better clarity and easy maintenance as follows:

- Sales.Central
- Accounts.Central
- Sales.Region.Asia
- Sales.Region.All
