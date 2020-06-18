using System;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public abstract class PrimaryKeyMetadata : IndexMetadata {

        public PrimaryKeyMetadata() 
            : base() {
            PrimaryKeyFlag = false;
            PrimaryKeyLineContent = string.Empty;
            PrimaryKeyName = string.Empty;
            PrimaryKeyBuilder = new StringBuilder();
        }

        /// <summary>
        /// 创建主键行为标记
        /// </summary>
        public bool PrimaryKeyFlag { get; set; }

        /// <summary>
        /// 标识将第一个属性创建为主键
        /// </summary>
        public bool FirstPropertyGeneratePrimaryKey { get; set; }

        /// <summary>
        /// Source主键源
        /// </summary>
        public string PrimaryKeyLineContent { get; set; }

        /// <summary>
        /// 原Source主键源
        /// </summary>
        public string OrgPrimaryKeyLineContent { get; set; }

        /// <summary>
        /// 主键名称
        /// </summary>
        public string PrimaryKeyName { get; set; }

        /// <summary>
        /// 主键行号
        /// </summary>
        public int PrimaryKeyLineNo { get; set; }

        /// <summary>
        /// PrimaryKey转换成果集
        /// </summary>
        public StringBuilder PrimaryKeyBuilder { get; set; }

        /// <summary>
        /// 生成主键动作代理
        /// </summary>
        public override void GeneratePrimaryKey() {
            base.GeneratePrimaryKey();
            
            if (!string.IsNullOrEmpty(IndexerNames)) {
                PrimaryKeyBuilder.AppendLine("                #region 创建索引");
                PrimaryKeyBuilder.Append(IndexBuilder.ToString());
                PrimaryKeyBuilder.AppendLine("                #endregion");
                PrimaryKeyBuilder.AppendLine("                ");
                PrimaryKeyBuilder.AppendLine("                DependencyObjectType defaultType = new DependencyObjectType(tempName, new Attribute[] { new DataEntityAttribute(\"" + PrimaryKeyName + "\")" + IndexerNames + " });");
            } else {
                PrimaryKeyBuilder.AppendLine("                DependencyObjectType defaultType = new DependencyObjectType(tempName, new Attribute[] { new DataEntityAttribute(\"" + PrimaryKeyName + "\") });");
            }
            PrimaryKeyBuilder.AppendLine("                SimplePropertyAttribute simplePropertyAttribute;");
            PrimaryKeyBuilder.AppendLine("                ");

            if (FirstPropertyGeneratePrimaryKey) {
                PrimaryKeyBuilder.AppendLine("                #region 创建主键");

                OrgLineText = OrgPrimaryKeyLineContent;
                LineNo = PrimaryKeyLineNo;
                AssemblyFormatLineContent();
                AssemblyManager();
                if (string.Compare(BusinessTypeName, "primarykey", StringComparison.CurrentCultureIgnoreCase) < 0) {
                    throw new ExceptionOwnerEx(LineNo, "第一个字段的类型必须是PrimaryKey或object，不符合创建主键的要求");
                }

                GenerateNotes(PrimaryKeyBuilder);
                PrimaryKeyBuilder.AppendLine("                defaultType.RegisterSimpleProperty(\"" + PropertyName + "\", _businessTypeSrv.Simple" + BusinessTypeName + "Type, " + DefaultValue + ", false, new Attribute[] { _businessTypeSrv.Simple" + BusinessTypeName + " });");
                PrimaryKeyBuilder.AppendLine("                #endregion");
                PrimaryKeyBuilder.AppendLine("                ");
            }
            PrimaryKeyBuilder.AppendLine("                #region 创建其他属性（字段）");
        }

        public override void AssemblyTemporaryTableNameAndPrimaryKey() {
            base.AssemblyTemporaryTableNameAndPrimaryKey();

            int bracket = FormatLineText.IndexOf("{") + 1;
            if (bracket <= 1) throw new ExceptionOwnerEx(LineNo);

            OrgPrimaryKeyLineContent = OrgLineText.Substring(OrgLineText.IndexOf("{") + 1).TrimStart();
            string tempText = FormatLineText.Substring(bracket).Trim();

            if (!string.IsNullOrEmpty(tempText)) {
                FormatLineText = tempText;

                RecodePrimaryKeyContent();
                AssemblyManager();
            }
        }

        public void RecodePrimaryKeyContent() {
            RecodePrimaryKeyContent(false);
        }

        public void RecodePrimaryKeyContent(bool needAssemblyPropertyName) {
            if (needAssemblyPropertyName) {
                OrgPrimaryKeyLineContent = OrgLineText;
                AssemblyFormatLineContent();
                PrimaryKeyLineNo = LineNo;
            }
            PrimaryKeyLineContent = FormatLineText;
            AssemblyPropertyValue(PrimaryKeyLineContent);

            PrimaryKeyName = PropertyName;
            PrimaryKeyFlag = true;
        }
    
    }
}