namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {

    public class PropertyMetadata {

        public PropertyMetadata() {
            PropertyName = string.Empty;
            TypeName = string.Empty;
            GeneralDBTypeName = string.Empty;
            IsBusinessType = false;
            BusinessTypeName = string.Empty;
            Length = 0;
            Accuray = 0;
            DefaultValue = string.Empty;
            NoteContent = string.Empty;            
            TempTypeNameContent = string.Empty;
            TempDefaultValueContent = string.Empty;
            TempNotesContent = string.Empty;
        }

        /// <summary>
        /// 属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// GeneralDBType类型名称
        /// </summary>
        public string GeneralDBTypeName { get; set; }

        /// <summary>
        /// 标记该字段是BusinessType类型
        /// </summary>
        public bool IsBusinessType { get; set; }

        /// <summary>
        /// BusinessType名称，否则就是普通数据类型
        /// </summary>
        public string BusinessTypeName { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// 精度
        /// </summary>
        public int Accuray { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 注释文本
        /// </summary>
        public string NoteContent { get; set; }

        public string TempTypeNameContent { get; set; }

        public string TempDefaultValueContent { get; set; }

        public string TempNotesContent { get; set; }

    }
}