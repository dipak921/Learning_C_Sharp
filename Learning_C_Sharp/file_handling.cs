using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // for file handling

namespace Learning_C_Sharp
{
    internal class file_handling
    {
        static void Main(string[] args)
        {
            //string path = @"C:\\File\f1.txt"; // Verbatim literal
            //if(File.Exists(path))
            //{
            //    Console.WriteLine("Yes there is File Found");
            //}
            //else
            //{
            //Console.WriteLine("File Not Found.");
            //}
            //Console.WriteLine("-------------------- Second Example ------------------------");
            //string path1 = @"C:\\File\data.txt"; // Verbatim literal
            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("Yes I have data");
            //}
            //else
            //{
            //    Console.WriteLine("No Data Found.");
            //}
            //Console.WriteLine("-------------------- Another Folder Example ------------------------");

            //string user_data = @"C:\\File_user_data\user_data.txt";

            //if (File.Exists(user_data))
            //{
            //    Console.WriteLine("Yes I have user data");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found user data .");
            //}
            //Console.WriteLine("-------------------- Read file Example 2 ------------------------");
            //string user = @"C:\\File_user_data\user data.txt";

            //if (File.Exists(user))
            //{
            //    Console.WriteLine("Yes I have user data");
            //    string data = File.ReadAllText(user);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found user data .");
            //}
            //Console.WriteLine("-------------------- Read file Example 2 ------------------------");
            //string login = @"C:\\File_user_data\login_infromation_data.txt";

            //if (File.Exists(login))
            //{
            //    Console.WriteLine("Yes I have login data");
            //    string data_login = File.ReadAllText(login);
            //    Console.WriteLine(data_login);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found user data .");
            //}

            //Console.WriteLine("-------------------- Copy Text file ------------------------");
            //string login = @"C:\\File_user_data\login_infromation_data.txt";
            //string login2 = @"C:\\File_user_data\login_infromation_data_2.txt";
            //if (File.Exists(login))
            //{
            //    Console.WriteLine("File found");
            //    File.Copy(login, login2,true);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found File.");
            //}

            //Console.WriteLine("--------------- Copy Text file  another folder --------------------");

            //string login = @"C:\\File_user_data\login_infromation_data.txt";
            //string login3 = @"C:\\File_user_data\copy\login_infromation.txt";
            //if (File.Exists(login))
            //{
            //    Console.WriteLine("File found");
            //    File.Copy(login, login3);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found File.");
            //}

            // --------------- CREATE, READ, MOVE, DELETER USE A DICTIONARY CLASS -----------------------
            //Console.WriteLine("CREATE, READ, MOVE, DELETER USE A DICTIONARY CLASS");

            //string path1 = @"C:\\Folder2";
            //DirectoryInfo  dir = new DirectoryInfo(path1);
            ////dir.Create();
            //dir.CreateSubdirectory("Another folder"); // create sub folder

            ////Console.WriteLine("Directory Created");

            //Console.WriteLine("--------------- MOVE -------------------");

            //string path1 = @"C:\File_user_data";
            //string path2 = @"C:\Folder3";

            //DirectoryInfo dir = new DirectoryInfo(path1);
            //dir.MoveTo(path2);

            //Console.WriteLine("Move Successfully");

            //Console.WriteLine("--------------- DELETE -------------------");

            //string path1 = @"C:\File_user_data";
            //string path2 = @"C:\Folder3";

            //DirectoryInfo dir = new DirectoryInfo(path1);
            //dir.Delete(path2);

            //Console.WriteLine("Delete Successfully");


            //Console.WriteLine("--------------- GET -------------------");
            //string path1 = @"C:\New";
            //DirectoryInfo dir = new DirectoryInfo(path1);
            //DirectoryInfo[] dirs = dir.GetDirectories();
            //foreach(var item in dirs)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(item.FullName);// return with path
            //    Console.WriteLine(item.GetFiles().Length); // with file sub file
            //}
            //

            Console.WriteLine("---------------- Aceess ------------------ ");
            string path2 = @"C\New\N1";
            DirectoryInfo dir2 = new DirectoryInfo(path2);
            Console.WriteLine(dir2.FullName);
            Console.WriteLine(dir2.LastAccessTime);
            Console.WriteLine(dir2.CreationTime);
            Console.WriteLine(dir2.Attributes);
            Console.WriteLine(dir2.Parent);
            Console.WriteLine(dir2.Root);
            Console.WriteLine(dir2.LastWriteTime);
            Console.WriteLine("--------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
