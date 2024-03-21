# PE_PRN211_FA23_TrialTest_StudentName

## Overview
This is a trial test project for the subject PRN211, Fall 2023. The project aims to create a Windows Forms application for managing air conditioners in an air conditioner shop. It follows a 3-Layer architecture and utilizes .NET5/.NET6/.NET7, C#, and ADO.NET/Entity Framework Core for database interaction.

## Instructions
- Use Visual Studio 2019/2022 for development.
- Create a solution named PE_PRN211_FA23_TrialTest_StudentName.
- Inside the solution, create a Windows Forms project named AirConditionerShop_StudentName.
- Create a SQL database named AirConditionerShop2023DB by executing the script AirConditionerShop2023DB.sql.
- Set the default user interface for your project as the Login form.

## Tasks

### Task 1: Design GUI and Project Structure
1. **Login Form Design** (0.5 mark)
   - Design a login form with UI controls for login function.
2. **AirConditioner Management Form Design** (0.5 mark)
   - Design a form for CRUD actions with air-conditioner information.
   - Display a list of records, create new items, update existing items, and delete specific items.
   
### Task 2: Implement CRUD Actions with GUI
3. **Authentication Function** (1.0 mark)
   - Authenticate users with Administrator role using email address/password.
   - Save login information to a temporary parameter.
4. **List Air-Conditioners** (2.0 marks)
   - List all air-conditioners in the AirConditioner table.
   - Display information including AirConditionerId, AirConditionerName, Warranty, SoundPressureLevel, FeatureFunction, Quantity, DollarPrice, and SupplierName.
5. **Search Air-Conditioner Information** (1.0 mark)
   - Search air-conditioner information by FeatureFunction or Quantity (using relative search).
6. **Delete Selected Item** (1.0 mark)
   - Delete the selected item with confirmation and update the list of air-conditioners.
7. **Add New Item** (2.5 marks)
   - Add a new item with validation requirements:
   - Use ComboBox UI control to select SupplierId/SupplierName from the SupplierCompany table.
   - All fields are required.
   - DollarPrice and Quantity must be greater than or equal to 0 and less than 4,000,000.
   - AirConditionerName must be 5-90 characters long, each word beginning with a capital letter, and may include special characters.
8. **Update Existing Item** (1.5 marks)
   - Update an existing item by AirConditionerId with validation requirements similar to the Add function.

## Submission
- Submit the project files including source code, database script, and any additional resources.
- Ensure adherence to the instructions and task requirements outlined above.
