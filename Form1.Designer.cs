
namespace HMapLoader_GMap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pn = new Panel();
            chkGrid = new CheckBox();
            tbLng = new TextBox();
            tbZoom = new TextBox();
            tbLat = new TextBox();
            btnCrawl = new Button();
            btnDraw = new Button();
            btnClear = new Button();
            tbCrawlOutput = new TextBox();
            btnCrawlOutput = new Button();
            gb = new GroupBox();
            nudCrawlExtentR = new NumericUpDown();
            nudCrawlExtentL = new NumericUpDown();
            nudCrawlExtentD = new NumericUpDown();
            nudCrawlExtentU = new NumericUpDown();
            nudCrawlColMax = new NumericUpDown();
            nudCrawlColMin = new NumericUpDown();
            nudCrawlRowMax = new NumericUpDown();
            nudCrawlRowMin = new NumericUpDown();
            tbTileCount = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbCrawl = new Label();
            label2 = new Label();
            nudZoom = new NumericUpDown();
            btnCombineInput = new Button();
            tbCombineInput = new TextBox();
            lbCombine = new Label();
            btnCombine = new Button();
            groupBox1 = new GroupBox();
            btnCombineOutput = new Button();
            tbCombineOutput = new TextBox();
            label3 = new Label();
            label1 = new Label();
            cmbMapType = new ComboBox();
            label12 = new Label();
            gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlColMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlColMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlRowMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlRowMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pn
            // 
            pn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn.Location = new Point(12, 11);
            pn.Name = "pn";
            pn.Size = new Size(844, 725);
            pn.TabIndex = 0;
            // 
            // chkGrid
            // 
            chkGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkGrid.AutoSize = true;
            chkGrid.BackColor = Color.Transparent;
            chkGrid.Location = new Point(862, 35);
            chkGrid.Name = "chkGrid";
            chkGrid.Size = new Size(51, 21);
            chkGrid.TabIndex = 4;
            chkGrid.Text = "网格";
            chkGrid.UseVisualStyleBackColor = false;
            chkGrid.CheckedChanged += chkGrid_CheckedChanged;
            // 
            // tbLng
            // 
            tbLng.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLng.Location = new Point(896, 60);
            tbLng.Name = "tbLng";
            tbLng.ReadOnly = true;
            tbLng.Size = new Size(143, 23);
            tbLng.TabIndex = 7;
            // 
            // tbZoom
            // 
            tbZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbZoom.Location = new Point(862, 60);
            tbZoom.Name = "tbZoom";
            tbZoom.ReadOnly = true;
            tbZoom.Size = new Size(28, 23);
            tbZoom.TabIndex = 1;
            // 
            // tbLat
            // 
            tbLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLat.Location = new Point(1044, 60);
            tbLat.Name = "tbLat";
            tbLat.ReadOnly = true;
            tbLat.Size = new Size(143, 23);
            tbLat.TabIndex = 8;
            // 
            // btnCrawl
            // 
            btnCrawl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCrawl.Location = new Point(9, 362);
            btnCrawl.Name = "btnCrawl";
            btnCrawl.Size = new Size(310, 41);
            btnCrawl.TabIndex = 3;
            btnCrawl.Text = "爬取";
            btnCrawl.UseVisualStyleBackColor = true;
            btnCrawl.Click += btnCrawl_Click;
            // 
            // btnDraw
            // 
            btnDraw.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDraw.Location = new Point(6, 22);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(153, 36);
            btnDraw.TabIndex = 5;
            btnDraw.Text = "开始框选";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(165, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 36);
            btnClear.TabIndex = 6;
            btnClear.Text = "清空绘制";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tbCrawlOutput
            // 
            tbCrawlOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCrawlOutput.Location = new Point(65, 333);
            tbCrawlOutput.Name = "tbCrawlOutput";
            tbCrawlOutput.Size = new Size(217, 23);
            tbCrawlOutput.TabIndex = 9;
            // 
            // btnCrawlOutput
            // 
            btnCrawlOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCrawlOutput.Location = new Point(288, 333);
            btnCrawlOutput.Name = "btnCrawlOutput";
            btnCrawlOutput.Size = new Size(31, 23);
            btnCrawlOutput.TabIndex = 10;
            btnCrawlOutput.Text = "...";
            btnCrawlOutput.UseVisualStyleBackColor = true;
            btnCrawlOutput.Click += btnCrawlOutput_Click;
            // 
            // gb
            // 
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gb.Controls.Add(nudCrawlExtentR);
            gb.Controls.Add(nudCrawlExtentL);
            gb.Controls.Add(nudCrawlExtentD);
            gb.Controls.Add(nudCrawlExtentU);
            gb.Controls.Add(nudCrawlColMax);
            gb.Controls.Add(nudCrawlColMin);
            gb.Controls.Add(nudCrawlRowMax);
            gb.Controls.Add(nudCrawlRowMin);
            gb.Controls.Add(tbTileCount);
            gb.Controls.Add(label11);
            gb.Controls.Add(label10);
            gb.Controls.Add(label9);
            gb.Controls.Add(label8);
            gb.Controls.Add(label7);
            gb.Controls.Add(label6);
            gb.Controls.Add(label5);
            gb.Controls.Add(label4);
            gb.Controls.Add(lbCrawl);
            gb.Controls.Add(label2);
            gb.Controls.Add(nudZoom);
            gb.Controls.Add(btnCrawlOutput);
            gb.Controls.Add(tbCrawlOutput);
            gb.Controls.Add(btnCrawl);
            gb.Controls.Add(btnDraw);
            gb.Controls.Add(btnClear);
            gb.Location = new Point(862, 110);
            gb.Name = "gb";
            gb.Size = new Size(325, 415);
            gb.TabIndex = 14;
            gb.TabStop = false;
            gb.Text = "爬取";
            // 
            // nudCrawlExtentR
            // 
            nudCrawlExtentR.DecimalPlaces = 6;
            nudCrawlExtentR.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
            nudCrawlExtentR.Location = new Point(220, 101);
            nudCrawlExtentR.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudCrawlExtentR.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudCrawlExtentR.Name = "nudCrawlExtentR";
            nudCrawlExtentR.Size = new Size(91, 23);
            nudCrawlExtentR.TabIndex = 39;
            nudCrawlExtentR.ValueChanged += nudCrawlExtent_ValueChanged;
            // 
            // nudCrawlExtentL
            // 
            nudCrawlExtentL.DecimalPlaces = 6;
            nudCrawlExtentL.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
            nudCrawlExtentL.Location = new Point(86, 101);
            nudCrawlExtentL.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudCrawlExtentL.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudCrawlExtentL.Name = "nudCrawlExtentL";
            nudCrawlExtentL.Size = new Size(91, 23);
            nudCrawlExtentL.TabIndex = 38;
            nudCrawlExtentL.ValueChanged += nudCrawlExtent_ValueChanged;
            // 
            // nudCrawlExtentD
            // 
            nudCrawlExtentD.DecimalPlaces = 6;
            nudCrawlExtentD.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
            nudCrawlExtentD.Location = new Point(146, 130);
            nudCrawlExtentD.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudCrawlExtentD.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudCrawlExtentD.Name = "nudCrawlExtentD";
            nudCrawlExtentD.Size = new Size(91, 23);
            nudCrawlExtentD.TabIndex = 37;
            nudCrawlExtentD.ValueChanged += nudCrawlExtent_ValueChanged;
            // 
            // nudCrawlExtentU
            // 
            nudCrawlExtentU.DecimalPlaces = 6;
            nudCrawlExtentU.Increment = new decimal(new int[] { 1, 0, 0, 393216 });
            nudCrawlExtentU.Location = new Point(146, 72);
            nudCrawlExtentU.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudCrawlExtentU.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudCrawlExtentU.Name = "nudCrawlExtentU";
            nudCrawlExtentU.Size = new Size(91, 23);
            nudCrawlExtentU.TabIndex = 36;
            nudCrawlExtentU.ValueChanged += nudCrawlExtent_ValueChanged;
            // 
            // nudCrawlColMax
            // 
            nudCrawlColMax.Location = new Point(232, 243);
            nudCrawlColMax.Maximum = new decimal(new int[] { 0, 16, 0, 0 });
            nudCrawlColMax.Name = "nudCrawlColMax";
            nudCrawlColMax.Size = new Size(79, 23);
            nudCrawlColMax.TabIndex = 35;
            nudCrawlColMax.ValueChanged += tbTileCount_Update;
            // 
            // nudCrawlColMin
            // 
            nudCrawlColMin.Location = new Point(124, 243);
            nudCrawlColMin.Maximum = new decimal(new int[] { 0, 16, 0, 0 });
            nudCrawlColMin.Name = "nudCrawlColMin";
            nudCrawlColMin.Size = new Size(79, 23);
            nudCrawlColMin.TabIndex = 34;
            nudCrawlColMin.ValueChanged += tbTileCount_Update;
            // 
            // nudCrawlRowMax
            // 
            nudCrawlRowMax.Location = new Point(232, 215);
            nudCrawlRowMax.Maximum = new decimal(new int[] { 0, 16, 0, 0 });
            nudCrawlRowMax.Name = "nudCrawlRowMax";
            nudCrawlRowMax.Size = new Size(79, 23);
            nudCrawlRowMax.TabIndex = 33;
            nudCrawlRowMax.ValueChanged += tbTileCount_Update;
            // 
            // nudCrawlRowMin
            // 
            nudCrawlRowMin.Location = new Point(124, 215);
            nudCrawlRowMin.Maximum = new decimal(new int[] { 0, 16, 0, 0 });
            nudCrawlRowMin.Name = "nudCrawlRowMin";
            nudCrawlRowMin.Size = new Size(79, 23);
            nudCrawlRowMin.TabIndex = 32;
            nudCrawlRowMin.ValueChanged += tbTileCount_Update;
            // 
            // tbTileCount
            // 
            tbTileCount.Location = new Point(65, 291);
            tbTileCount.Name = "tbTileCount";
            tbTileCount.ReadOnly = true;
            tbTileCount.Size = new Size(63, 23);
            tbTileCount.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 294);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 30;
            label11.Text = "瓦片数量";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 336);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 29;
            label10.Text = "输出路径";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 245);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 28;
            label9.Text = "列(Col)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 245);
            label8.Name = "label8";
            label8.Size = new Size(17, 17);
            label8.TabIndex = 26;
            label8.Text = "~";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 221);
            label7.Name = "label7";
            label7.Size = new Size(17, 17);
            label7.TabIndex = 23;
            label7.Text = "~";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 217);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 22;
            label6.Text = "行(Row)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 230);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 21;
            label5.Text = "瓦片范围";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 20;
            label4.Text = "框选范围(°)";
            // 
            // lbCrawl
            // 
            lbCrawl.AutoSize = true;
            lbCrawl.Location = new Point(146, 304);
            lbCrawl.Name = "lbCrawl";
            lbCrawl.Size = new Size(0, 17);
            lbCrawl.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 169);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 13;
            label2.Text = "爬取级别";
            // 
            // nudZoom
            // 
            nudZoom.Location = new Point(68, 167);
            nudZoom.Name = "nudZoom";
            nudZoom.Size = new Size(44, 23);
            nudZoom.TabIndex = 12;
            nudZoom.ValueChanged += nudZoom_ValueChanged;
            // 
            // btnCombineInput
            // 
            btnCombineInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCombineInput.Location = new Point(288, 16);
            btnCombineInput.Name = "btnCombineInput";
            btnCombineInput.Size = new Size(31, 23);
            btnCombineInput.TabIndex = 19;
            btnCombineInput.Text = "...";
            btnCombineInput.UseVisualStyleBackColor = true;
            btnCombineInput.Click += btnCombineOutput_Click;
            // 
            // tbCombineInput
            // 
            tbCombineInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCombineInput.Location = new Point(65, 16);
            tbCombineInput.Name = "tbCombineInput";
            tbCombineInput.Size = new Size(217, 23);
            tbCombineInput.TabIndex = 18;
            // 
            // lbCombine
            // 
            lbCombine.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbCombine.AutoSize = true;
            lbCombine.Location = new Point(159, 128);
            lbCombine.Name = "lbCombine";
            lbCombine.Size = new Size(0, 17);
            lbCombine.TabIndex = 17;
            // 
            // btnCombine
            // 
            btnCombine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCombine.Location = new Point(6, 104);
            btnCombine.Name = "btnCombine";
            btnCombine.Size = new Size(310, 41);
            btnCombine.TabIndex = 15;
            btnCombine.Text = "拼图";
            btnCombine.UseVisualStyleBackColor = true;
            btnCombine.Click += btnCombine_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCombineOutput);
            groupBox1.Controls.Add(tbCombineOutput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCombineInput);
            groupBox1.Controls.Add(btnCombine);
            groupBox1.Controls.Add(tbCombineInput);
            groupBox1.Controls.Add(lbCombine);
            groupBox1.Location = new Point(862, 581);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 155);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "拼接";
            // 
            // btnCombineOutput
            // 
            btnCombineOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCombineOutput.Location = new Point(288, 57);
            btnCombineOutput.Name = "btnCombineOutput";
            btnCombineOutput.Size = new Size(31, 23);
            btnCombineOutput.TabIndex = 23;
            btnCombineOutput.Text = "...";
            btnCombineOutput.UseVisualStyleBackColor = true;
            // 
            // tbCombineOutput
            // 
            tbCombineOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCombineOutput.Location = new Point(65, 57);
            tbCombineOutput.Name = "tbCombineOutput";
            tbCombineOutput.Size = new Size(217, 23);
            tbCombineOutput.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 21;
            label3.Text = "输出路径";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 20;
            label1.Text = "瓦片路径";
            // 
            // cmbMapType
            // 
            cmbMapType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMapType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMapType.FormattingEnabled = true;
            cmbMapType.Items.AddRange(new object[] { "矢量", "影像", "路网" });
            cmbMapType.Location = new Point(918, 11);
            cmbMapType.Name = "cmbMapType";
            cmbMapType.Size = new Size(121, 25);
            cmbMapType.TabIndex = 16;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(857, 15);
            label12.Name = "label12";
            label12.Size = new Size(56, 17);
            label12.TabIndex = 17;
            label12.Text = "地图类型";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1199, 746);
            Controls.Add(label12);
            Controls.Add(cmbMapType);
            Controls.Add(groupBox1);
            Controls.Add(chkGrid);
            Controls.Add(tbLng);
            Controls.Add(tbZoom);
            Controls.Add(tbLat);
            Controls.Add(pn);
            Controls.Add(gb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AMapDownloader";
            WindowState = FormWindowState.Maximized;
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentL).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlExtentU).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlColMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlColMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlRowMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrawlRowMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn;
        private TextBox tbZoom;
        private Button btnCrawl;
        private CheckBox chkGrid;
        private Button btnDraw;
        private Button btnClear;
        private TextBox tbLng;
        private TextBox tbLat;
        private TextBox tbCrawlOutput;
        private Button btnCrawlOutput;
        private GroupBox gb;
        private Label label2;
        private NumericUpDown nudZoom;
        private Button btnCombine;
        private Label lbCrawl;
        private Label lbCombine;
        private TextBox tbCombineInput;
        private Button btnCombineInput;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox tbCombineOutput;
        private Button btnCombineOutput;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox tbTileCount;
        private Label label11;
        private NumericUpDown nudCrawlColMax;
        private NumericUpDown nudCrawlColMin;
        private NumericUpDown nudCrawlRowMax;
        private NumericUpDown nudCrawlRowMin;
        private NumericUpDown nudCrawlExtentD;
        private NumericUpDown nudCrawlExtentU;
        private NumericUpDown nudCrawlExtentR;
        private NumericUpDown nudCrawlExtentL;
        private ComboBox cmbMapType;
        private Label label12;
    }
}
