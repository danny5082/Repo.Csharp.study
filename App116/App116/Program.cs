using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //임베디드 프로그래밍의 50%는 I/O 입출력
            //리눅스 모든것이 File -->  low level --> byte[]

            //          파일의 기능 	file 		    fileinfo		Directory		    Directoryinfo()
            //생성		                Creace()		Create()		CreateDirectory()	Create()
            //복사		                Copy() 		    CopyTo()		-		            -
            //삭제		                Delete() 		Delete()		Delete()		    Delete()
            //이동		                Move()		    MoveTo()		Move()		        MoveTo()

            //존재여부                  Exists()        Exists          Exists()            Exists
            //속성조회              GetAttributes()     Attributes      GetAttributes()     Attributes
            //하위d 조회                -               -               GetDirectries()     GetDirectries() 
            //하위F 조회                -               -               GetFiles()          GetFiles()

            //FileStream fs = File.Create("a.dat");

            //File.Copy("a.dat", "b.dat");
            try
            {
                FileInfo file = new FileInfo("b.dat");
                FileStream fs = file.Create();
                fs.Close();
                FileInfo src = new FileInfo("b.dat");
                FileInfo dst = src.CopyTo("e.dat");

                File.Delete("b.dat");
                FileInfo delete_filr = new FileInfo("e.dat");
                delete_filr.Delete();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
           
        
        
        
        
        }
    }
}
