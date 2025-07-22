# 🌳 Features of PrintTree Project

---

## 1️⃣ Command-Line Options

| Command                | Description                                        |
|------------------------|----------------------------------------------------|
| `printtree --help`     | Displays all available commands and their usage.   |
| `printtree --version`  | Displays the version of the program.               |

---

## 2️⃣ Core Functionalities

- ✅ `printtree -s` **or simply** `printtree`  
  > Prints the folders and files from the current directory down to the deepest level.

- ✅ `printtree -s -g`  
  > Prints the full directory structure including hidden `.git` folders (if found).

- ✅ `printtree -s -f "FolderName"` **or** `printtree -s --folder "FolderName"`  
  > Prints the structure of the specified folder only.

---

📝 Notes:
- `-s` stands for **scan** – it's required to trigger the tree printing.
- `-g` includes **git-related** folders in the output.
- `-f` or `--folder` specifies a target folder instead of the current directory.

---

🔧 *Future commands like exporting to file, filtering by extension, or colored output could be added here later.*
