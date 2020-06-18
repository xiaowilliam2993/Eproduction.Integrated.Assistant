using System;
using System.Text;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {

    public partial class StandardExampleForm : Form {

        public StandardExampleForm() {
            InitializeComponent();
        }

        private void StandardExampleForm_Load(object sender, EventArgs e) {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(@"STANDARD FIRST(IGNORE CASE):

CREATE TABLE [#TABLE_NAME]{
    [FIELD_NAME]	[BUSINESS_TYPE:<NAME>]                                                                         >>NOTE <--THE FIRST LINE DEFAULT PRIMARYKEY
    [FIELD_NAME]	[BUSINESS_TYPE:<NAME>]                                                                         >>NOTE
    [FIELD_NAME]	[BUSINESS_TYPE:<NAME>]                                             [DEF <VALUE>]     >>NOTE
    [FIELD_NAME]	[DATA_TYPE]                                                                                              >>NOTE
    [FIELD_NAME]	[DATA_TYPE]|[BUSINESS_TYPE:<NAME>]                                                      >>NOTE
    [FIELD_NAME]	[DATA_TYPE([<SIZE>]|[<LENGTH>,<ACCURACY>])]                                       >>NOTE
    [FIELD_NAME]	[DATA_TYPE]                                                                  [DEF <VALUE>]     >>NOTE
    [FIELD_NAME]	[DATA_TYPE([<SIZE>]|[<LENGTH>,<ACCURACY>])]	[DEF <VALUE>]      >>NOTE
}
CREATE NONCLUSTERED INDEX [INDEX_NAME] ON [#TEMP_NAME](<[FIELD_NAME],,,,,,>)                 >>NOTE

-->Example:
        CREATE TABLE #TEMP_TWGV_B010_01 { T_J_ID                         BusinessType:PrimaryKey                      >>主键  (主键的定义可与Create同行)
             TW_TAXREGISTRATION_ID          BusinessType:PrimaryKey                      >>申报营业人
             DECLARE_YM                     BusinessType:YYYYMM                          >>申报年月
             DATA_TYPE                      INT32                    DEF 0               >>资料类别
             SOURCE_DATA_TYPE               INT32                    DEF 0               >>资料来源类型  1.销项资料 2.销项折让 3.进项资料 4.进项折让  0.其他
             TAXABLE_CATEGORY               INT32                    DEF 0               >>课税类别
             TAX_INVOICE_NATURE             string(20)               DEF ''              >>性质
             CUSTOMS_CLEARANCE              INT32                    DEF 0               >>通关方式
             EXPORT_TYPE                    INT32                    DEF 0               >>外销方式
             ASSET_AMT                      BusinessType:Amount      DEF 0               >>销售固定资产金额
             IMPORT_DUTY_FREE_GOODS_AMT     BusinessType:Amount      DEF 0               >>进口免税货物
             PURCHASE_FOREIGN_LABOR_AMT     BusinessType:Amount      DEF 0               >>购买国外劳务
             LAST_PERIOD_REMAIN_TAX_AMT     BusinessType:Amount      DEF 0               >>上期(月)累计留抵税额
        }
        CREATE NONCLUSTERED INDEX IDX_TEMP_TWGV_B010_01_1 ON #TEMP_TWGV_B010_01 ( TW_TAXREGISTRATION_ID )
        CREATE NONCLUSTERED INDEX IDX_TEMP_TWGV_B010_01_2 ON #TEMP_TWGV_B010_01 ( DATA_TYPE,EXPORT_TYPE  )
");

            richStandardExample.Text = builder.ToString();
        }

        private void StandardExampleForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}