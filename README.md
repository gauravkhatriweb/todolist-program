# 📝 To-Do List Console Application

A simple yet powerful console-based task management application built with C# and .NET Framework. This application provides an intuitive command-line interface for managing your daily tasks with essential CRUD operations.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue)
![C#](https://img.shields.io/badge/C%23-Console%20App-purple)
![License](https://img.shields.io/badge/License-MIT-green)
![Version](https://img.shields.io/badge/Version-1.0.0-orange)

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Code Example](#code-example)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [Roadmap](#roadmap)
- [License](#license)
- [Contact](#contact)

## 🎯 Overview

This To-Do List Console Application is designed for users who prefer command-line interfaces for task management. It offers a clean, distraction-free environment to manage your tasks efficiently. The application runs entirely in the console, making it lightweight and fast.

**Key Highlights:**
- ⚡ Fast and lightweight console application
- 🎨 Clean and intuitive user interface
- 🔧 Simple CRUD operations for task management
- 💾 In-memory task storage during runtime
- 🖥️ Cross-platform compatibility (Windows, Linux, macOS)

## ✨ Features

### Core Functionality
- **📖 View Tasks**: Display all tasks with their completion status in a formatted list
- **➕ Add Task**: Create new tasks with custom descriptions
- **✅ Complete Task**: Mark tasks as complete with visual indicators
- **🚪 Exit**: Clean application termination

### User Experience
- **🎯 Numbered Menu System**: Easy navigation with numeric options
- **🔄 Real-time Updates**: Immediate reflection of changes
- **❌ Input Validation**: Robust error handling for invalid inputs
- **🧹 Clear Console**: Clean interface with screen clearing between operations

### Technical Features
- **🏗️ Object-Oriented Design**: Well-structured code with separate Task class
- **📊 List Management**: Dynamic task storage using Generic Lists
- **🛡️ Error Handling**: Comprehensive input validation and error messages

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- **Operating System**: Windows 10/11, macOS 10.12+, or Linux
- **.NET Framework**: Version 4.7.2 or higher
- **Development Environment** (optional): Visual Studio 2019+ or Visual Studio Code
- **Command Line**: Terminal or Command Prompt access

### Checking Your .NET Installation

```bash
# Check if .NET Framework is installed (Windows)
reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\" /v Release

# For cross-platform .NET Core/5+ compatibility
dotnet --version
```

## 🚀 Installation

### Method 1: Clone and Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/gauravkhatriweb/todolist-program.git
   cd todolist-program
   ```

2. **Build the application**:
   ```bash
   dotnet build
   ```

3. **Run the application**:
   ```bash
   dotnet run --project todolist-program
   ```

### Method 2: Direct Compilation

1. **Navigate to the project directory**:
   ```bash
   cd todolist-program
   ```

2. **Compile using MSBuild**:
   ```bash
   msbuild todolist-program.csproj
   ```

3. **Run the executable**:
   ```bash
   # Windows
   .\bin\Debug\todolist-program.exe
   
   # Linux/macOS (with Mono)
   mono ./bin/Debug/todolist-program.exe
   ```

## 📖 Usage

### Getting Started

1. Launch the application using one of the installation methods above
2. You'll see the main menu with numbered options
3. Enter the number corresponding to your desired action
4. Follow the on-screen prompts

### Menu Options

```
To-Do List Application
======================
1. View Tasks
2. Add Task
3. Complete Task
4. Exit
Choose an option: 
```

### Detailed Usage Examples

#### Adding a Task
```
Choose an option: 2

Add a New Task
==============
Enter task description: Complete project documentation
Task added successfully!
Press any key to return to the main menu.
```

#### Viewing Tasks
```
Choose an option: 1

To-Do List
==========
1. [ ] Complete project documentation
2. [X] Review pull requests
3. [ ] Update README file

Press any key to return to the main menu.
```

#### Completing a Task
```
Choose an option: 3

Complete a Task
===============
1. [ ] Complete project documentation
2. [X] Review pull requests
3. [ ] Update README file

Enter the number of the task to complete: 1
Task marked as complete!
Press any key to return to the main menu.
```

### Visual Indicators

- `[ ]` - Incomplete task
- `[X]` - Completed task
- Numbers indicate task position in the list

## 📁 Project Structure

```
todolist-program/
├── 📄 Program.cs              # Main application logic and entry point
├── 📄 todolist-program.csproj # Project configuration and dependencies
├── 📄 App.config              # Application configuration file
├── 📁 Properties/
│   └── 📄 AssemblyInfo.cs     # Assembly metadata and version info
├── 📁 bin/                    # Compiled binaries (generated)
└── 📁 obj/                    # Build artifacts (generated)
```

### Key Files Description

- **Program.cs**: Contains the main application logic, menu system, and Task class definition
- **todolist-program.csproj**: MSBuild project file defining dependencies and build configuration
- **App.config**: Runtime configuration settings
- **AssemblyInfo.cs**: Assembly metadata including version and copyright information

## 💻 Code Example

Here's a glimpse of the Task class structure:

```csharp
// Class to represent a task
class Task
{
    // Task description
    public string Description { get; set; }
    // Task completion status
    public bool IsComplete { get; set; }
}

// Example usage
List<Task> tasks = new List<Task>();
tasks.Add(new Task { Description = "Learn C#", IsComplete = false });
```

## 🛠️ Technologies Used

| Technology | Version | Purpose |
|-----------|---------|---------|
| **C#** | Latest | Primary programming language |
| **.NET Framework** | 4.7.2 | Runtime framework |
| **System.Collections.Generic** | Built-in | List management |
| **Console API** | Built-in | User interface |
| **MSBuild** | 15.0+ | Build system |

### Dependencies

This application uses only built-in .NET Framework libraries:
- `System`
- `System.Collections.Generic`
- `System.Core`
- `System.Xml.Linq`
- `System.Data.DataSetExtensions`
- `Microsoft.CSharp`

## 🤝 Contributing

Contributions are welcome and appreciated! Here's how you can contribute:

### Ways to Contribute

1. **🐛 Bug Reports**: Report issues via GitHub Issues
2. **✨ Feature Requests**: Suggest new features or improvements
3. **📝 Documentation**: Improve documentation and examples
4. **🔧 Code Contributions**: Submit pull requests with enhancements

### Development Setup

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/amazing-feature`
3. Make your changes and test thoroughly
4. Commit your changes: `git commit -m 'Add amazing feature'`
5. Push to the branch: `git push origin feature/amazing-feature`
6. Open a Pull Request

### Coding Standards

- Follow C# naming conventions
- Add comments for complex logic
- Ensure backward compatibility
- Test all changes thoroughly

## 🗺️ Roadmap

Future enhancements planned for this application:

- [ ] **Data Persistence**: Save tasks to file system
- [ ] **Task Categories**: Organize tasks by categories
- [ ] **Due Dates**: Add deadline functionality
- [ ] **Priority Levels**: High/Medium/Low priority system
- [ ] **Search & Filter**: Find tasks quickly
- [ ] **Export Options**: Export tasks to different formats
- [ ] **Configuration File**: Customizable application settings
- [ ] **Task History**: Track completed tasks over time

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](https://choosealicense.com/licenses/mit/) for details.

### MIT License Summary

- ✅ Commercial use
- ✅ Modification
- ✅ Distribution
- ✅ Private use
- ❌ No Liability
- ❌ No Warranty

## 📧 Contact

**Gaurav Khatri** - Project Creator & Maintainer

- **Email**: [gauravkhatriweb@gmail.com](mailto:gauravkhatriweb@gmail.com)
- **GitHub**: [@gauravkhatriweb](https://github.com/gauravkhatriweb)
- **Project Link**: [https://github.com/gauravkhatriweb/todolist-program](https://github.com/gauravkhatriweb/todolist-program)

---

<div align="center">

**⭐ Star this repository if you found it helpful!**

Made with ❤️ by [Gaurav Khatri](https://github.com/gauravkhatriweb)

</div>
