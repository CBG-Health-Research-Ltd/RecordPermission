using System;
using System.IO;

namespace RecordPermission
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            DateTime currentTimeMS = DateTime.Now;
            string Username = Environment.UserName; //Get current user
            string arg0 = null;
            string arg1 = null; //arbritrary showcard ID format.
            string arg2 = null;
            if (args.Length > 0) { arg0 = args[0]; }
            if (args.Length > 1) { arg1 = args[1]; }
            if (args.Length > 2) { arg2 = args[2]; }
            string check = "Arg1 = " + arg0 + " and Arg2 = " + arg1; //The string containing RecordPermission.exe arguments.
            string Arguments = arg0 + " " + arg1 + " " + arg2;
            var lines = System.IO.File.ReadAllLines(@"C:\CBGShared\RecordPermission\recordpermission.txt");
            if (Arguments.ToLower().Contains("true"))
            { 
                lines[0] = "true";
            }
            else if (Arguments.ToLower().Contains("false"))
            {
                lines[0] = "false";
            }
            else
            {
                lines[0] = "false";
            }
            System.IO.File.WriteAllLines(@"C:\CBGShared\RecordPermission\recordpermission.txt", lines);

        }
    }
}
