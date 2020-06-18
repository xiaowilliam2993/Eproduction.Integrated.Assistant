namespace Eproduction.Integrated.Assistant.Start.Core {

    public static class UtilsOwnerEx {

        public static int GetLeftBracketIndex(string _content, int _lineNo) {
            int bracket = _content.IndexOf("(") + 1;
            if (bracket <= 1) throw new ExceptionOwnerEx(_lineNo);
            return bracket;
        }

        public static int GetRightBracketIndex(string _content, int _lineNo) {
            int bracket = _content.IndexOf(")");
            if (bracket <= 1) throw new ExceptionOwnerEx(_lineNo);
            return bracket;
        }

        public static string GetBracketBetweenContent(string _content, int _lineNo) {
            int leftBracket = GetLeftBracketIndex(_content, _lineNo);
            int rightBracket = GetRightBracketIndex(_content, _lineNo);
            string _tempContent = _content.Substring(leftBracket, rightBracket - leftBracket);
            if (string.IsNullOrEmpty(_tempContent)) throw new ExceptionOwnerEx(_lineNo);
            return _tempContent.Trim();
        }

    }
}