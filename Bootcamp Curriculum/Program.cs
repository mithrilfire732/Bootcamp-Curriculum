using System;

namespace Bootcamp_Curriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitgithub = new Topic("Git/Github","SCM", 3);
            var sqlserver = new Topic("SQL Server", "Database", 2);
            gitgithub.Print();
            sqlserver.Print();
        }
    }

}
