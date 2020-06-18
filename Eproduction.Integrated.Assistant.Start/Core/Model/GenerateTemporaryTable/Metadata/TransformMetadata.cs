using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public class TransformMetadata : FooterMetadata {

        public TransformMetadata(GenerateTempoarayTableContext context) 
            : base(){
            GenerateFunctionNameFlag = context.GenerateFunctionHeader;
            GenerateNotesFlag = context.GenerateRemark;
            FirstPropertyGeneratePrimaryKey = context.FirstPropertyGeneratePrimaryKey;
            if (TemporaryTableBuilder == null) TemporaryTableBuilder = new StringBuilder();
        }

        /// <summary>
        /// 转换行为代理
        /// </summary>
        public void AppendManager() {
            GenerateHeader();
            GeneratePrimaryKey();
            GenerateFooter();

            TemporaryTableBuilder.Append(HeaderBuilder);
            TemporaryTableBuilder.Append(PrimaryKeyBuilder);
            TemporaryTableBuilder.Append(SimplePropertyBuilder);
            TemporaryTableBuilder.Append(FooterBuilder);
        }

    }
}