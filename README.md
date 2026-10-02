# Barcode File Search

A simple WPF application to search and open directories within a `datasheets` folder.

## Description

Barcode File Search is a lightweight desktop application designed to help users quickly locate and open directories containing barcode-related datasheets. The application scans the `datasheets` directory (located in the same folder as the executable) for subdirectories matching the user's input and allows opening the selected directory in Windows Explorer with a double-click.

## Features

- Real-time directory search as you type
- Double-click to open the selected directory in Windows Explorer
- Clear button to reset the search
- Simple and intuitive user interface

## Prerequisites

- Windows operating system
- .NET 8.0 Windows Desktop or later

## How to Run

1. **Clone the repository** (if you haven't already):
   ```bash
   git clone https://github.com/yourusername/BarcodeFileSearch.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd BarcodeFileSearch
   ```

3. **Build the solution** (using Visual Studio, MSBuild, or .NET CLI):
   - Open `BarcodeFileSearch.sln` in Visual Studio 2022 (17.4+) and press `F5` to run, or
   - Use MSBuild:
     ```bash
     msbuild BarcodeFileSearch.sln /p:Configuration=Release
     ```
   - Or use .NET CLI:
     ```bash
     dotnet build -c Release
     ```

4. **Run the application**:
   - The executable will be located at `BarcodeFileSearch\bin\Release\net8.0-windows\BarcodeFileSearch.exe` (after a release build) or `BarcodeFileSearch\bin\Debug\net8.0-windows\BarcodeFileSearch.exe` (after a debug build).
   - Double-click the executable to run.

## How to Use

1. **Ensure the `datasheets` folder exists**:
   - The application expects a folder named `datasheets` in the same directory as the executable.
   - Place your barcode datasheet directories inside this `datasheets` folder.

2. **Search for a directory**:
   - Type part or all of the directory name in the text box at the top.
   - As you type, the list box below will update to show matching directories from the `datasheets` folder.

3. **Open a directory**:
   - Double-click on a directory in the list box to open it in Windows Explorer.

4. **Clear the search**:
   - Click the "Clear" button to reset the text box and list box.

## Project Structure

```
BarcodeFileSearch/
├── BarcodeFileSearch.sln          # Visual Studio solution file
├── BarcodeFileSearch/             # Main project directory
│   ├── App.xaml                   # Application definition
│   ├── App.xaml.cs                # Application code-behind
│   ├── MainWindow.xaml            # Main window UI
│   ├── MainWindow.xaml.cs         # Main window logic
│   ├── BarcodeFileSearch.csproj   # Project file
│   ├── App.config                 # Application configuration
│   └── Properties/                # Assembly properties
│       ├── AssemblyInfo.cs
│       ├── Resources.Designer.cs
│       ├── Resources.resx
│       ├── Settings.Designer.cs
│       └── Settings.settings
└── README.md                      # This file
```

## Notes

- The application searches only for directories (not files) within the `datasheets` folder.
- The search is case-insensitive and matches any part of the directory name.
- The application now automatically looks for the `datasheets` folder in the same directory as the executable.
- If the `datasheets` folder does not exist, the application will not show any results in the list box (no error will be thrown).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details (if applicable).

## Acknowledgments

- Built with Windows Presentation Foundation (WPF) and .NET 8.0 Windows Desktop.