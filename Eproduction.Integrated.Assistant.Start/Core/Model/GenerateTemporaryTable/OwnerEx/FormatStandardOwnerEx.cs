using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core {

    public static class FormatStandardOwnerEx {

        /// <summary>
        /// 清理行内容中的非法字符，转化化为标准的格式
        /// </summary>
        /// <param name="_lineContent"></param>
        /// <param name="_lineNo"></param>
        /// <returns></returns>
        public static string FormatLineContent(string _lineContent, int _lineNo) {
            _lineContent = _lineContent.Replace("\t", " ");
            string _tempContent = string.Empty;
            if (string.IsNullOrEmpty(_lineContent)) return _tempContent;
            if (!_lineContent.Contains(' ')) throw new ExceptionOwnerEx(_lineNo);

            bool noteFlag = false;
            bool defFlag = false;
            string[] _array = _lineContent.Split(' ');
            foreach (var _c in _array) {
                if (string.IsNullOrEmpty(_c)) {
                    continue;
                }

                if (_c.StartsWith("def", StringComparison.CurrentCultureIgnoreCase) || (defFlag && !_c.StartsWith(">>"))) {
                    defFlag = true;
                    _tempContent += _c + "_";
                } else if (defFlag && _c.StartsWith(">>")) {
                    defFlag = false;
                    noteFlag = true;
                    _tempContent += " " + _c;
                } else if(!defFlag && _c.StartsWith(">>")){
                    noteFlag = true;
                    _tempContent += _c;
                } else {
                    if (noteFlag) {
                        _tempContent += _c;
                    } else {
                        _tempContent += _c + " ";
                    }
                }
            }
            _tempContent = _tempContent.Replace("【", "'【").Replace("】", "】'").Replace("' '", "''").Trim();

            return _tempContent;
        }

    }
}
