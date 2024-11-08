using System.Collections;

namespace salary_ex
{
    // 인사 관리 정보
    struct worker
    {
        public string name; // 이름
        public string pos; // 직급
        public string depart; // 근무 부서
        public int workyear; // 근무 년수
        public int overtime; // 초과 근무시간
        public int totalpay; // 이번달 지급할 급여액
    }
    class Program
    {
        // 사원등록
        static void AddWorker(worker[] w)
        {
            Console.Write("사원번호를 입력하세요(1~30)"); // 사원 번호는 1~30번으로 정의.
            int n = int.Parse(Console.ReadLine());
            if (0 < n && n < 31)
            {
                Console.Write("이름을 입력하세요");
                w[n = 1].name = Console.ReadLine();
                Console.Write("직급을 입력 하세요(부장, 차장, 과장, 대리, 사원)");
                w[n - 1].pos = Console.ReadLine();
                Console.Write("근무 부서를 입력하세요 (영업부, 구매부, 물류부, 생산부, 총무부)");
                w[n - 1].depart = Console.ReadLine();
                Console.Write("근무 년수를 입력하세요");
                w[n - 1].workyear = int.Parse(Console.ReadLine());
                Console.Write("초과 근무 시간을 입력해 주세요");
                w[n - 1].overtime = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("사원 번호는 1~30번을 사용하세요");
            }
        }
        // 사원 직급 수정
        static void ChangePos(worker[] w)
        {
            Console.WriteLine("현재 사원 직급");
            for (int i = 0; i < 31; i++)
            {
                if (w[i].name != null) // 기존 사원 번호와 직급을 보여준다
                {
                    Console.WriteLine("{0}:{1}:{2}", i + 1, w[i].name, w[i].pos);
                }
            }
            Console.Write("직급을 수정할 사원 번호를 입력하세요 (1~30)");
            int n = int.Parse(Console.ReadLine());
            if (0 < n && n < 30) // 사번 에러 체크
            {
                Console.Write("새로운 직급을 입력하세요");
                string newpos = Console.ReadLine();
                w[n - 1].pos = newpos; // 지정한 사원의 직급을 수정한다
            }
            else
            {
                Console.WriteLine("사원 번호는 1~30을 사용하세요");
            }
        }
        // 사원 근무 부서 수정
        static void ChangeDepart(worker[] w)
        {
            Console.WriteLine("현재 사원 근무 부서");
            for (int i = 0; i < 30; i++)
            {
                if (w[i].name != null)
                {
                    Console.WriteLine("{0}:{1}:{2}", i + 1, w[i].name, w[i].depart);
                }
            }
            Console.Write("수정할 사원의; 사원번호를 입력하세요(1~30)");
            int n = int.Parse(Console.ReadLine());
            if (0 < n && n < 31)
            {
                Console.Write("새로운 부서를 입력하세요");
                string newdepart = Console.ReadLine();
                w[n - 1].depart = newdepart; // 선택한 사원 부서 변경
            }
            else
            {
                Console.WriteLine("사원 번호는 1~30번을 사용하세요");
            }
        }
        // 사원 근무 년수 수정
        static void ChangeWorkeyear(worker[] w)
        {
            Console.WriteLine("현재 사원 근무 년수");
            for (int i = 0; i < 30; i++)
            {
                if (w[i].name != null)
                {
                    Console.WriteLine("{0}:{1}:{2}", i + 1, w[i].name, w[i].workyear);
                }
            }
            Console.Write("수정할 사원번호를 입력하세요 (1~30)");
            int n = int.Parse(Console.ReadLine());
            if (0 < n && n < 31)
            {
                Console.Write("새로운 근무 년수를 입력하세요");
                int newworkyear = int.Parse(Console.ReadLine());
                w[n - 1].workyear = newworkyear; // 선택한 사원 근무 년수 변경
            }
            else
            {
                Console.WriteLine("사원번호는 1~30번을 사용하세요");
            }
            // 사원 초과 근무 수정
            static void ChangeOvertime(worker[] w)
            {
                Console.WriteLine("현재 사원의 초과근무");
                for (int i = 0; i < 30; ++i)
                {
                    if (w[i].name != null)
                    {
                        Console.WriteLine("{0},{1},{2}", i + 1, w[i].name, w[i].overtime);
                    }
                }
                Console.Write("수정할 사원 번호를 입력 하세요(1~30)");
                int n = int.Parse(Console.ReadLine());
                if (0 < n && n < 31)
                {
                    Console.Write("새로운 초과 근무 시간을 입력하세요");
                    int newovertime = int.Parse(Console.ReadLine());
                    w[n - 1].overtime = newovertime;
                }
                else
                {
                    Console.WriteLine("사원번호는 1~30번을 사용하세요");
                }
            }
            // 사원 직급 명세서 출력
            static void PrintPaymentList(worker[] w)
            {
                for (int i = 0; i < 30; i++)
                {
                    if (w[i].name != null)
                    {
                        w[i].totalpay = 0;
                        if (w[i].pos == "부장")
                        {
                            w[i].totalpay = 200 + w[i].workyear * 5 + w[i].overtime * 4;
                        }
                        else if (w[i].pos == "차장")
                        {
                            w[i].totalpay = 180 + w[i].workyear * 4 + w[i].overtime * 4;
                        }
                        else if (w[i].pos == "과장")
                        {
                            w[i].totalpay = 160 + w[i].workyear * 3 + w[i].overtime * 4;
                        }
                        else if (w[i].pos == "대리")
                        {
                            w[i].totalpay = 150 + w[i].workyear * 2 + w[i].overtime * 4;
                        }
                        else
                        {
                            w[i].totalpay = 130 + w[i].workyear * 1 + w[i].overtime * 4;
                        }
                    }
                }
                // 부서별 총 급여액 출력
                static void PrintDepartPayment(worker[] w)
                {
                    Hashtable summary = new Hashtable();
                    for (int i = 0; i < 30; i++)
                    {
                        if (w[i].name != null)
                        {
                            string key = w[i].depart;
                            if (summary.ContainsKey(key))
                            {
                                summary[key] = (int)summary[key] + w[i].totalpay;
                            }
                            else
                            {
                                summary.Add(key, w[i].totalpay);
                            }
                        }
                        foreach (DictionaryEntry cs in summary)
                        {
                            string depart = (string)cs.Key;
                            int totalpay = (int)cs.Value;
                            Console.WriteLine("{0}부서 총급여액 = {1}", depart, totalpay);
                        }
                    }
                }
                static void Main(string[] args)
                {
                    worker[] data = new worker[30];
                    while (true)
                    {
                        Console.WriteLine("# 1 = 신규둥록, 2 = 직급 수정, 3 = 부서 수정, 4 = 근무 년수 수정, 5 = 초과 근무 수정 #");
                        Console.WriteLine("# 6 = 급여 명세서 출력, 7 = 부서별 급여 총액 분석, 0 = 프로그램 종료 #");
                        Console.Write("원하는 작업을 선택하세요 -->");
                        int command = int.Parse(Console.ReadLine());
                        if (command == 0)
                        {
                            break;
                        }
                        Console.WriteLine();
                        switch (command)
                        {
                            case 1:
                                {
                                    AddWorker(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 2:
                                {
                                    ChangePos(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 3:
                                {
                                    ChangeDepart(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 4:
                                {
                                    ChangeWorkeyear(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 5:
                                {
                                    ChangeOvertime(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 6:
                                {
                                    PrintPaymentList(data);
                                    Console.WriteLine();
                                    break;
                                }
                            case 7:
                                {
                                    PrintDepartPayment(data);
                                    Console.WriteLine();
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
}
