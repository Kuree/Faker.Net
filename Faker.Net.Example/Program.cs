using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using System.Reflection;

namespace Faker.Net.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Faker.Net example. Please enter number to choose locale");
            LocaleType chosenLocale = LocaleType.en;
            Dictionary<string, FakerBase> availableFakers;
            FakerBase faker;
            string result = "";
            goto Read_Locale_Input;

        Read_Locale_Input:
            var localeTypes = GetAllLocalType();
            for (int i = 0; i < localeTypes.Count; i++)
            {
                Console.WriteLine(string.Format("[{0:d2}]: {1}", i, localeTypes.Keys.ElementAt(i)));
            }
            int intChosenLocale = 0;
            if (!int.TryParse(Console.ReadLine(), out intChosenLocale) || intChosenLocale >= localeTypes.Count)
            {
                Console.WriteLine("Incorrect number input, please try again.");
                goto Read_Locale_Input;
            }

            chosenLocale = localeTypes[localeTypes.Keys.ElementAt(intChosenLocale)];
            // Create all the fakers with given locale
            availableFakers = GetAllFakers(chosenLocale);
            goto Read_Faker_Input;

        Read_Faker_Input:
            Console.Clear();
            result = "";
            Console.WriteLine("Please choose a Faker library to explore");
            Console.WriteLine("Enter 0 to return upper level\n[00]: ...");
            int keyCount = 1;
            string[] fakerKeys = new string[availableFakers.Count];
            foreach (var kvp in availableFakers)
            {
                fakerKeys[keyCount - 1] = kvp.Key;
                Console.WriteLine(string.Format("[{0:d2}]: {1}", keyCount++, kvp.Key));
            }
            int fakerChoice = 0;
            if (!int.TryParse(Console.ReadLine(), out fakerChoice) || fakerChoice > fakerKeys.Length)
            {
                Console.WriteLine("Incorrect number input, please try again.");
                Console.Clear();
                goto Read_Locale_Input;
            }
            if (fakerChoice == 0) { Console.Clear(); goto Read_Locale_Input; }
            faker = availableFakers[fakerKeys[fakerChoice - 1]];
            goto Read_Write_Method;

        Read_Write_Method:
            Console.Clear();
            Console.WriteLine("Please choose a method to explore");
            Console.WriteLine("Enter 0 to return upper level\n[00]: ...");
            var methods = GetMethods(faker);
            for (int i = 1; i <= methods.Length; i++)
            {
                Console.WriteLine(string.Format("[{0:d2}]: {1}", i, methods[i - 1].Name));
            }
            if (!string.IsNullOrWhiteSpace(result)) { Console.WriteLine(result); }
            int methodChoice = 0;
            if (!int.TryParse(Console.ReadLine(), out methodChoice) || methodChoice > methods.Length)
            {
                result = "Incorrect number input, please try again.";
                Console.Clear();
                goto Read_Write_Method;
            }
            else
            {
                if (methodChoice == 0) { Console.Clear(); goto Read_Faker_Input; }
                result = string.Format("Result [{0:d2}]:\n{1}", methodChoice, InvokeMethod(methods[methodChoice - 1], faker));
                goto Read_Write_Method;
            }
        }

        static Dictionary<string, FakerBase> GetAllFakers(LocaleType localType)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(FakerBase));
            Dictionary<string, FakerBase> dic = new Dictionary<string, FakerBase>();
            foreach(Type type in assembly.GetTypes())
            {
                if(type.BaseType == typeof(FakerBase) && !type.IsAbstract)
                {
                    dic.Add(type.Name, Activator.CreateInstance(type, new object[] { localType }) as FakerBase);
                }
            }
            return dic;
        }

        static Dictionary<string, LocaleType> GetAllLocalType()
        {
            Dictionary<string, LocaleType> dict = new Dictionary<string, LocaleType>();
            foreach(var type in Helpers.GetAvailableLocaleTypes())
            {
                dict.Add(type.ToString(), type);
            }
            return dict;
        }

        static MethodInfo[] GetMethods(object obj)
        {
            var type = obj.GetType();
            List<MethodInfo> list = new List<MethodInfo>();
            foreach(var method in type.GetMethods())
            {
                if(method.IsPublic && !method.IsSpecialName && method.GetBaseDefinition().DeclaringType != typeof(object)
                    && method.GetParameters().Length == 0)
                {
                    list.Add(method);
                }
            }
            return list.ToArray();
        }

        static string InvokeMethod(MethodInfo method, object obj)
        {
            return method.Invoke(obj, null).ToString();
        }

    }
}
