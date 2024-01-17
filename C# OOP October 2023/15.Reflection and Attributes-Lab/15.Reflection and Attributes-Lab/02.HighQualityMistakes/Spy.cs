using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();

            Hacker classInstance = (Hacker)Activator.CreateInstance(classType);
            sb.AppendLine($"Class under investigation: {classType.FullName}");
            foreach (FieldInfo field in classFields.Where(f => fields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            //Hacker classInstance = (Hacker)Activator.CreateInstance(classType, new object[] { });
            FieldInfo[] publicFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            StringBuilder result = new StringBuilder();
            foreach (FieldInfo publicField in publicFields)
            {
                result.AppendLine($"{publicField.Name} must be private!");
            }
            MethodInfo[] classPublicMethod = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] classNonPublicMethod = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MethodInfo method in classNonPublicMethod.Where(m => m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} have to be public!");
            }

            foreach (MethodInfo method in classPublicMethod.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} have to be private!");
            }

            return result.ToString().TrimEnd();
        }
    }
}
