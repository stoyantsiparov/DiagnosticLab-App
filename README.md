
# DiagnosticLab – Windows Forms App (.NET Framework 4.8)

**DiagnosticLab** е десктоп приложение, създадено с Windows Forms и SQL Server, предназначено за управление на лабораторни тестове, проби и лабораторни техници.

## 🧪 Основни функционалности

- CRUD операции за:
  - Видове тестове (TestType)
  - Лаборанти (Technician)
  - Проби (SampleType)
  - Записи за лабораторни тестове (LabTestRecord)
- Търсене:
  - По една стойност в няколко свързани таблици (frmByOneParam)
  - По множество параметри и дати (frmByMoreParam)
- Експорт на резултати в Excel
- Изчистване на филтри и автоматично зареждане на данни
- MenuStrip навигация към всички форми

## 🗃️ База данни

Проектът използва база `DiagnosticLab`, която съдържа следните таблици:

- `TestType(TestTypeID, Name, BasePrice)`
- `Technician(TechnicianID, FirstName, LastName, Certification)`
- `SampleType(SampleTypeID, Description, ContainerType, ...)`
- `LabTestRecord` – основна таблица със:
  - FK към всички останали
  - `PatientName`, `TestDate`, `FinalPrice`, `ResultSummary`

## 🧾 Stored Procedures

Използвани са SQL процедури за всяка таблица:

- `sp_TestType_Insert`, `sp_TestType_Update`, `sp_TestType_Delete`, `sp_TestType_Select`
- `sp_LabTest_Insert`, `sp_LabTest_Update`, `sp_LabTest_Delete`, `sp_GetAllLabTests`
- Аналогично за `Technician` и `SampleType`

## ▶️ Стартиране

1. Отвори решението `DiagnosticLab.sln` в Visual Studio
2. Увери се, че имаш SQL Server и създадена база `DiagnosticLab`
3. Конфигурирай `connectionString` в `.cs` файловете, ако е нужно
4. Стартирай проекта (F5)

## 🖼️ Форми и интерфейс

- `MainForm.cs` – централна навигация
- `frmTestType`, `frmTechnician`, `frmSampleType` – форми за CRUD
- `frmLabTestRecord` – главна форма с комбинирани данни
- `frmByOneParam` – търсене по ключова дума
- `frmByMoreParam` – търсене по няколко филтъра + експорт

## ⚙️ Изисквания

- Visual Studio с .NET Framework 4.8
- SQL Server (Express или Standard)
- Microsoft Excel (за експорта)
- Microsoft.Office.Interop.Excel (добавена през References)

---

✅ Проектът е напълно завършен и отговаря на всички критерии от заданията.
