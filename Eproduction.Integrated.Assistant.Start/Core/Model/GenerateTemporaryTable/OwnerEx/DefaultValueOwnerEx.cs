using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core {

    public static class DefaultValueOwnerEx {

        public static string AssemblyDefaultValue(string _tempPropertyNameContent, string _tempTypeName, string _tempValueContent, bool _tempIsBusinessType, int _lineNo) {
            string value = string.Empty;

            if (string.IsNullOrEmpty(_tempValueContent)) {
                if (_tempPropertyNameContent.EndsWith("_id", StringComparison.CurrentCultureIgnoreCase) || _tempPropertyNameContent.EndsWith("_roid", StringComparison.CurrentCultureIgnoreCase)) {
                    value = "Maths.GuidDefaultValue()";
                } else {
                    value = AssemblyValueOfType(_tempTypeName, _tempIsBusinessType);
                }
            } else {
                string[] stringEmptyTypes = new string[] { "''", "' '", "'_'", "string.empty" };
                if (stringEmptyTypes.Contains(_tempValueContent)) {
                    value = "string.Empty";
                } else if (_tempValueContent.StartsWith("def", StringComparison.CurrentCultureIgnoreCase) || _tempValueContent.StartsWith("def:", StringComparison.CurrentCultureIgnoreCase)) {
                    int underline = _tempValueContent.IndexOf("_") + 1;
                    string tempValue = _tempValueContent.Substring(underline).Replace("_", " ").TrimEnd();
                    if (stringEmptyTypes.Contains(tempValue)) {
                        value = "string.Empty";
                    } else if (_tempIsBusinessType) {
                        string typeName = _tempTypeName;
                        if (_tempTypeName.StartsWith("businesstype:", StringComparison.CurrentCultureIgnoreCase)) {
                            int colon = _tempTypeName.IndexOf(":") + 1;
                            typeName = _tempTypeName.Substring(colon);
                        }
                        value = AssemblyDefaultValueWithBusinessType(typeName, tempValue);
                    } else {
                        value = tempValue;
                        if ("string".Equals(_tempTypeName)) {
                            value = "\"" + value + "\"";
                        } else if ("true".Equals(value, StringComparison.CurrentCultureIgnoreCase)) {
                            value = "true";
                        } else if ("false".Equals(value, StringComparison.CurrentCultureIgnoreCase)) {
                            value = "false";
                        } else if (_tempTypeName == "bool" || _tempTypeName == "boolean") {
                            value = "false";
                        }
                    }
                } else {
                    value = "\"" + _tempValueContent + "\"";
                }
            }
            value = value.Replace("'", "");
            if (value == "\"\"") {
                value = "string.Empty";
            }

            return value;
        }

        private static string AssemblyValueOfType(string _tempTypeName, bool _tempIsBusinessType) {
            string value = string.Empty;
            if (_tempIsBusinessType) {
                string businessTypeName = _tempTypeName;
                if (_tempTypeName.StartsWith("businesstype:", StringComparison.CurrentCultureIgnoreCase)) {
                    int colon = businessTypeName.IndexOf(":") + 1;
                    businessTypeName = businessTypeName.Substring(colon);
                }
                value = AssemblyDefaultValueWithBusinessType(businessTypeName, string.Empty);
            } else {
                switch (_tempTypeName.ToLower()) {
                    case "int":
                        value = "0";
                        break;
                    case "string":
                        value = "string.Empty";
                        break;
                    case "decimal":
                        value = "0m";
                        break;
                    case "double":
                        value = "0d";
                        break;
                    case "bool":
                        value = "false";
                        break;
                    case "float":
                        value = "0f";                        
                        break;
                    case "long":
                        value = "0l";
                        break;
                    case "datetime":
                        value = "OrmDataOption.EmptyDateTime";
                        break;
                    default:
                        value = "string.Empty";
                        break;
                }
            }
            return value;
        }

        private static string AssemblyDefaultValueWithBusinessType(string businessTypeName, string defaultVaue) {
            string value = string.Empty;
            switch (businessTypeName.ToLower()) {
                case "amount":
                case "rate":
                case "taxrate":
                case "exchangerate":
                case "quantity":
                case "discount":
                case "unitprice":
                    if (string.IsNullOrEmpty(defaultVaue)) {
                        value = "0m";
                    } else {
                        if (!defaultVaue.EndsWith("m", StringComparison.CurrentCultureIgnoreCase)) {
                            value = defaultVaue + "m";
                        } else {
                            value = defaultVaue;
                        }
                    }
                    break;
                case "date":
                case "datetime":
                    value = "OrmDataOption.EmptyDateTime";
                    break;
                case "primarykey":
                    value = "Maths.GuidDefaultValue()";
                    break;
                default:
                    value = "string.Empty";
                    break;
            }
            return value;
        }

    }
}
