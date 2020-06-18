using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public abstract class FooterMetadata : SimplePropertyMetadata {

        public FooterMetadata() 
            : base(){
            FooterBuilder = new StringBuilder();
        }

        /// <summary>
        /// Footer转换结果集
        /// </summary>
        public StringBuilder FooterBuilder { get; set; }

        /// <summary>
        /// 生成脚部动作代理
        /// </summary>
        public override void GenerateFooter() {
            base.GenerateFooter();

            FooterBuilder.AppendLine("                #endregion");
            FooterBuilder.AppendLine("                ");
            FooterBuilder.AppendLine("                _" + TemporaryName + " = defaultType;");
            FooterBuilder.AppendLine("                _queSrv.CreateTempTable(_" + TemporaryName + ");");
            if (GenerateFunctionNameFlag) FooterBuilder.AppendLine("            }");
        }
    
    }
}