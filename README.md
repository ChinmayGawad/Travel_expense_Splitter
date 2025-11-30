Travel Expense Splitter

A Windows Forms (.NET) application that helps users manage trips, add members, record expenses, and automatically split the total cost among participants.
The project uses a structured architecture with adapter/helper classes for database operations, session management, and validation.


---

🚀 Features

✔ Trip Management

Create new trips

View trip dashboards

Add or remove members

Track all expenses linked to a trip


✔ Expense Tracking

Add expenses with amount, payer, and description

Automatically calculate each member’s share

Generate balance summaries


✔ User-Friendly UI

Multiple forms (Dashboards, Add Trip, Add Members, Expense Forms)

Clean Windows Forms design

Integrated image resources for UI enhancement


✔ Data Handling

Local database operations through:

DatabaseHelper.cs

DatabaseOperations.cs

ExpenseAdapter.cs


Input validation via ValidationHelper.cs

Session state handling using UserSession.cs



---

📁 Project Structure

Travel_expense_Splitter/
│
├── Add_members.cs / .Designer.cs / .resx
├── DashBoard.resx
├── Form1 / Form2 (main UI forms)
├── addTrip.cs / .resx
│
├── Adapter/
│   ├── DatabaseHelper.cs
│   ├── DatabaseOperations.cs
│   ├── ExpenseAdapter.cs
│   ├── UserSession.cs
│   └── ValidationHelper.cs
│
├── Properties/
│   ├── Resources.resx
│   ├── Settings.settings
│   └── AssemblyInfo.cs
│
├── Resources/ (images, wallpapers)
│
├── App.config
└── Travel_expense_Splitter.sln


---

🛠 Technologies Used

C# (.NET Framework)

Windows Forms

SQL Database (Local)

Resource-managed images and assets



---

📦 Installation & Setup

1. Clone the Repository

git clone <your-repo-url>

2. Open the Solution

Open Travel_expense_Splitter.sln in Visual Studio.

3. Restore Dependencies

No special external dependencies are required beyond .NET Framework.

4. Run the Application

Press F5 to build and run.


---

🧩 How It Works

1. Create a Trip

Enter a trip name → Add members → Proceed to trip dashboard.

2. Add Expenses

For each expense:

Select payer

Enter amount & reason

Save → System recalculates balance


3. View Splits

Dashboard displays:

Who paid what

How much each person owes or is owed



---

🗂 Key Classes & Responsibilities

Class	Responsibility

DatabaseHelper	Establish DB connection
DatabaseOperations	CRUD operations
ExpenseAdapter	Expense formatting & handling
UserSession	Tracks active user/session info
ValidationHelper	Input validation routines
Add_members	Add, update, remove trip members
addTrip	UI for creating new trips



---

📸 Resources

The Resources/ folder contains multiple background images and wallpapers used for UI design.


---

🤝 Contributing

Pull requests are welcome!
Feel free to improve UI, add reporting features, or enhance DB operations.


---

📜 License

This project is currently unlicensed.
Add your preferred license if needed.
