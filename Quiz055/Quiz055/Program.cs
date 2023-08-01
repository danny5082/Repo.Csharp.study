using Oracle.ManagedDataAccess.Client;
using System;

namespace Quiz055
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SELECT 데이터 조회
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            //1.연결 객체 만들기 - Client
            OracleConnection conn = new OracleConnection(strConn);

            //2.데이터베이스 접속을 위한 연결
            conn.Open();

            //명령객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            while (true)
            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 조회");
                Console.WriteLine("4. 데이터 수정");
                Console.WriteLine("5. 시스템 종료");
                Console.Write("메뉴 : ");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:

                        Console.Write("ID");
                        int b_1 = int.Parse(Console.ReadLine());
                        Console.Write("이름");
                        string c_1 = Console.ReadLine();
                        Console.Write("전화번호");
                        string d_1 = Console.ReadLine();
                        cmd.CommandText = $"INSERT INTO PhoneBook(ID , NAME , HP) VALUES('{b_1}','{c_1}','{d_1}')";
                        cmd.ExecuteNonQuery();
                        break;

                    case 2:
                        Console.Write("삭제할 ID : ");
                        int a_2 = int.Parse(Console.ReadLine());
                        cmd.CommandText = $"DELETE FROM PhoneBook WHERE Id = '{a_2}'";
                        cmd.ExecuteNonQuery();

                        break;
                    case 3:


                        //데이터 조회
                        cmd.CommandText = "SELECT * FROM PhoneBook";
                        //cmd.ExecuteNonQuery()

                        //데이터 조회 결과를 리턴하는 DataReader객체를 만들어야 한다.
                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            //int id = rdr.GetInt32(0); //int나 number로 받을때 
                            //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                            //int id = int.Parse(rdr["ID"] as string); //Error
                            int id = int.Parse(rdr["ID"].ToString());
                            string name = rdr["NAME"] as string;
                            string hp = rdr["HP"] as string;

                            Console.WriteLine($"{id} : {name} : {hp}");
                        }

                        break;
                    case 4:
                        Console.Write("수정할 ID : ");
                        int a_4 = int.Parse(Console.ReadLine());
                        Console.Write("ID");
                        int b_4 = int.Parse(Console.ReadLine());
                        Console.Write("이름");
                        string c_4 = Console.ReadLine();
                        Console.Write("전화번호");
                        string d_4 = Console.ReadLine();
                        cmd.CommandText = $"UPDATE PhoneBook SET ID = {b_4} , NAME = '{c_4}' , HP='{d_4}' " +
                              $"WHERE ID = {a_4}";
                        cmd.ExecuteNonQuery();

                        break;
                    case 5:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        //4. 리소스 반환 및 종료
                        conn.Close();
                        break;
                }

                Console.WriteLine("\n");
            }
        }

    }
}