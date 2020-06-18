using System;
using System.Globalization;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core {

    public static class DataConvertedOwnerEx {

        /// <summary>
        /// 将输入的字符串转换为布尔类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>返回布尔值</returns>
        public static bool ToBoolean(this string input) {
            bool output = false;
            if (!string.IsNullOrEmpty(input)) {
                input = input.Trim();
                if (string.Compare(input, "true", StringComparison.OrdinalIgnoreCase) == 0
                    || string.Compare(input, "yes", StringComparison.OrdinalIgnoreCase) == 0
                    || string.Compare(input, "1", StringComparison.OrdinalIgnoreCase) == 0) {
                    output = true;
                }
            }
            return output;
        }

        /// <summary>
        /// 将输入的字符串转换为布尔类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>返回布尔值</returns>
        public static bool ToBoolean(this object input) {
            var str = input.ToString();
            bool output = false;
            if (!string.IsNullOrEmpty(str)) {
                str = str.Trim();
                if (string.Compare(str, "true", StringComparison.OrdinalIgnoreCase) == 0
                    || string.Compare(str, "yes", StringComparison.OrdinalIgnoreCase) == 0
                    || string.Compare(str, "1", StringComparison.OrdinalIgnoreCase) == 0) {
                    output = true;
                }
            }
            return output;
        }

        /// <summary>
        /// 将输入的对象转换为日期时间类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <returns>转换成功则返回对应日期时间，否则返回否则返回1900,1,1</returns>
        public static DateTime ToDate(this object input) {
            return (Convert.IsDBNull(input) || Equals(input, null)) ? new DateTime(1900, 1, 1) : input.ToString().ToDate();
        }

        /// <summary>
        /// 将输入的字符串转换为日期时间类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功并且日期大于数据库datetime类型的最小时间（1753年1月1日）则返回对应日期时间，否则返回1900,1,1</returns>
        public static DateTime ToDate(this string input) {
            DateTime output;
            if (!DateTime.TryParse(input, out output) || output < new DateTime(1753, 1, 1, 12, 0, 0)) {
                output = new DateTime(1900, 1, 1);
            }
            return output;
        }

        /// <summary>
        /// 将输入的字符串转换为可空的日期时间类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="outTime">指定的日期时间</param>
        /// <returns>转换成功则返回对应的日期时间，否则返回指定的日期时间</returns>
        public static DateTime? ToDate(this string input, DateTime? outTime) {
            DateTime output;
            return !DateTime.TryParse(input, out output) ? outTime : output;
        }

        /// <summary>
        /// 将输入的字符串类型化为日期时间字符串
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功则返回对应日期时间字符串，否则返回空字符串</returns>
        public static string ToDateString(this string input) {
            DateTime output;
            return !DateTime.TryParse(input, out output) ? string.Empty : output.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 将输入的字符串类型化为日期时间字符串
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="defaultValue">转换失败时默认值</param>
        /// <returns>转换成功则返回对应日期时间字符串，否则返回默认值</returns>
        public static string ToDateString(this string input, string defaultValue) {
            DateTime output;
            return !DateTime.TryParse(input, out output) ? defaultValue : output.ToString("yyyy-MM-dd");
        }

        public static string ToStandardDateString(this object input) {
            try {
                if (input is DateTime) {
                    return ((DateTime)input).ToString("yyyy/MM/dd");
                }
            } catch (Exception) { }
            return string.Empty;
        }

        public static string ToStandardTimeString(this object input) {
            try {
                if (input is DateTime) {
                    return ((DateTime)input).ToString("HH:mm:ss");
                }
            } catch (Exception) { }
            return string.Empty;
        }

        /// <summary>
        ///  将日期类型转化为标准的日期字符
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static String ToStandardDateTimeString(this Object input) {
            try {
                DateTime value = (DateTime)input;
                return value.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            } catch {
                throw;
            }
        }

        /// <summary>
        /// 将输入的对象转换为Decimal类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <returns>转换成功则返回对应十进制数，否则返回 0</returns>
        public static decimal ToDecimal(this object input) {
            return input.ToDecimal(0);
        }

        /// <summary>
        /// 将输入的对象转换为Decimal类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应十进制数，否则返回默认值</returns>
        public static decimal ToDecimal(this object input, decimal defaultValue) {
            return (Convert.IsDBNull(input) || Equals(input, null)) ? 0 : input.ToString().ToDecimal(defaultValue);
        }

        /// <summary>
        /// 将输入的字符串转换为Decimal类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功则返回对应十进制数，否则返回 0</returns>
        public static decimal ToDecimal(this string input) {
            return input.ToDecimal(0);
        }

        /// <summary>
        /// 将输入的字符串转换为Decimal类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应十进制数，否则返回默认值</returns>
        public static decimal ToDecimal(this string input, decimal defaultValue) {
            decimal output;
            if (!Decimal.TryParse(input, out output)) {
                output = defaultValue;
            }
            return output;
        }

        /// <summary>
        /// 将输入的对象转换为Double类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <returns>转换成功则返回对应浮点数字，否则返回 0</returns>
        public static double ToDouble(this object input) {
            return input.ToDouble(0);
        }

        /// <summary>
        /// 将输入的对象转换为Double类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应浮点数字，否则返回默认值</returns>
        public static double ToDouble(this object input, double defaultValue) {
            return (Convert.IsDBNull(input) || Equals(input, null)) ? 0 : input.ToString().ToDouble(defaultValue);
        }

        /// <summary>
        /// 将输入的字符串转换为Double类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功则返回对应浮点数字，否则返回 0</returns>
        public static double ToDouble(this string input) {
            return input.ToDouble(0);
        }

        /// <summary>
        /// 将输入的字符串转换为Double类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应浮点数字，否则返回默认值</returns>
        public static double ToDouble(this string input, double defaultValue) {
            double output;
            if (!Double.TryParse(input, out output)) {
                return defaultValue;
            }
            return output;
        }

        /// <summary>
        /// 将输入的对象转换为Int32类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <returns>转换成功则返回对应数字，否则返回 0</returns>
        public static int ToInt32(this object input) {
            return input.ToInt32(0);
        }

        /// <summary>
        /// 将输入的对象转换为Int32类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应数字，否则返回默认值</returns>
        public static int ToInt32(this object input, int defaultValue) {
            return (Convert.IsDBNull(input) || Equals(input, null)) ? defaultValue : input.ToString().ToInt32(defaultValue);
        }

        /// <summary>
        /// 将输入的字符串转换为Int32类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功则返回对应数字，否则返回 0</returns>
        public static int ToInt32(this string input) {
            return input.ToInt32(0);
        }

        /// <summary>
        /// 将输入的字符串转换为Int32类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应数字，否则返回默认值</returns>
        public static int ToInt32(this string input, int defaultValue) {
            int output;
            if (!Int32.TryParse(input, out output)) {
                output = defaultValue;
            }
            return output;
        }

        /// <summary>
        /// 将输入的对象转换为float类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <returns>转换成功则返回对应单精度浮点数字，否则返回 0</returns>
        public static float ToSingle(this object input) {
            return input.ToSingle(0);
        }

        /// <summary>
        /// 将输入的对象转换为float类型
        /// </summary>
        /// <param name="input">输入的对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应单精度浮点数字，否则返回默认值</returns>
        public static float ToSingle(this object input, float defaultValue) {
            return (Convert.IsDBNull(input) || Equals(input, null)) ? 0 : input.ToString().ToSingle(defaultValue);
        }

        /// <summary>
        /// 将输入的字符串转换为float类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <returns>转换成功则返回对应单精度浮点数字，否则返回 0</returns>
        public static float ToSingle(this string input) {
            return input.ToSingle(0);
        }

        /// <summary>
        /// 将输入的字符串转换为float类型
        /// </summary>
        /// <param name="input">输入的字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>转换成功则返回对应单精度浮点数字，否则返回默认值</returns>
        public static float ToSingle(this string input, float defaultValue) {
            float output;
            if (!float.TryParse(input, out output)) {
                output = defaultValue;
            }
            return output;
        }
        /// <summary>
        /// 如果传入对象是Null则安全返回string.Empty，否则返回该对象的ToString（）操作
        /// </summary>
        /// <param name="input">输入的字符串</param> 
        /// <returns>空值tostring的处理,防止出现未将对象引用到实例的错误,Null调用将会返回string.Empty结果</returns>
        public static string ToStringExtension(this Object input) {
            if (input is DateTime) {
                return input.ToStandardDateString();
            }
            return input == null ? string.Empty : input.ToString();
        }

        public static void Append(this StringBuilder owner, StringBuilder builder, bool appendLine = false) {
            if (appendLine) {
                owner.AppendLine(builder.ToString());
            } else {
                owner.Append(builder.ToString());
            }
        }
    }
}
