
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
            tbTileCount = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tbCrawlColMax = new TextBox();
            label8 = new Label();
            tbCrawlColMin = new TextBox();
            tbCrawlRowMax = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbCrawlExtentR = new TextBox();
            tbCrawlExtentL = new TextBox();
            tbCrawlExtentD = new TextBox();
            lbCrawl = new Label();
            tbCrawlRowMin = new TextBox();
            label2 = new Label();
            nudZoom = new NumericUpDown();
            tbCrawlExtentU = new TextBox();
            btnCombineInput = new Button();
            tbCombineInput = new TextBox();
            lbCombine = new Label();
            btnCombine = new Button();
            groupBox1 = new GroupBox();
            btnCombineOutput = new Button();
            tbCombineOutput = new TextBox();
            label3 = new Label();
            label1 = new Label();
            gb.SuspendLayout();
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
            chkGrid.Location = new Point(862, 11);
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
            tbLng.Location = new Point(896, 38);
            tbLng.Name = "tbLng";
            tbLng.ReadOnly = true;
            tbLng.Size = new Size(143, 23);
            tbLng.TabIndex = 7;
            // 
            // tbZoom
            // 
            tbZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbZoom.Location = new Point(862, 38);
            tbZoom.Name = "tbZoom";
            tbZoom.ReadOnly = true;
            tbZoom.Size = new Size(28, 23);
            tbZoom.TabIndex = 1;
            // 
            // tbLat
            // 
            tbLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLat.Location = new Point(1044, 38);
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
            gb.Controls.Add(tbTileCount);
            gb.Controls.Add(label11);
            gb.Controls.Add(label10);
            gb.Controls.Add(label9);
            gb.Controls.Add(tbCrawlColMax);
            gb.Controls.Add(label8);
            gb.Controls.Add(tbCrawlColMin);
            gb.Controls.Add(tbCrawlRowMax);
            gb.Controls.Add(label7);
            gb.Controls.Add(label6);
            gb.Controls.Add(label5);
            gb.Controls.Add(label4);
            gb.Controls.Add(tbCrawlExtentR);
            gb.Controls.Add(tbCrawlExtentL);
            gb.Controls.Add(tbCrawlExtentD);
            gb.Controls.Add(lbCrawl);
            gb.Controls.Add(tbCrawlRowMin);
            gb.Controls.Add(label2);
            gb.Controls.Add(nudZoom);
            gb.Controls.Add(tbCrawlExtentU);
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
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(65, 245);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 28;
            label9.Text = "列(Col)";
            // 
            // tbCrawlColMax
            // 
            tbCrawlColMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlColMax.Location = new Point(196, 242);
            tbCrawlColMax.Multiline = true;
            tbCrawlColMax.Name = "tbCrawlColMax";
            tbCrawlColMax.ReadOnly = true;
            tbCrawlColMax.Size = new Size(50, 22);
            tbCrawlColMax.TabIndex = 27;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(177, 245);
            label8.Name = "label8";
            label8.Size = new Size(17, 17);
            label8.TabIndex = 26;
            label8.Text = "~";
            // 
            // tbCrawlColMin
            // 
            tbCrawlColMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlColMin.Location = new Point(127, 242);
            tbCrawlColMin.Multiline = true;
            tbCrawlColMin.Name = "tbCrawlColMin";
            tbCrawlColMin.ReadOnly = true;
            tbCrawlColMin.Size = new Size(50, 22);
            tbCrawlColMin.TabIndex = 25;
            // 
            // tbCrawlRowMax
            // 
            tbCrawlRowMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlRowMax.Location = new Point(196, 214);
            tbCrawlRowMax.Multiline = true;
            tbCrawlRowMax.Name = "tbCrawlRowMax";
            tbCrawlRowMax.ReadOnly = true;
            tbCrawlRowMax.Size = new Size(50, 22);
            tbCrawlRowMax.TabIndex = 24;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(177, 217);
            label7.Name = "label7";
            label7.Size = new Size(17, 17);
            label7.TabIndex = 23;
            label7.Text = "~";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            label5.Text = "爬取范围";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 20;
            label4.Text = "框选范围";
            // 
            // tbCrawlExtentR
            // 
            tbCrawlExtentR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlExtentR.Location = new Point(232, 96);
            tbCrawlExtentR.Multiline = true;
            tbCrawlExtentR.Name = "tbCrawlExtentR";
            tbCrawlExtentR.ReadOnly = true;
            tbCrawlExtentR.Size = new Size(87, 22);
            tbCrawlExtentR.TabIndex = 19;
            // 
            // tbCrawlExtentL
            // 
            tbCrawlExtentL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlExtentL.Location = new Point(68, 96);
            tbCrawlExtentL.Multiline = true;
            tbCrawlExtentL.Name = "tbCrawlExtentL";
            tbCrawlExtentL.ReadOnly = true;
            tbCrawlExtentL.Size = new Size(87, 22);
            tbCrawlExtentL.TabIndex = 18;
            // 
            // tbCrawlExtentD
            // 
            tbCrawlExtentD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlExtentD.Location = new Point(146, 124);
            tbCrawlExtentD.Multiline = true;
            tbCrawlExtentD.Name = "tbCrawlExtentD";
            tbCrawlExtentD.ReadOnly = true;
            tbCrawlExtentD.Size = new Size(103, 22);
            tbCrawlExtentD.TabIndex = 17;
            // 
            // lbCrawl
            // 
            lbCrawl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbCrawl.AutoSize = true;
            lbCrawl.Location = new Point(146, 304);
            lbCrawl.Name = "lbCrawl";
            lbCrawl.Size = new Size(0, 17);
            lbCrawl.TabIndex = 16;
            // 
            // tbCrawlRowMin
            // 
            tbCrawlRowMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlRowMin.Location = new Point(127, 214);
            tbCrawlRowMin.Multiline = true;
            tbCrawlRowMin.Name = "tbCrawlRowMin";
            tbCrawlRowMin.ReadOnly = true;
            tbCrawlRowMin.Size = new Size(50, 22);
            tbCrawlRowMin.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 179);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 13;
            label2.Text = "爬取级别";
            // 
            // nudZoom
            // 
            nudZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudZoom.Location = new Point(68, 177);
            nudZoom.Name = "nudZoom";
            nudZoom.Size = new Size(44, 23);
            nudZoom.TabIndex = 12;
            nudZoom.ValueChanged += nudZoom_ValueChanged;
            // 
            // tbCrawlExtentU
            // 
            tbCrawlExtentU.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCrawlExtentU.Location = new Point(146, 64);
            tbCrawlExtentU.Multiline = true;
            tbCrawlExtentU.Name = "tbCrawlExtentU";
            tbCrawlExtentU.ReadOnly = true;
            tbCrawlExtentU.Size = new Size(103, 22);
            tbCrawlExtentU.TabIndex = 11;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1199, 746);
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
            Text = "HMapLoader_GMap";
            WindowState = FormWindowState.Maximized;
            gb.ResumeLayout(false);
            gb.PerformLayout();
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
        private TextBox tbCrawlExtentU;
        private Label label2;
        private NumericUpDown nudZoom;
        private TextBox tbCrawlRowMin;
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
        private TextBox tbCrawlExtentR;
        private TextBox tbCrawlExtentL;
        private TextBox tbCrawlExtentD;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox tbCrawlColMax;
        private Label label8;
        private TextBox tbCrawlColMin;
        private TextBox tbCrawlRowMax;
        private Label label10;
        private TextBox tbTileCount;
        private Label label11;
    }
}
