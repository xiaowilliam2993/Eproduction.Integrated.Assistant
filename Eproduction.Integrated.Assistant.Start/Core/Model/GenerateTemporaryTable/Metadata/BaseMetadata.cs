using System;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public class BaseMetadata : PropertyMetadata, ITemporary, IDisposable {

        public void Dispose() {
            GC.SuppressFinalize(this);
        }

        public BaseMetadata() 
            : base() {
            TransformFlag = false;
            OrgLineText = string.Empty;
            FormatLineText = string.Empty;
            FirstLineHavePrimaryKeyFlag = false;
            LineNo = 1;
            Lines = new string[] { };
            CodeBuilder = new StringBuilder();
            GenerateFunctionNameFlag = false;
            GenerateNotesFlag = false;
        }

        /// <summary>
        /// 转换行为标记
        /// </summary>
        public bool TransformFlag { get; set; }

        /// <summary>
        /// Source行原记录值
        /// </summary>
        public string OrgLineText { get; set; }

        /// <summary>
        /// Format之后的记录行文本内容
        /// </summary>
        public string FormatLineText { get; set; }

        /// <summary>
        /// 标识首行是否包含主键
        /// </summary>
        public bool FirstLineHavePrimaryKeyFlag { get; set; }

        /// <summary>
        /// Format之后的记录行文本内容小写格式
        /// </summary>
        public string FormatLineTextToLower { get { return FormatLineText.ToLower(); } }

        /// <summary>
        /// Format之后的记录行文本内容大写格式
        /// </summary>
        public string FormatLineTextToUpper { get { return FormatLineText.ToUpper(); } }

        /// <summary>
        /// 行号
        /// </summary>
        public int LineNo { get; set; }

        /// <summary>
        /// Source所有行原始记录
        /// </summary>
        public string[] Lines { get; set; }

        /// <summary>
        /// 源码转换成果集
        /// </summary>
        public StringBuilder CodeBuilder { get; set; }

        /// <summary>
        /// 生成方法名称行为标记
        /// </summary>
        public bool GenerateFunctionNameFlag { get; set; }

        /// <summary>
        /// 生成注释行为标记
        /// </summary>
        public bool GenerateNotesFlag { get; set; }

        /// <summary>
        /// 转换最终结果集
        /// </summary>
        public virtual StringBuilder TemporaryTableBuilder { get; set; }

        /// <summary>
        /// 生成注释动作代理
        /// </summary>
        /// <param name="_builderAgent"></param>
        public virtual void GenerateNotes(StringBuilder _builderAgent) {
            if (GenerateNotesFlag) {
                _builderAgent.AppendLine("                //" + OrgLineText);
            }
        }

        /// <summary>
        /// 格式化记录行内容
        /// </summary>
        public virtual void AssemblyFormatLineContent() {
            FormatLineText = FormatStandardOwnerEx.FormatLineContent(OrgLineText, LineNo);
        }

        /// <summary>
        /// 解析属性值动作代理
        /// </summary>
        public virtual void AssemblyPropertyValue() {
            AssemblyPropertyValue(string.Empty);
        }

        /// <summary>
        /// 解析属性值动作代理
        /// </summary>
        /// <param name="lineTextContent"></param>
        public virtual void AssemblyPropertyValue(string lineTextContent) {
            string _tempLineTextContent = FormatLineText;
            if (!string.IsNullOrEmpty(lineTextContent)) {
                _tempLineTextContent = lineTextContent;
            }

            if (string.IsNullOrEmpty(FormatLineText)) throw new ExceptionOwnerEx(LineNo);

            string[] valueArray = FormatLineText.Split(' ');
            if (valueArray.Length > 4 || valueArray.Length <= 1) throw new ExceptionOwnerEx(LineNo);

            PropertyName = valueArray[0];
            if (valueArray.Length == 4) {
                TempTypeNameContent = valueArray[1];
                TempDefaultValueContent = valueArray[2];
                TempNotesContent = valueArray[3];
            } else if (valueArray.Length == 3) {
                string tempValule = valueArray[1];
                if (tempValule.StartsWith("def_", StringComparison.CurrentCultureIgnoreCase)) {
                    TempDefaultValueContent = tempValule;
                    TempTypeNameContent = string.Empty;
                } else {
                    TempDefaultValueContent = string.Empty;
                    TempTypeNameContent = tempValule;
                }
                TempNotesContent = valueArray[2];
            } else if (valueArray.Length == 2) {
                TempTypeNameContent = valueArray[1];
            }
        }

        /// <summary>
        /// 解析数据类型动作代理
        /// </summary>
        public virtual void AssemblyDataType() {
            bool isBusinessType;
            int length, accuray;
            string generalDBType;
            TypeName = DataTypeOwnerEx.AssemblyTypeName(PropertyName, TempTypeNameContent, LineNo, out isBusinessType, out length, out accuray, out generalDBType);
            IsBusinessType = isBusinessType;
            BusinessTypeName = IsBusinessType ? TypeName : string.Empty;
            Length = length;
            Accuray = accuray;
            GeneralDBTypeName = generalDBType;
        }

        /// <summary>
        /// 解析默认值动作代理
        /// </summary>
        public virtual void AssemblyDefaultValue() {
            DefaultValue = DefaultValueOwnerEx.AssemblyDefaultValue(PropertyName, TypeName, TempDefaultValueContent, IsBusinessType, LineNo);
        }

        /// <summary>
        /// 总代理
        /// </summary>
        public virtual void AssemblyManager() {            
            AssemblyPropertyValue();
            AssemblyDataType();
            AssemblyDefaultValue();
        }

        /// <summary>
        /// 生成头部动作代理
        /// </summary>
        public virtual void GenerateHeader() { }

        /// <summary>
        /// 生成索引动作代理
        /// </summary>
        public virtual void GenerateIndex() { }

        /// <summary>
        /// 生成主键动作代理
        /// </summary>
        public virtual void GeneratePrimaryKey() { }

        /// <summary>
        /// 生成简单属性动作代理
        /// </summary>
        public virtual void GenerateSimpleProperty() { }

        /// <summary>
        /// 生成脚部动作代理
        /// </summary>
        public virtual void GenerateFooter() { }

    }
}
