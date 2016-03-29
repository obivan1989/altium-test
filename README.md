# altium-test

## Assemblies:
* **AltiumTest.Engine** - classes for scan and compare files with equal size;
* **AltiumTest.Console** - console application, search qual files for single directory;
* **AltiumTest.WinForms** - winforms application, search qual files for lsit of directories, select byte array comparsion algorithm, calculates elapsed time for operations, show results in grid.

### AltiumTest.Engine:
* [```public static async Task<List<IFileOptions>> GetFiles(DirectoryInfo dir)```](https://github.com/obivan1989/altium-test/blob/master/AltiumTest.Engine/FileReader.cs#L22) - find files in dir and subdirectories;
* [```public static async Task<List<List<IFileOptions>>> GetGroups(IEnumerable<IFileOptions> files, IByteArrayComparer comparer)```](https://github.com/obivan1989/altium-test/blob/master/AltiumTest.Engine/FileComparer.cs#L23) - group files with identical content;
* [```bool IByteArrayComparer.Compare(byte[] left, byte[] right)```](https://github.com/obivan1989/altium-test/blob/master/AltiumTest.Engine/Interfaces/IByteArrayComparer.cs#L25) - compares two byte arrays(GetGroups read them from file stream).
