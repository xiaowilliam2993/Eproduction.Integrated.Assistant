using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Eproduction.Integrated.Assistant.Start.Core.Model {

    [Description("定义生成临时表所需的动作代理")]
    public interface ITemporary {

        /// <summary>
        /// 生成头部动作代理
        /// </summary>
        void GenerateHeader();

        /// <summary>
        /// 生成索引动作代理
        /// </summary>
        void GenerateIndex();

        /// <summary>
        /// 生成主键动作代理
        /// </summary>
        /// <returns></returns>
        void GeneratePrimaryKey();

        /// <summary>
        /// 生成简单属性动作代理
        /// </summary>
        void GenerateSimpleProperty();

        /// <summary>
        /// 生成脚部动作代理
        /// </summary>
        void GenerateFooter();

    }
}
