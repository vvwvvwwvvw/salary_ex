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

        }
        // 사원 직급 수정
        static void ChangePos(worker[] w)
        {

        }
        // 사원 근무 부서 수정
        static void ChangeDepart(worker[] w)
        {
        
        }
        // 사원 근무 년수 수정
        static void ChangeWorkeyear(worker[] w)
        {

        }
        // 사원 초과 근무 수정
        static void ChangeOvertime(worker[] w)
        {

        }
        // 사원 직급 명세서 출력
        static void PrintPaymentList(worker[] w)
        {

        }
        // 부서별 총 급여액 출력
        static void PrintDepartPayment(worker[] w)
        {

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
