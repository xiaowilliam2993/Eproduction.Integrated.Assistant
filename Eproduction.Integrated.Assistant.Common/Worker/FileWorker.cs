using Microsoft.VisualBasic.FileIO;
using NLog;
using SharpCompress.Archives;
using SharpCompress.Readers;
using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace Eproduction.Integrated.Assistant.Common.Worker {
    public static class FileWorker {
        public enum FileStatus {
            /// <summary>
            /// 文件不存在
            /// </summary>
            NotExists = 0,
            /// <summary>
            /// 文件被占用
            /// </summary>
            Occupied = 1,
            /// <summary>
            /// 正常状态
            /// </summary>
            Normal = 2
        }
        [DllImport("kernel32.dll")]
        private static extern IntPtr _lopen(string lpPathName, int iReadWrite);
        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);
        private const int OF_READWRITE = 2;
        private const int OF_SHARE_DENY_NONE = 0x40;
        private static readonly IntPtr HFILE_ERROR = new IntPtr(-1);
        public static FileStatus FileIsOpen(string fileFullName) {
            if (!File.Exists(fileFullName)) {
                return FileStatus.NotExists;
            }
            IntPtr handle = _lopen(fileFullName, OF_READWRITE | OF_SHARE_DENY_NONE);
            if (handle == HFILE_ERROR) {
                return FileStatus.Occupied;
            }
            CloseHandle(handle);
            return FileStatus.Normal;
        }
        public static void ReleaseOccupancy(string fileFullName) {
            IntPtr handle = _lopen(fileFullName, OF_READWRITE | OF_SHARE_DENY_NONE);
            if (handle == HFILE_ERROR) {
                CloseHandle(handle);
            }
        }
        public static void SetReadyOnly(string fileFullName) {
            if (string.IsNullOrEmpty(fileFullName)) return;

            try {
                FileStatus status = FileIsOpen(fileFullName);
                switch (status) {
                    case FileStatus.NotExists:
                        throw new Exception(fileFullName + " 文件不存在");
                    case FileStatus.Occupied:
                        throw new Exception(fileFullName + " 文件被占用");
                }
                File.SetAttributes(fileFullName, FileAttributes.ReadOnly);
            } catch (Exception) { throw; }
        }
        public static void RemoveReadyOnly(string fileFullName) {
            if (string.IsNullOrEmpty(fileFullName)) return;

            try {
                FileStatus status = FileIsOpen(fileFullName);
                switch (status) {
                    case FileStatus.NotExists:
                        throw new Exception(fileFullName + " 文件不存在");
                    case FileStatus.Occupied:
                        throw new Exception(fileFullName + " 文件被占用");
                }
                File.SetAttributes(fileFullName, FileAttributes.Normal);
            } catch (Exception) { throw; }
        }
        public static void SetAccessControl(string path, params string[] users) {
            if (File.Exists(path)) {
                FileInfo dataFi = new FileInfo(path);
                FileSecurity fileSecurity = dataFi.GetAccessControl();
                fileSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                fileSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
                if (users != null && users.Length > 0) {
                    foreach (var user in users) {
                        fileSecurity.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.FullControl, AccessControlType.Allow));
                    }
                }
                dataFi.SetAccessControl(fileSecurity);
            } else if (Directory.Exists(path)) {
                DirectoryInfo dirFi = new DirectoryInfo(path);
                DirectorySecurity dirSecurity = dirFi.GetAccessControl();
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                dirSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow));
                dirSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow));
                if (users != null && users.Length > 0) {
                    foreach (var user in users) {
                        dirSecurity.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow));
                    }
                }
                dirFi.SetAccessControl(dirSecurity);
            }
        }
        public static void SetAccessControl(string path, string userName, bool assignToAllUsers = true) {
            if (File.Exists(path)) {
                FileInfo dataFi = new FileInfo(path);
                FileSecurity fileSecurity = dataFi.GetAccessControl();
                fileSecurity.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Allow));
                dataFi.SetAccessControl(fileSecurity);
            } else if (Directory.Exists(path)) {
                DirectoryInfo dirFi = new DirectoryInfo(path);
                DirectorySecurity dirSecurity = dirFi.GetAccessControl(AccessControlSections.All);
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                dirSecurity.AddAccessRule(new FileSystemAccessRule(userName, FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow));
                dirFi.SetAccessControl(dirSecurity);
            }
            if (assignToAllUsers) {
                SetAccessControl(path);
            }
        }
        public static void SecurityDelete(string fullPath) {
            try {
                if (File.Exists(fullPath)) {
                    FileSystem.DeleteFile(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                } else if (Directory.Exists(fullPath)) {
                    FileSystem.DeleteDirectory(fullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
            } catch(Exception) {
                throw;
            }
        }
        public static void CompressionZip(string directoryPath, string zipArchiveFullName) {
            ZipFile.CreateFromDirectory(directoryPath, zipArchiveFullName, CompressionLevel.Optimal, true, Encoding.UTF8);
        }
        public static bool DecompressionZip(string zipFullPath, string destination) {
            return DecompressionZip(zipFullPath, destination, true);
        }
        public static bool DecompressionZip(string zipFullPath, string destination, bool ignoreError) {
            return DecompressionZip(zipFullPath, destination, ignoreError, null);
        }
        public static bool DecompressionZip(string zipFullPath, string destination, bool ignoreError, Logger Logger) {
            bool cancel = true; 
            using (var archive = ArchiveFactory.Open(zipFullPath)) {
                foreach (var entry in archive.Entries) {
                    if (!entry.IsDirectory) {
                        try {
                            entry.WriteToDirectory(destination, new ExtractionOptions() {
                                ExtractFullPath = true, Overwrite = true
                            });
                        } catch (Exception ex) {
                            cancel = true;
                            if (Logger != null) {
                                Logger.Error(ex);
                            }
                            if (!ignoreError) {
                                break;
                            }
                        }
                    }
                }
            }
            return cancel;
        }
        public static void GenerateInstallbat(string directoryPath, string programName, string serviceName) {
            string filePath = Path.Combine(directoryPath, BatConstants.Install);
            StringBuilder content = new StringBuilder();
            content.AppendLine(@"%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe " + programName);
            content.AppendLine("sc start " + serviceName);
            CreateFile(filePath, content.ToString());
        }
        public static void GenerateUninstallbat(string directoryPath, string programName, string serviceName) {
            string filePath = Path.Combine(directoryPath, BatConstants.Uninstall);
            StringBuilder content = new StringBuilder();
            content.AppendLine("sc stop " + serviceName);
            content.AppendLine(@"%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u " + programName);
            CreateFile(filePath, content.ToString());
        }
        public static void GenerateUnlockbat(string directoryPath) {
            string filePath = Path.Combine(directoryPath, BatConstants.Unlock);
            string content = "streams.exe /s /d";
            CreateFile(filePath, content);
        }
        public static void CreateFile(string filePath, string content) {
            try {
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                    using (var streamWrite = new StreamWriter(fileStream)) {
                        streamWrite.Write(content);
                        streamWrite.Close();
                    }
                    fileStream.Close();
                }
            } catch (Exception) {
                throw;
            }
        }
        public static void CopyDirectory(DirectoryInfo sourceFolder, DirectoryInfo destFolder, bool overwrite = true) {
            CopyDirectory(sourceFolder.FullName, destFolder.FullName, overwrite);
        }
        public static void CopyDirectory(string sourceFolder, string destFolder, bool overwrite = true) {
            try {
                var sourceFilesPath = Directory.GetFileSystemEntries(sourceFolder);
                for (int i = 0; i < sourceFilesPath.Length; i++) {
                    var sourceFilePath = sourceFilesPath[i];
                    var directoryName = Path.GetDirectoryName(sourceFilePath);
                    var forlders = directoryName.Split('\\');
                    var lastDirectory = forlders[forlders.Length - 1];
                    var dest = Path.Combine(destFolder, lastDirectory);
                    if (File.Exists(sourceFilePath)) {
                        var sourceFileName = Path.GetFileName(sourceFilePath);
                        if (!Directory.Exists(dest)) {
                            Directory.CreateDirectory(dest);
                        }
                        File.Copy(sourceFilePath, Path.Combine(dest, sourceFileName), overwrite);
                    } else {
                        CopyDirectory(sourceFilePath, dest, overwrite);
                    }
                }
            } catch (Exception) { throw; }
        }
        public static void CopyFile(string sourceFile, string destination, bool overwrite = true) {
            FileInfo fileInfo = new FileInfo(destination);
            if (!fileInfo.Directory.Exists) {
                fileInfo.Directory.Create();
            }
            FileSystem.CopyFile(sourceFile, destination, overwrite);
        }
    }
    public class BatConstants {
        public const string Install = "Install.bat";
        public const string Uninstall = "Uninstall.bat";
        public const string Unlock = "Unlock.bat";
    }
    public class SystemAccountManager {
        public const string IIS_IUSRS = "IIS_IUSRS";
    }
}
