
# DiagnosticLab – Windows Forms App

**DiagnosticLab** is a desktop application built with Windows Forms and SQL Server. It is designed for managing lab tests, technicians, and sample types in a diagnostic laboratory environment.

## 🧪 Key Features

- CRUD operations for:
  - Test Types (`TestType`)
  - Technicians (`Technician`)
  - Sample Types (`SampleType`)
  - Lab Test Records (`LabTestRecord`)
- Search:
  - By a single keyword across multiple columns (`frmByOneParam`)
  - By multiple filters and date ranges (`frmByMoreParam`)
- Export results to Excel
- Clear filters and auto-load data on startup
- Full navigation via MenuStrip

## 🗃️ Database Structure

The application connects to a SQL Server database `DiagnosticLab` with the following main tables:

- `TestType(TestTypeID, Name, BasePrice)`
- `Technician(TechnicianID, FirstName, LastName, Certification)`
- `SampleType(SampleTypeID, Description, ContainerType, ...)`
- `LabTestRecord` – main table that references the others:
  - Foreign keys to `TestType`, `Technician`, `SampleType`
  - Includes `PatientName`, `TestDate`, `FinalPrice`, `ResultSummary`

## 🧾 Stored Procedures

SQL stored procedures are used throughout the application:

- `sp_TestType_Insert`, `sp_TestType_Update`, `sp_TestType_Delete`, `sp_TestType_Select`
- `sp_LabTest_Insert`, `sp_LabTest_Update`, `sp_LabTest_Delete`, `sp_GetAllLabTests`
- Similar procedures for `Technician` and `SampleType`

## ▶️ How to Run

1. Open the `DiagnosticLab.sln` solution in Visual Studio
2. Ensure you have a local SQL Server instance and the `DiagnosticLab` database created
3. Update the connection string in the code files if needed
4. Build and run the project (F5)

## 🖼️ Forms Overview

- `MainForm.cs` – main menu navigation
- `frmTestType`, `frmTechnician`, `frmSampleType` – forms for managing reference data
- `frmLabTestRecord` – main interface for lab test records with related data
- `frmByOneParam` – search by single keyword across all relevant fields
- `frmByMoreParam` – search using multiple filters and export to Excel

## ⚙️ Requirements

- Visual Studio with .NET Framework 4.8
- SQL Server (Express or higher)
- Microsoft Excel (for export functionality)
- Reference to `Microsoft.Office.Interop.Excel`
