# altium-test

## Assemblies:
* **AltiumTest.Engine** - classes for scan and compare files with equal size;
* **AltiumTest.Console** - console application, search qual files for single directory;
* **AltiumTest.WinForms** - winforms application, search qual files for lsit of directories, select byte array comparsion algorithm, calculates elapsed time for operations, show results in grid.

### AltiumTest.Engine:
```csharp
public static async Task<List<IFileOptions>> GetFiles(DirectoryInfo dir) - find files in dir and subdirectories.
public static async Task<List<List<IFileOptions>>> GetGroups(IEnumerable<IFileOptions> files, IByteArrayComparer comparer) - group files with identical content.
bool IByteArrayComparer.Compare(byte[] left, byte[] right) - compares two byte arrays(GetGroups read them from file stream).
```
