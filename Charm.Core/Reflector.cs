using System;
using System.Reflection;

namespace Charm.Core
{
    public static class Reflector
    {
        public static void Set(object obj, string propertyName, object value)
        {
            obj.GetType().InvokeMember(propertyName,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty | BindingFlags.SetField |
                BindingFlags.NonPublic,
                Type.DefaultBinder, obj, new[] {value});
        }

        public static object Get(object obj, string propertyName)
        {
            return obj.GetType().InvokeMember(propertyName,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.GetField |
                BindingFlags.NonPublic,
                Type.DefaultBinder, obj, new object[] {});
        }

        public static void Set<T>(T obj, string propertyName, object value)
        {
            typeof (T).InvokeMember(propertyName,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty | BindingFlags.SetField |
                BindingFlags.NonPublic,
                Type.DefaultBinder, obj, new[] {value});
        }

        public static object Get<T>(T obj, string propertyName)
        {
            return typeof (T).InvokeMember(propertyName,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.GetField |
                BindingFlags.NonPublic,
                Type.DefaultBinder, obj, new object[] {});
        }
    }
}
