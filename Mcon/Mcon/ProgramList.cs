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

        public static void GetProgram()
        {
            try
            {

                Process[] allProc = Process.GetProcesses();    //시스템의 모든 프로세스 정보 출력

                int i = 0;

                Console.WriteLine("****** 모든 프로세스 정보 ******");

                Console.WriteLine("현재 실행중은 모든 프로세스 수 : {0}", allProc.Length);

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
                    str.Add(b);
                    Console.WriteLine("***** {0}번째 프로세스 ******", i++);

                    WriteProcessInfo(p);

                Console.WriteLine();

                End:;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n{e.Message}");

            }
        }


        public static void WriteProcessInfo(Process process)
        {
            Console.WriteLine("Process : {0}", process.ProcessName);

            Console.WriteLine("시작시간 : {0}", process.StartTime);

            Console.WriteLine("프로세스 PID : {0}", process.Id);

            Console.WriteLine("메모리 : {0}", process.VirtualMemorySize);
        }
    }
}
