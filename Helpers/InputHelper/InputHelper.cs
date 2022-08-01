/*
 * Allows fetching data from an input source file for easier testing of test cases 
 * (avoiding the need to retype manually the data each time)
 * 
 * To use:
 *  1) Add the following define to your CS project (right click your project, click "Properties" and 
 *     under the "Build" tab, enter the following into the "Conditional Compilation Symbols" field):
 *
            DEBUG_READ_DATA_FROM_FILE
 *      
 *  2) Create a file called "InputData.txt" somewhere in your project
 *  
 *  
 *  3) Change INPUT_DATA_FOLDER_PATH below (line 53) to point at your "InputData.txt" file
 *    
 *    
 *  4) Copy the following 3 lines into the top of Program.cs each time you reset the code to ensure 
 *  you can read it properly
        
        /************ Copy below 3 lines of code ************/

#if DEBUG_READ_DATA_FROM_FILE && TRUE
using Console = CodinGameHelpers.InputHelper;
#endif // DEBUG_READ_DATA_FROM_FILE

        /************ End of copying lines ************/

/*      
 *  5) Replace the contents of "InputData.txt" with the data from one of the TestCase scenarios 
 *  you want to debug from the CodinGame challenge
 *  
 *  That's it! Now when you run the code in Visual Studio, instead of having to 
 *  manually enter the input everytime, it will automatically put it in for you
 *  
 *  No further changes to the code you write are needed whatsoever, and when you 
 *  submit your answers from Program.cs to CodinGame, it will work exactly the same!
 *     
 *  TIP: If you want to quickly switch to manually inputting some data for a particular test case for any reason, you can simply switch the code from the copied lines above
 *  from:
       && TRUE
 * 
 *  to:
       && !TRUE
*/

#if DEBUG_READ_DATA_FROM_FILE
namespace CodinGameHelpers
{
    public class InputHelper
    {
        // TODO: Change this to your own "InputData.txt" file path.
        // Either hardcode the absolute path or use a relative one (like below)
        private static string INPUT_DATA_FOLDER_PATH => System.Environment.CurrentDirectory + @"/../../CodinGame/Helpers";

        public static System.IO.TextWriter Error { get; } = System.Console.Error;

        public static string ReadLine()
        {
            return HasMoreData() ? m_FileStreamReader.ReadLine() : null;
        }

        #region WriteLine overloads
        public static void WriteLine()
        {
            System.Console.WriteLine();
        }

        public static void WriteLine(string data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(bool data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(char data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(char[] data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(decimal data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(int data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(float data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(double data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(uint data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(long data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(ulong data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(object data)
        {
            System.Console.WriteLine(data);
        }

        public static void WriteLine(string format, object arg0)
        {
            System.Console.WriteLine(format, arg0);
        }

        public static void WriteLine(string format, object arg0, object arg1)
        {
            System.Console.WriteLine(format, arg0, arg1);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            System.Console.WriteLine(format, arg0, arg1, arg2);
        }

        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
            System.Console.WriteLine(format, arg0, arg1, arg2, arg3);
        }

        public static void WriteLine(string format, params object[] arg)
        {
            System.Console.WriteLine(format, arg);
        }

        public static void WriteLine(char[] buffer, int index, int count)
        {
            System.Console.WriteLine(buffer, index, count);
        }
        #endregion WriteLine overloads

        #region Internals - do not change
        private const string INPUT_DATA_FILE_NAME = "InputData.txt";

        private static System.IO.StreamReader m_FileStreamReader;

        static InputHelper()
        {
            LoadData();
        }

        private static bool HasMoreData() => m_FileStreamReader != null && m_FileStreamReader.Peek() >= 0;

        private static string GetInputTextFilePath()
        {
            // Find the file (done this way to make it as easy as possible for people to
            // emulate in their own projects) simply by changing INPUT_DATA_FOLDER_PATH
            string envDirectory = INPUT_DATA_FOLDER_PATH;

            // Early out if they already hardcoded the full path in the folder
            if (envDirectory.EndsWith(INPUT_DATA_FILE_NAME, System.StringComparison.InvariantCultureIgnoreCase))
            {
                return envDirectory;
            }

            // Add the directory separator as needed followed by the filename
            char lastLetter = envDirectory[envDirectory.Length - 1];
            if (lastLetter != '/' && lastLetter != '\\')
            {
                envDirectory += '\\';
            }

            envDirectory = envDirectory.Replace('/', '\\');

            string filePath = envDirectory + INPUT_DATA_FILE_NAME;
            return filePath;
        }

        private static void LoadData()
        {
            if (m_FileStreamReader != null)
            {
                m_FileStreamReader.Close();
                m_FileStreamReader = null;
            }

            string filePath = GetInputTextFilePath();
            if (!System.IO.File.Exists(filePath))
            {
                throw new System.IO.FileNotFoundException($"{filePath} was not found.\n\nPlease ensure \"INPUT_DATA_FOLDER_PATH\" has the correct path assigned in InputHelpers.cs");
            }

            m_FileStreamReader = new System.IO.StreamReader(filePath);

            // Ensure that there is valid data
            if (!HasMoreData())
            {
                throw new System.Exception($"{INPUT_DATA_FILE_NAME} file is empty. Please paste correct data into it, save it and retry");
            }
        }
        #endregion Internals - do not change
    }
}
#endif // DEBUG_READ_DATA_FROM_FILE
