# 🗂️ Project Structure – PrintTreeProject

## 🛠️ Type: C# Console Application

---

## 📁 Main Folders & Responsibilities

### 📄 Program.cs  
> Entry point of the application. Responsible for launching the CLI flow.

---

### 📁 Parsers/  
> Responsible for parsing and organizing the command-line arguments (`args[]`).

- Converts user input into structured settings or options.
- Handles validation of argument format and supported commands.
- Example files:
  - `ArgumentParser.cs`
  - `Settings.cs`
  - `ArgumentValidator.cs` (optional)

---

### 📁 Paths/  
> Deals with analyzing and resolving file system paths.

- Determines current or target directories.
- Handles edge cases like non-existent folders or `.git` presence.
- Example files:
  - `PathResolver.cs`

---

### 📁 Core/  
> Core logic of the program: builds and prints the directory tree.

- Scans folders and files.
- Builds tree structure.
- Outputs the structure to the console.
- Example files:
  - `TreeBuilder.cs`
  - `TreePrinter.cs`

---

### 📁 Storing/  
> Responsible for storing or exporting output.

- Saves results to text or log files if required.
- Can be extended for JSON/CSV output or logging.
- Example files:
  - `OutputWriter.cs`
  - `Logger.cs`

---

## 🧭 Flow Overview

```text
args[] 
  ↓
Parsers/ → Produces Settings/Options
  ↓
Routes/ → Get Information Dectionry from Parser and select the right Processing.
  ↓
Processing/ → Builds and prints the folder/file tree
  ↓
Storing/ (optional) → Saves output to file or log
