using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

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

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder result = new StringBuilder();
            result.AppendLine($"All Private Methods of Class: {classType.FullName}");
            result.AppendLine($"Base Class: {classType.BaseType.Name}");
            foreach (MethodInfo method in privateMethods)
            {
                result.AppendLine(method.Name);
            }

            return result.ToString().TrimEnd();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] methods = classType.GetMethods((BindingFlags)60);
            StringBuilder result = new StringBuilder();
            foreach (MethodInfo method in methods.Where(m => m.Name.Contains("get")))
            {
                result.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (MethodInfo method in methods.Where(m => m.Name.Contains("set")))
            {
                result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
