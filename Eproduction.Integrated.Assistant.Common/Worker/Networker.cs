using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace Eproduction.Integrated.Assistant.Common.Worker {
    public static class Networker {
        public const string Localhost = "localhost";
        public const string LocalIP = "127.0.0.1";
        /// <summary>
        /// 检查端口是否被占用
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static bool IsUseOfPort(string port) {
            bool use = false;
            var ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            foreach (var point in ipProperties.GetActiveTcpListeners()) {
                if (point.Port.ToString() == port) {
                    use = true;
                    break;
                }
            }
            return use;
        }
        /// <summary>
        /// 校验字符串是否为有效的端口号
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static bool IsPort(this string inputValue) {
            bool successfully = false;
            if (Regex.IsMatch(inputValue, @"^[1-9]\d{0,4}$")) {
                int port;
                if(Int32.TryParse(inputValue, out port)) {
                    if (port >= 0 && port <= 65535) {
                        successfully = true;
                    }
                }
            }
            return successfully;
        }
        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        public static IEnumerable<string> GetAddressIP() {
            try {
                return Dns.GetHostEntry(Dns.GetHostName()).AddressList
                    .Where(_ => _.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    .Select(_ => _.ToString())
                    .ToArray().Concat(new[] { LocalIP });
            } catch (Exception) {
                throw;
            }
        }
        /// <summary>
        /// 获取外网IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetPublicIP() {
            string ip = string.Empty;
            try {
                string strUrl = "http://www.ip138.com/ip2city.asp";
                Uri uri = new Uri(strUrl);
                WebRequest request = WebRequest.Create(uri);
                Stream stream = request.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.Default);
                string content = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(content)) {
                    int startIndex = content.IndexOf("[");
                    int endIndex = content.IndexOf("]");
                    ip = content.Substring(startIndex + 1, (endIndex - 1) - startIndex);
                }
            } catch (Exception) { }
            return ip;
        }
    }
}
