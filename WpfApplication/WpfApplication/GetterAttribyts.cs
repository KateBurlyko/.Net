using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication
{
    class GetterAttribyts
    {
        public static IEnumerable<Type> GetTypes(string dllPath)
        {
            var dll = Assembly.LoadFile(dllPath);
            IEnumerable<Type> types;
            try
            {
                types = dll.GetTypes();
            }
            catch (Exception)
            {
                types = new List<Type>();
            }
            return types;
        }

        public static IEnumerable<MethodInfo> GetMethod(Type type)
        {
            IEnumerable<MethodInfo> methods;
            try
            {
                methods = type.GetMethods();
            }
            catch
            {
                methods = new MethodInfo[0];
            }
            return methods;
        }

        public static IEnumerable<FieldInfo> GetFields(Type type)
        {
            IEnumerable<FieldInfo> fields;
            try
            {
                fields = type.GetFields();
            }
            catch
            {
                fields = new FieldInfo[0];
            }
            return fields;
        }

        public static IEnumerable<PropertyInfo> GetProperties(Type type)
        {
            IEnumerable<PropertyInfo> properties;
            try
            {
                properties = type.GetProperties();
            }
            catch
            {
                properties = new PropertyInfo[0];
            }
            return properties;
        }
    }
}
