using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_Directory_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the folder you want to view.\ndirPath:");
            string dirPath = Console.ReadLine();

            PrintDirectory(dirPath);

            Console.Read();
        }
        // Phương thức đệ quy (Recursive) liệt kê ra các thư mục con của một thư mục.
        public static void PrintDirectory(string dirPath)
        {
            try
            {
                // Nếu bạn không có quyền truy cập thư mục 'dirPath' 
                // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);


                List<string> dirs = new List<string>(enums);

                foreach (var dir in dirs)
                {
                    Console.WriteLine(dir);


                    PrintDirectory(dir);
                }
            }
            // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền.
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Can not access directory: " + dirPath);
                Console.WriteLine(e.Message);
            }
        }
    }
}
