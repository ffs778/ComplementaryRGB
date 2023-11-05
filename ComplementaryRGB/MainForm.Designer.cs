
namespace ComplementaryRGB
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.complementary_picb = new System.Windows.Forms.PictureBox();
            this.complementaryRGB_lab = new System.Windows.Forms.Label();
            this.originRGB_lab = new System.Windows.Forms.Label();
            this.origin_picb = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complementary_picb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_picb)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1174, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGB互补色计算与显示";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.complementary_picb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.complementaryRGB_lab, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.originRGB_lab, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.origin_picb, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 667);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // complementary_picb
            // 
            this.complementary_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complementary_picb.Location = new System.Drawing.Point(590, 114);
            this.complementary_picb.Name = "complementary_picb";
            this.complementary_picb.Size = new System.Drawing.Size(581, 550);
            this.complementary_picb.TabIndex = 3;
            this.complementary_picb.TabStop = false;
            // 
            // complementaryRGB_lab
            // 
            this.complementaryRGB_lab.AutoSize = true;
            this.complementaryRGB_lab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complementaryRGB_lab.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.complementaryRGB_lab.Location = new System.Drawing.Point(590, 0);
            this.complementaryRGB_lab.Name = "complementaryRGB_lab";
            this.complementaryRGB_lab.Size = new System.Drawing.Size(581, 111);
            this.complementaryRGB_lab.TabIndex = 1;
            this.complementaryRGB_lab.Text = "0,0,0";
            this.complementaryRGB_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.complementaryRGB_lab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.complementaryRGB_lab_MouseClick);
            // 
            // originRGB_lab
            // 
            this.originRGB_lab.AutoSize = true;
            this.originRGB_lab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originRGB_lab.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originRGB_lab.Location = new System.Drawing.Point(3, 0);
            this.originRGB_lab.Name = "originRGB_lab";
            this.originRGB_lab.Size = new System.Drawing.Size(581, 111);
            this.originRGB_lab.TabIndex = 0;
            this.originRGB_lab.Text = "0,0,0";
            this.originRGB_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.originRGB_lab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.originRGB_lab_MouseClick);
            // 
            // origin_picb
            // 
            this.origin_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.origin_picb.Location = new System.Drawing.Point(3, 114);
            this.origin_picb.Name = "origin_picb";
            this.origin_picb.Size = new System.Drawing.Size(581, 550);
            this.origin_picb.TabIndex = 2;
            this.origin_picb.TabStop = false;
            this.origin_picb.Click += new System.EventHandler(this.origin_picb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 756);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "互补色工具";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complementary_picb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origin_picb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label originRGB_lab;
        private System.Windows.Forms.Label complementaryRGB_lab;
        private System.Windows.Forms.PictureBox origin_picb;
        private System.Windows.Forms.PictureBox complementary_picb;
    }
}

