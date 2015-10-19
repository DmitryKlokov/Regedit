using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace regedit
{
    class Program
    {
        public static void SetValue(string key, object value)
        {
            RegistryKey currRegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\MyTestProgram");
            if (currRegistryKey != null)
            {
                currRegistryKey.SetValue(key, value);
                currRegistryKey.Close();
            }
        }

        public static object GetValue(string key)
        {
            object val = null;

            RegistryKey currRegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE");
            if (currRegistryKey != null)
            {
                val = currRegistryKey.GetValue(key);
                currRegistryKey.Close();
            }
            return val;
        }
        

        static void Main(string[] args)
        {
            //SetValue("key1", "value1 for key1");
            //SetValue("key2", "value2 for key2");

            String value1 = (String)GetValue("key1");
            String value2 = (String)GetValue("key2");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.ReadKey(true);
        }
    }
}
