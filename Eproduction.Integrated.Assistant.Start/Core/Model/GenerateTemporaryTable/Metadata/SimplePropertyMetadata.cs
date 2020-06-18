using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public abstract class SimplePropertyMetadata : PrimaryKeyMetadata {

        public SimplePropertyMetadata() 
            : base() {
            SimplePropertyBuilder = new StringBuilder();
        }

        /// <summary>
        /// SimpleProperty转换完成行为标记
        /// </summary>
        public bool SimplePropertyCompletedFlag { get; set; }

        /// <summary>
        /// SimpleProperty转换结果集
        /// </summary>
        public StringBuilder SimplePropertyBuilder { get; set; }

        /// <summary>
        /// 生成简单属性动作代理
        /// </summary>
        public override void GenerateSimpleProperty() {
            base.GenerateSimpleProperty();

            if ("}".Equals(OrgLineText)) {
                SimplePropertyCompletedFlag = true;
                return;
            } else if (OrgLineText.Contains("}")) {
                throw new ExceptionOwnerEx(LineNo);
            }

            AssemblyFormatLineContent();
            AssemblyManager();

            GenerateNotes(SimplePropertyBuilder);
            if (IsBusinessType) {
                SimplePropertyBuilder.AppendLine("                defaultType.RegisterSimpleProperty(\"" + PropertyName + "\", _businessTypeSrv.Simple" + BusinessTypeName + "Type, " + DefaultValue + ", false, new Attribute[] { _businessTypeSrv.Simple" + BusinessTypeName + " });");
            } else {
                SimplePropertyBuilder.AppendLine("                simplePropertyAttribute = new SimplePropertyAttribute(GeneralDBType." + GeneralDBTypeName + ");");
                if (Length > 0) {
                    SimplePropertyBuilder.AppendLine("                simplePropertyAttribute.Size = " + Length + ";");
                }
                if (Accuray > 0) {
                    SimplePropertyBuilder.AppendLine("                simplePropertyAttribute.Scale = " + Accuray + ";");
                }
                SimplePropertyBuilder.AppendLine("                defaultType.RegisterSimpleProperty(\"" + PropertyName + "\", typeof(" + TypeName + "), " + DefaultValue + ", false, new Attribute[] { simplePropertyAttribute });");
            }            
        }
    
    }
}