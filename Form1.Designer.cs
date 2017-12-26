namespace _2048
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ArgbTextBox = new System.Windows.Forms.TextBox();
            this.RGBTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorDisplay = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel3.Controls.Add(this.ArgbTextBox);
            this.panel3.Controls.Add(this.RGBTextBox);
            this.panel3.Controls.Add(this.PositionTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(201, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 190);
            this.panel3.TabIndex = 1;
            // 
            // ArgbTextBox
            // 
            this.ArgbTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ArgbTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArgbTextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ArgbTextBox.Location = new System.Drawing.Point(159, 134);
            this.ArgbTextBox.Name = "ArgbTextBox";
            this.ArgbTextBox.Size = new System.Drawing.Size(308, 43);
            this.ArgbTextBox.TabIndex = 0;
            // 
            // RGBTextBox
            // 
            this.RGBTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.RGBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RGBTextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RGBTextBox.Location = new System.Drawing.Point(159, 76);
            this.RGBTextBox.Name = "RGBTextBox";
            this.RGBTextBox.Size = new System.Drawing.Size(308, 43);
            this.RGBTextBox.TabIndex = 0;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionTextBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PositionTextBox.Location = new System.Drawing.Point(159, 18);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(308, 43);
            this.PositionTextBox.TabIndex = 0;
            this.PositionTextBox.Text = "@Zorn.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "A R  G B:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "R   G   B:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Position:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ColorDisplay.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ColorDisplay.Location = new System.Drawing.Point(8, 5);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(190, 190);
            this.ColorDisplay.TabIndex = 0;
            this.ColorDisplay.Text = "Press Ctrl to start,\r\nPress Esc to pick.";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(690, 200);
            this.Controls.Add(this.ColorDisplay);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArgbTextBox;
        private System.Windows.Forms.TextBox RGBTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ColorDisplay;
        private System.Windows.Forms.Timer timer2;
    }
}

