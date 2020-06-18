using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Eproduction.Integrated.Assistant.Common {
    public static class ObjectUtils {
        public static string ToStringEncoding(this string code) {
            return !string.IsNullOrWhiteSpace(code) ? Convert.ToBase64String(Encoding.UTF8.GetBytes(code)) : code;
        }
        public static string ToStringDecoding(this string code) {
            return !string.IsNullOrWhiteSpace(code) ? Encoding.UTF8.GetString(Convert.FromBase64String(code)) : code;
        }
        public static T Clone<T>(T body) where T : class {
            T install = Activator.CreateInstance<T>();
            PropertyInfo[] propertyInfos = install.GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos) {
                try {
                    if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))) {
                        NullableConverter nullableConverter = new NullableConverter(propertyInfo.PropertyType);
                        propertyInfo.SetValue(install, Convert.ChangeType(propertyInfo.GetValue(body), nullableConverter.UnderlyingType), null);
                    } else {
                        propertyInfo.SetValue(install, Convert.ChangeType(propertyInfo.GetValue(body), propertyInfo.PropertyType), null);
                    }
                } catch { }
            }
            return install;
        }
        public static IList<T> Clone<T>(IList<T> ibody) where T : class {
            IList<T> newList = new List<T>();
            foreach (var item in ibody) {
                T model = Activator.CreateInstance<T>();
                PropertyInfo[] propertyInfos = model.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in propertyInfos) {
                    try {
                        if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))) {
                            NullableConverter nullableConverter = new NullableConverter(propertyInfo.PropertyType);
                            propertyInfo.SetValue(model, Convert.ChangeType(propertyInfo.GetValue(item), nullableConverter.UnderlyingType), null);
                        } else {
                            propertyInfo.SetValue(model, Convert.ChangeType(propertyInfo.GetValue(item), propertyInfo.PropertyType), null);
                        }
                    } catch { }
                }
                newList.Add(model);
            }
            return newList;
        }
        public static int GetIndexOfArray(this IEnumerable<object> self, object compareObject) {
            int index = 0;
            var selfToArray = self.ToArray();
            for (int i = 0; i < selfToArray.Length; i++) {
                if (selfToArray[i].Equals(compareObject)) {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
