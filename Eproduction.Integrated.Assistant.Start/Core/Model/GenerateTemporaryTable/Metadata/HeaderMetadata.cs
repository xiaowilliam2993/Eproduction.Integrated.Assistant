using System;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {
    
    public abstract class HeaderMetadata : BaseMetadata {

        public const string keyF = "create table";

        public HeaderMetadata()
            : base() {
            TemporaryNameFlag = false;
            TemporaryName = string.Empty;
            HeaderBuilder = new StringBuilder();
        }

        public bool TemporaryNameFlag { get; set; }

        /// <summary>
        /// 临时表名称
        /// </summary>
        public string TemporaryName { get; set; }

        /// <summary>
        /// Header转换结果集
        /// </summary>
        public StringBuilder HeaderBuilder { get; set; }

        /// <summary>
        /// Assembly Temporary Table Name
        /// </summary>
        public virtual void AssemblyTemporaryTableNameAndPrimaryKey() {
            AssemblyFormatLineContent();

            if (!FormatLineText.StartsWith(keyF, StringComparison.CurrentCultureIgnoreCase)) {
                throw new ExceptionOwnerEx(LineNo);
            }

            int firstBrackets = FormatLineText.IndexOf("{");
            if (firstBrackets <= 0) {
                throw new ExceptionOwnerEx(LineNo);
            }

            string _tempName = FormatLineText.Substring(keyF.Length + 1, firstBrackets - (keyF.Length + 1)).Replace("#", "").Trim();
            if (string.IsNullOrEmpty(_tempName)) {
                throw new ExceptionOwnerEx(LineNo);
            } else if (_tempName.Contains(" ")) {
                throw new ExceptionOwnerEx(LineNo);
            }
            TemporaryName = _tempName;
            TemporaryNameFlag = true;
        }

        /// <summary>
        /// 生成头部动作代理
        /// </summary>
        public override void GenerateHeader() {
            base.GenerateHeader();

            if (GenerateFunctionNameFlag) {
                HeaderBuilder.AppendLine("            private IDataEntityType _" + TemporaryName + ";");
                HeaderBuilder.AppendLine("            private IBusinessTypeService _businessTypeSrv { get; set; }");
                HeaderBuilder.AppendLine("            private IQueryService _queSrv;");
                HeaderBuilder.AppendLine("            private void CreateTempTable_xEx_Name() {");
            }
            HeaderBuilder.AppendLine("                const string tempName = \"" + TemporaryName + "\";");
            HeaderBuilder.AppendLine("                ");            
        }

    }
}