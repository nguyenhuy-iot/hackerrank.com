using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTool
{
    class component_D1
    {
        int Count = 1;
        string Row_Open = "[\n\t// Column",
                      Row_Close = "],";
        string Col = "\t{ url: 'img/FriendsPlus/";//\t{ url: 'img/FriendsPlus/Page108/E10/1.jpg' },

        public component_D1() //run this
        {
            Console.WriteLine("Page0/E0\n1 3 3 1 3...\ninput:\n");
            string Page_E = Console.ReadLine();
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            this.Col += Page_E + "/";
            this.Write_Image(arr);// Output
        }
        void Write_Col(int n)
        {
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(this.Col + this.Count + ".jpg'},");
                this.Count++;
            }            
        }
        public void Write_Row(int n)
        {
            Console.WriteLine(this.Row_Open);
            this.Write_Col(n);
            Console.WriteLine(this.Row_Close);
        }
        void Write_Image(List<int> arr)
        {
            foreach (var item in arr)
            {
                this.Write_Row(item);
            }
        }
    }
}
