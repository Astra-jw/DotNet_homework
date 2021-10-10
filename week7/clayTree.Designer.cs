
namespace ClayTree
{
    partial class clayTree
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
            this.draw_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rltextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lltextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ratextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.latextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccomboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw_button
            // 
            this.draw_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.draw_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.draw_button.Location = new System.Drawing.Point(720, 12);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(82, 37);
            this.draw_button.TabIndex = 0;
            this.draw_button.Text = "draw";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.dtextBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.mtextBox);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.rltextBox);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.lltextBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.ratextBox);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.latextBox);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.ccomboBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 528);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 75);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度:";
            // 
            // dtextBox
            // 
            this.dtextBox.Location = new System.Drawing.Point(82, 3);
            this.dtextBox.Name = "dtextBox";
            this.dtextBox.Size = new System.Drawing.Size(83, 27);
            this.dtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度:";
            // 
            // mtextBox
            // 
            this.mtextBox.Location = new System.Drawing.Point(250, 3);
            this.mtextBox.Name = "mtextBox";
            this.mtextBox.Size = new System.Drawing.Size(90, 27);
            this.mtextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "右分支长度比:";
            // 
            // rltextBox
            // 
            this.rltextBox.Location = new System.Drawing.Point(455, 3);
            this.rltextBox.Name = "rltextBox";
            this.rltextBox.Size = new System.Drawing.Size(90, 27);
            this.rltextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "左分支长度比:";
            // 
            // lltextBox
            // 
            this.lltextBox.Location = new System.Drawing.Point(660, 3);
            this.lltextBox.Name = "lltextBox";
            this.lltextBox.Size = new System.Drawing.Size(100, 27);
            this.lltextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "右分支角度:";
            // 
            // ratextBox
            // 
            this.ratextBox.Location = new System.Drawing.Point(97, 36);
            this.ratextBox.Name = "ratextBox";
            this.ratextBox.Size = new System.Drawing.Size(125, 27);
            this.ratextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "左分支角度:";
            // 
            // latextBox
            // 
            this.latextBox.Location = new System.Drawing.Point(322, 36);
            this.latextBox.Name = "latextBox";
            this.latextBox.Size = new System.Drawing.Size(125, 27);
            this.latextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "颜色:";
            // 
            // ccomboBox
            // 
            this.ccomboBox.FormattingEnabled = true;
            this.ccomboBox.Items.AddRange(new object[] {
            "red",
            "yellow",
            "blue",
            "green"});
            this.ccomboBox.Location = new System.Drawing.Point(502, 36);
            this.ccomboBox.Name = "ccomboBox";
            this.ccomboBox.Size = new System.Drawing.Size(151, 28);
            this.ccomboBox.TabIndex = 13;
            // 
            // clayTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 603);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.draw_button);
            this.Name = "clayTree";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.clayTree_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rltextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lltextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ratextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox latextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ccomboBox;
    }
}

