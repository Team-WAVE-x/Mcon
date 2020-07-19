using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Mcon
{
    static class ProgramList
    {

        static List<string> WINDOW_BASIC_PROGRAM = new List<string>();

        //전체 프로세스 받아오는 거
        public static string[] GetProgram()
        {
            string[] program = new string[1000];
            try
            {

                SetWINDOW_BASIC();

                Process[] allProc = Process.GetProcesses();    //시스템의 모든 프로세스 정보 출력

                int i = 0;

                Console.WriteLine("****** 모든 프로세스 정보 ******");

                Console.WriteLine($"현재 실행중은 모든 프로세스 수 : {allProc.Length}");

                List<string> str = new List<string>();
                foreach (Process p in allProc)
                {

                    string b = p.ProcessName;

                    foreach (string a in str)
                    {
                        if (b == a)
                        {
                            goto End;
                        }
                    }

                    foreach (string a in WINDOW_BASIC_PROGRAM)
                    {
                        if (p.ProcessName == a)
                        {
                            goto End;
                        }
                    }

                    str.Add(b);
                    Console.WriteLine($"***** {i}번째 프로세스 ******");

                    WriteProcessInfo(p);

                    Console.WriteLine();

                    program[i] += p.ProcessName;

                    i++;

                    End:;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n{e.Message}");
            }


            return program;
        }


        //프로세스 출력하는거
        public static void WriteProcessInfo(Process process)
        {
            Console.WriteLine($"Process : {process.ProcessName}");

            Console.WriteLine($"시작시간 : {process.StartTime}");

            Console.WriteLine($"프로세스 PID : {process.Id}");

            Console.WriteLine($"메모리 : {process.VirtualMemorySize}");

            Console.WriteLine($"사용시간 : {process.TotalProcessorTime.TotalHours}");

              
        }


        //윈도우 기본 파일 거르는거임 (엑슨 노가다함 칭찬해주셈)
        public static void SetWINDOW_BASIC()
        {
            WINDOW_BASIC_PROGRAM.Add("System Idle Process");
            WINDOW_BASIC_PROGRAM.Add("System");
            WINDOW_BASIC_PROGRAM.Add("smss");
            WINDOW_BASIC_PROGRAM.Add("csrss");
            WINDOW_BASIC_PROGRAM.Add("wininit");
            WINDOW_BASIC_PROGRAM.Add("services");
            WINDOW_BASIC_PROGRAM.Add("lsass");
            WINDOW_BASIC_PROGRAM.Add("svchost");
            WINDOW_BASIC_PROGRAM.Add("spoolsv");
            WINDOW_BASIC_PROGRAM.Add("MsMpEng");
            WINDOW_BASIC_PROGRAM.Add("SearchIndexer");
            WINDOW_BASIC_PROGRAM.Add("SearchProtocolHost");
            WINDOW_BASIC_PROGRAM.Add("winlogon");
            WINDOW_BASIC_PROGRAM.Add("dwm");
            WINDOW_BASIC_PROGRAM.Add("taskhostw");
            WINDOW_BASIC_PROGRAM.Add("dllhost");
            WINDOW_BASIC_PROGRAM.Add("TabTip");
            WINDOW_BASIC_PROGRAM.Add("TabTip32");
            WINDOW_BASIC_PROGRAM.Add("ShellExperienceHost");
            WINDOW_BASIC_PROGRAM.Add("SearchUI");
            WINDOW_BASIC_PROGRAM.Add("RuntimeBroker");
            WINDOW_BASIC_PROGRAM.Add("dasHost");
            WINDOW_BASIC_PROGRAM.Add("WmiPrvSE");
            WINDOW_BASIC_PROGRAM.Add("NisSrv");
            WINDOW_BASIC_PROGRAM.Add("audiodg");
            WINDOW_BASIC_PROGRAM.Add("TrustedInstaller");
            WINDOW_BASIC_PROGRAM.Add("TiWorker");
            WINDOW_BASIC_PROGRAM.Add("WUDFHost");
            WINDOW_BASIC_PROGRAM.Add("SearchFilterHost");
            WINDOW_BASIC_PROGRAM.Add("OneDriveSetup");
            WINDOW_BASIC_PROGRAM.Add("OneDrive");
            WINDOW_BASIC_PROGRAM.Add("rundll32");
            WINDOW_BASIC_PROGRAM.Add("CompatTelRunner");
            WINDOW_BASIC_PROGRAM.Add("DismHost");
            WINDOW_BASIC_PROGRAM.Add("WmiPrvSE");
            WINDOW_BASIC_PROGRAM.Add("SystemSettingsBroker");
        }
    }
}
