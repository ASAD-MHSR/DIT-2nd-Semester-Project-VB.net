# 📞 Contact Management System

A simple and user-friendly Contact Management System built with **Visual Basic .NET (VB.NET)** and **Windows Forms**. This application allows users to store, view, and manage contact information including names, phone numbers, and email addresses.

![VB.NET](https://img.shields.io/badge/VB.NET-007ACC?style=for-the-badge&logo=.net&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

---

## ✨ Features

- ✅ **Add Contacts** - Store contact information (Name, Phone, Email)
- ✅ **Input Validation** - Ensures all fields are filled before adding
- ✅ **Contact List Display** - View all contacts in organized list format
- ✅ **Clear Fields** - Quickly clear input fields for new entries
- ✅ **User-Friendly Interface** - Clean and intuitive design
- ✅ **Status Feedback** - Real-time status updates
- ✅ **Exit Confirmation** - Prevents accidental application closure

---

## 📸 Screenshots

### Main Interface
The application provides a clean interface with three input fields and action buttons.

### Adding Contacts
Users can add contacts by filling all three fields (Name, Phone, Email) and clicking "Add Contact".

### Contact List
All contacts are displayed in the format: `Name | Phone | Email`

---

## 🚀 Getting Started

### Prerequisites

- **Operating System:** Windows 7 or later
- **.NET Framework:** 4.5 or later (usually pre-installed on Windows 10/11)
- **Development IDE:** Visual Studio 2019 or later (for building from source)

### Installation

#### Option 1: Download Pre-built Executable
1. Download the latest release from the [Releases](../../releases) section
2. Extract the files
3. Run `ContactManager.exe`

#### Option 2: Build from Source

1. **Clone the repository**
   ```bash
   git clone https://github.com/ASAD-MHSR/contact-manager.git
   cd contact-manager
   ```

2. **Open in Visual Studio**
   - Open `ContactManager.sln` in Visual Studio
   - Restore NuGet packages (if any)

3. **Build the project**
   - Press `Ctrl + Shift + B` or
   - Go to `Build` → `Build Solution`

4. **Run the application**
   - Press `F5` or
   - Go to `Debug` → `Start Debugging`
   - Executable will be in `bin\Release\net6.0-windows\ContactManager.exe`

---

## 📖 How to Use

1. **Launch the Application**
   - Double-click `ContactManager.exe` or run from Visual Studio

2. **Add a Contact**
   - Enter **Name** in the first field
   - Enter **Phone Number** in the second field
   - Enter **Email** in the third field
   - Click **"Add Contact"** button (Black button)
   - A success message will appear
   - Contact will be added to the list below

3. **View Contacts**
   - All contacts are displayed in the list box
   - Format: `Name | Phone | Email`
   - Scroll to view more contacts

4. **Clear Fields**
   - Click **"Clear"** button (Orange button)
   - All input fields will be cleared
   - Cursor will move to Name field

5. **Exit Application**
   - Click **"Exit"** button (Red button)
   - Confirm exit when prompted

---

## 🛠️ Technologies Used

- **Language:** Visual Basic .NET (VB.NET)
- **Framework:** .NET Framework 4.5+ / .NET 6.0+
- **UI Technology:** Windows Forms
- **IDE:** Visual Studio

---

## 📁 Project Structure

```
ContactManager/
│
├── Form1.vb              # Main form logic and event handlers
├── Form1.Designer.vb     # UI design and component initialization
├── Program.vb            # Application entry point
├── ContactManager.vbproj # Project file
├── ContactManager.sln    # Solution file
└── README.md            # This file
```

---

## 💻 Code Structure

### Main Components

- **Form1.vb** - Contains all event handlers:
  - `Form1_Load` - Initializes the form
  - `btnAdd_Click` - Handles contact addition with validation
  - `btnClear_Click` - Clears all input fields
  - `btnExit_Click` - Handles application exit with confirmation

- **Form1.Designer.vb** - Contains UI component definitions:
  - Labels (Name, Phone, Email)
  - TextBoxes (txtName, txtPhone, txtEmail)
  - Buttons (btnAdd, btnClear, btnExit)
  - ListBox (lstContacts)
  - Status Label (lblStatus)

---

## 🔧 Requirements

### Minimum Requirements
- **Processor:** 1.0 GHz or higher
- **RAM:** 512 MB
- **Storage:** 50 MB free space
- **OS:** Windows 7 or later
- **.NET Framework:** 4.5 or later

### Recommended Requirements
- **Processor:** 2.0 GHz or higher
- **RAM:** 2 GB or higher
- **Storage:** 500 MB free space
- **OS:** Windows 10/11
- **.NET Framework:** 6.0 or later

---

## 🎯 Features in Detail

### Input Validation
- Checks if all three fields are filled
- Shows error message if any field is empty
- Updates status bar with error information

### Contact Display Format
- Contacts are displayed as: `Name | Phone | Email`
- Example: `John Doe | 1234567890 | john@example.com`

### User Feedback
- Success messages when contact is added
- Error messages for validation failures
- Status bar updates for all operations
- Confirmation dialog before exit

---

## 📝 Example Usage

```
1. Enter Name: "Ali"
2. Enter Phone: "1234567890"
3. Enter Email: "ali@email.com"
4. Click "Add Contact"
5. Contact appears in list: "Ali | 1234567890 | ali@email.com"
```

---

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

## 👤 Author

**Your Name**
- GitHub: [@ASAD-MHSR](https://github.com/ASAD-MHSR)
- Email: your.email@example.com

---

## 🙏 Acknowledgments

- Microsoft for VB.NET and Windows Forms framework
- Visual Studio Community for the development environment
- All contributors and users of this project

---

## 📊 Project Status

✅ **Status:** Complete and Functional

- ✅ All core features implemented
- ✅ Input validation working
- ✅ User interface complete
- ✅ Error handling implemented

---

## 🐛 Known Issues

- Data is stored in memory only (not persistent)
- No search or filter functionality
- No edit or delete options for existing contacts

---

## 🔮 Future Enhancements

- [ ] Database integration for persistent storage
- [ ] Search and filter functionality
- [ ] Edit and delete contact options
- [ ] Data export/import features
- [ ] Contact categories and groups
- [ ] Data backup and restore functionality

---

## 📞 Support

If you have any questions or issues, please open an [Issue](../../issues) on GitHub.

---

## ⭐ Star History

If you find this project useful, please consider giving it a star ⭐!

---

**Made with ❤️ using VB.NET and Windows Forms**
