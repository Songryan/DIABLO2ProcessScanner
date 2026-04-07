using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DIABLO2ProcessScanner
{
    public class MemoryService
    {
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] buffer,
            int size,
            out int bytesRead
        );

        public Process TargetProcess { get; private set; }

        public void Attach(Process process)
        {
            TargetProcess = process;
        }

        public int ReadInt32(IntPtr address)
        {
            if (TargetProcess == null)
                throw new Exception("프로세스 연결 안됨");

            byte[] buffer = new byte[4];
            ReadProcessMemory(TargetProcess.Handle, address, buffer, 4, out _);

            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
