using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Worker;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class CompressAndDecomporessControl : UserControl {
        private EpIAContext _EpIAContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        public CompressAndDecomporessControl(EpIAContext context) {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _EpIAContext = context;

            //
            // pnlCompressedLineNo
            //
            pnlCompressedLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxCompressed, (Panel)o); };
            //
            // richboxCompressed
            //
            richboxCompressed.TextChanged += (o, v) => { pnlCompressedLineNo.Invalidate(); };
            richboxCompressed.VScroll += (o, v) => { pnlCompressedLineNo.Invalidate(); };
            //
            // pnlDecompressedLineNo
            //
            pnlDecompressedLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxDecompressed, (Panel)o); };
            //
            // richboxDecompressed
            //
            richboxDecompressed.TextChanged += (o, v) => { pnlDecompressedLineNo.Invalidate(); };
            richboxDecompressed.VScroll += (o, v) => { pnlDecompressedLineNo.Invalidate(); };
        }

        private void btnClear_Click(object sender, EventArgs e) {
            richboxCompressed.Clear();
            richboxDecompressed.Clear();
        }

        private void btnWordWarp_Click(object sender, EventArgs e) {
            richboxCompressed.WordWrap = !richboxCompressed.WordWrap;
            richboxDecompressed.WordWrap = !richboxDecompressed.WordWrap;
        }

        private void btnCompression_Click(object sender, EventArgs e) {
            string source = richboxCompressed.Text;
            int maxLength = (int)(6 * Math.Pow(1024, 2));
            if (source.Length > maxLength) {
                MessageBox.Show("抱歉，压缩来源超长，最大支持6兆以内长度的内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] buffer = Encoding.Unicode.GetBytes(source);
            MemoryStream ms = new MemoryStream();
            using (var stream = new DeflateStream(ms, CompressionMode.Compress, true)) {
                stream.Write(buffer, 0, buffer.Length);
                stream.Close();
            }
            buffer = ms.ToArray();
            ms.Close();

            richboxDecompressed.Text = Convert.ToBase64String(buffer);
        }

        private void btnDecompression_Click(object sender, EventArgs e) {
            string source = richboxDecompressed.Text;

            byte[] buffer = Convert.FromBase64String(source);
            MemoryStream ms = new MemoryStream();
            ms.Write(buffer, 0, buffer.Length);
            ms.Position = 0;

            int size = (int)((double)6 * Math.Pow(1024, 2));
            byte[] decompressBuffer = new byte[size];
            using (var stream = new DeflateStream(ms, CompressionMode.Decompress)) {
                stream.Flush();
                stream.Read(decompressBuffer, 0, size);
                ms.Close();
                ms.Dispose();
            }

            richboxCompressed.Text = Encoding.Unicode.GetString(decompressBuffer, 0, size);
        }
    }
}
