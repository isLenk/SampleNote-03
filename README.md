# SampleNote v3
A C# .NET based CRUD application that manages sample data.
Initially developed by Lance Talban on December 20. Afterwards, two more versions have been made to improve the overall functionality. 

Created on request from my father in order to streamline the labs sample analysis process. As of 2022, the newest one created in Appsheet is currently maintained by the company. 

This version provides the option of using either an Excel Spreadsheet document to store data or SQLite.

I am unable to share the source code of the latest version and as such, will list the features that the newer versions (and possibly this one) contain:

# Features
- SQLite, Excel to act as databases.
  - Latest uses PostgreSQL hosted in the companies IT building
- Document generator. 
  - Automatically creates a professional document with the contents filled with data provided
- DYMO LabelWriter Link
  - The option to print a customizable label, used as notes for soil samples.
  - Appsheet version uses a locally hosted webserver to allow print requests)
- A control screen and a display screen.
  - The control screen allows the modification of data and the display is a replica which can be put on a larger screen.
- Professional but user friendly interface built using C#.Forms
