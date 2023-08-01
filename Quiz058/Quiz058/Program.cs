using Oracle.ManagedDataAccess.Client;
using System;
using System.Threading;

namespace Quiz058
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
            int a = 1;
            string b = "정상동작중";
            for (int i = 0; i < 6; i++)
            {
                string sysdate = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss");


                cmd.CommandText = "INSERT INTO app1 VALUES" +
                    $"('{a}','{sysdate}','{b}' )";
                cmd.ExecuteNonQuery();
                a++;

                Thread.Sleep(5000);
            }

            //4. 리소스 반환 및 종료
            conn.Close();
        }
    }
}
