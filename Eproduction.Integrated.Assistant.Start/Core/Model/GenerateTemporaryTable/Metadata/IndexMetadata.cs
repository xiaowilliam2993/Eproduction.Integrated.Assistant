using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {
    
    public abstract class IndexMetadata : HeaderMetadata {

        public IndexMetadata() 
            : base() {
            Indexer = 1;
            IndexerNames = string.Empty;
            IndexBuilder = new StringBuilder();
        }

        /// <summary>
        /// 索引编号
        /// </summary>
        public int Indexer { get; set; }

        /// <summary>
        /// 索引名称
        /// </summary>
        public string IndexerNames { get; set; }

        /// <summary>
        /// Index成果集
        /// </summary>
        public StringBuilder IndexBuilder { get; set; }

        /// <summary>
        /// 生成索引动作代理
        /// </summary>
        public override void GenerateIndex() {
            base.GenerateIndex();

            AssemblyFormatLineContent();

            if (!FormatLineTextToLower.StartsWith("create nonclustered index", StringComparison.CurrentCultureIgnoreCase) &&
                !FormatLineTextToLower.StartsWith("create unique nonclustered index", StringComparison.CurrentCultureIgnoreCase)) throw new ExceptionOwnerEx(LineNo);
            if (!FormatLineTextToLower.Contains(" on ")) throw new ExceptionOwnerEx(LineNo);

            string _tempContent = UtilsOwnerEx.GetBracketBetweenContent(FormatLineText, LineNo);
            string indexName = string.Empty;
            indexName = "\"";
            if (_tempContent.IndexOf(",") > 0) {
                string[] names = _tempContent.Split(',');
                for (int i = 0; i < names.Length; i++) {
                    if (i == names.Length - 1) {
                        indexName += names[i].Trim();
                    } else {
                        indexName += names[i].Trim() + ",";
                    }
                }
            } else {
                indexName += _tempContent.Trim();
            }
            indexName += "\"";
            GenerateNotes(IndexBuilder);
            IndexBuilder.AppendLine("                DatabaseIndexAttribute idx0" + Indexer + " = new DatabaseIndexAttribute(" + indexName + ");");
            if (FormatLineText.IndexOf(" unique ", StringComparison.CurrentCultureIgnoreCase) > 0) {
                IndexBuilder.AppendLine("                idx0" + Indexer + ".Unique = true;");
            }
            IndexBuilder.AppendLine("                idx0" + Indexer + ".Name = \"IDX" + TemporaryName.Replace('_', '0') + Indexer + "\";");
            IndexerNames += ", idx0" + Indexer;
            Indexer++;
        }

    }
}