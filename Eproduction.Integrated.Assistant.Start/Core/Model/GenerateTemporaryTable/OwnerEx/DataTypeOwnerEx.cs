using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core {    
    
    public static class DataTypeOwnerEx {

        /// <summary>
        /// 解析数据类型
        /// </summary>
        /// <param name="_tempPropertyNameContent">属性名称</param>
        /// <param name="_tempTypeContent">类型描述</param>
        /// <param name="_lineNo"></param>
        /// <param name="_isBusinessType">输出参数：标识是否是业务类型</param>
        /// <param name="_length">输出参数：长度</param>
        /// <param name="_accuary">输出参数：精度</param>
        /// <param name="_generalDBTypeName">输出参数：GeneralDBType类型名称</param>
        /// <returns></returns>
        public static string AssemblyTypeName(string _tempPropertyNameContent, string _tempTypeContent, int _lineNo, out bool _isBusinessType, out int _length, out int _accuary, out string _generalDBTypeName) {
            _isBusinessType = false;
            _length = 0;
            _accuary = 0;
            _generalDBTypeName = string.Empty;

            string typeName = "object";
            if (string.IsNullOrEmpty(_tempTypeContent)) {
                if (_tempPropertyNameContent.EndsWith("_id", StringComparison.CurrentCultureIgnoreCase)) {
                    typeName = "object";
                    _generalDBTypeName = "Guid";
                } else {
                    typeName = "string";
                    _generalDBTypeName = "String";
                }
            } else {
                if (_tempTypeContent.StartsWith("businesstype:", StringComparison.CurrentCultureIgnoreCase)) {
                    _isBusinessType = true;
                    int colon = _tempTypeContent.IndexOf(":") + 1;
                    typeName = _tempTypeContent.Substring(colon);
                    if (typeName.Contains(" ")) {
                        throw new ExceptionOwnerEx(_lineNo);
                    }
                } else {
                    switch (_tempTypeContent.ToLower()) {
                        case "int":
                        case "int32":
                        case "int64":
                            typeName = "int";
                            _generalDBTypeName = AssemblyIntGeneralDBType(_tempTypeContent.ToLower());
                            break;
                        case"char":                        
                        case "string":
                            typeName = "string";
                            _generalDBTypeName = "String";
                            break;
                        case "text":
                            typeName = "string";
                            _generalDBTypeName = "Text";
                            break;
                        case "decimal":
                            typeName = "decimal";
                            _generalDBTypeName = "Decimal";
                            break;
                        case "double":
                            typeName = "double";
                            _generalDBTypeName = "Decimal";
                            break;
                        case "bool":
                        case "boolean":
                            typeName = "bool";
                            _generalDBTypeName = "Boolean";
                            break;
                        case "float":
                            typeName = "float";
                            _generalDBTypeName = "Decimal";
                            break;
                        case "long":
                            typeName = "long";
                            _generalDBTypeName = "String";
                            break;
                        case "short":
                            typeName = "short";
                            _generalDBTypeName = "String";
                            break;
                        case "time":
                            typeName = "DateTime";
                            _generalDBTypeName = "Time";
                            break;
                        case "date":
                            typeName = "DateTime";
                            _generalDBTypeName = "Date";
                            break;
                        case "datetime":
                            typeName = "DateTime";
                            _generalDBTypeName = "DateTime";
                            break;
                        case "object":
                        case "guid":
                            typeName = "PrimaryKey";
                            _isBusinessType = true;
                            break;
                        default:
                            string tempType;
                            if (_tempTypeContent.ToLower().StartsWith("string", StringComparison.CurrentCultureIgnoreCase)) {
                                tempType = UtilsOwnerEx.GetBracketBetweenContent(_tempTypeContent, _lineNo);
                                _length = tempType.ToInt32();
                                typeName = "string";
                                _generalDBTypeName = "String";
                            } else if (_tempTypeContent.ToLower().StartsWith("decimal", StringComparison.CurrentCultureIgnoreCase)) {
                                tempType = UtilsOwnerEx.GetBracketBetweenContent(_tempTypeContent, _lineNo);
                                if (tempType.Contains(",")) {
                                    string[] array = tempType.Split(',');
                                    _length = array[0].ToInt32();
                                    _accuary = array[1].ToInt32();
                                    typeName = "decimal";
                                    _generalDBTypeName = "Decimal";
                                } else {
                                    _length = tempType.ToInt32();
                                }
                            } else {
                                if (_tempTypeContent.Contains(":")) {
                                    throw new ExceptionOwnerEx(_lineNo);
                                }
 
                                _isBusinessType = true;
                                typeName = _tempTypeContent;
                            }
                            break;
                    }
                }
            }
            return typeName;
        }

        private static string AssemblyIntGeneralDBType(string _tempTypeContent) {
            string generalTypeName = "Auto";
            switch (_tempTypeContent) {
                case "int":
                case "int32":
                    generalTypeName = "Int32";
                    break;
                case "int64":
                    generalTypeName = "Int64";
                    break;
            }
            return generalTypeName;
        }

    }
}
