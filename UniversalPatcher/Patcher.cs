using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace UniversalPatcher
{
    public class Patcher
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("TitanEngine.dll")]
        static extern bool AttachDebugger(int ProcessId, bool KillOnExit, out PROCESS_INFORMATION DebugInfo, IntPtr CallBack);

        [DllImport("TitanEngine.dll")]
        static extern bool DetachDebugger(int ProcessId);

        [DllImport("TitanEngine.dll")]
        static extern bool MemoryWriteSafe(int hProcess, int lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("TitanEngine.dll")]
        static extern IntPtr FindEx(int hProcess, IntPtr MemoryStart, int MemorySize, byte[] SearchPattern, int PatternSize, byte[] WildCard);

        [DllImport("TitanEngine.dll")]
        static extern bool PatchEx(int hProcess, IntPtr MemoryStart, int MemorySize, byte[] ReplacePattern, int ReplaceSize, bool AppendNOP, bool PrependNOP);

        [DllImport("kernel32.dll")]
        static extern Int32 CloseHandle(IntPtr hProcess);


        [StructLayout(LayoutKind.Sequential)]
        internal struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;


        private static TargetProcess _targetProcess;
        private static List<Patch> _patches;
        private static List<String> _logs;

        public static void ApplyPatches(TargetProcess targetProcess, List<Patch> patches, out List<String> logs)
        {
            _targetProcess = targetProcess;
            _patches = patches;
            _logs = new List<string>();

            log(DateTime.Now.ToLongTimeString());
            log("attaching to process id: " + _targetProcess.Id);

            DebugCallBackDelegate callBackDelegate = DebugCallBack;
            PROCESS_INFORMATION procInfo = new PROCESS_INFORMATION();

            bool res = AttachDebugger(_targetProcess.Id, false, out procInfo, Marshal.GetFunctionPointerForDelegate(callBackDelegate));

            log("attaching res: " + res);

            logs = _logs;
        }
        delegate void DebugCallBackDelegate();
        static void DebugCallBack()
        {
            log("DebugCallBack()");

            Process process = Process.GetProcessById(_targetProcess.Id);

            log("opening process handle");
            IntPtr processHandle = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_VM_OPERATION, false, process.Id);
            if (processHandle == null)
            {
                log("can't open process. Error code: " + Marshal.GetLastWin32Error());
                log("detaching..");
                DetachDebugger(process.Id);
                return;
            }
            log("process handle: " + processHandle);


            IntPtr baseAddr = process.MainModule.BaseAddress;
            int memSize = process.MainModule.ModuleMemorySize;
            log("module base address: " + baseAddr);
            log("module memory size: " + memSize);

            foreach (Patch patch in _patches)
            {
                log("applying patch: " + patch.Name);
                log("  search bytes: " + patch.SearchBytes);
                log("  replace bytes: " + patch.ReplaceBytes);

                string[] stringBytes = patch.SearchBytes.Split(' ');
                byte[] searchPattern = new byte[stringBytes.Length];
                for (int i = 0; i < stringBytes.Length; i++)
                {
                    searchPattern[i] = byte.Parse(stringBytes[i], System.Globalization.NumberStyles.HexNumber);
                }

                stringBytes = patch.ReplaceBytes.Split(' ');
                byte[] replacePattern = new byte[stringBytes.Length];
                for (int i = 0; i < stringBytes.Length; i++)
                {
                    replacePattern[i] = byte.Parse(stringBytes[i], System.Globalization.NumberStyles.HexNumber);
                }


                IntPtr patternAddress = FindEx((int)processHandle, baseAddr, memSize, searchPattern, searchPattern.Length, null);
                log("  found address: " + patternAddress);
                if ((int)patternAddress > 0) 
                { 
                    bool res = PatchEx((int)processHandle, patternAddress, replacePattern.Length, replacePattern, replacePattern.Length, true, false);
                    log("  OK pathching result " + res);
                    patch.Applied = true;
                }
                else
                {
                    log("  !ERR skipping patch " + patch.Name);
                }
            }

            CloseHandle(processHandle);

            DetachDebugger(process.Id);
            log("detaching...");

        }

        private static void log(String l)
        {
            /*
            TextWriter tw = new StreamWriter("patcher.log", true);
            tw.WriteLine(DateTime.Now + " : " + l);
            tw.Close();
            */
            _logs.Add(l);
        }




    }
}
