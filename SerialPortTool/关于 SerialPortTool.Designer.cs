
namespace SerialPortTool
{
    partial class 关于SerialPortTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(关于SerialPortTool));
            this.Tool = new System.Windows.Forms.Label();
            this.版本 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tool
            // 
            this.Tool.AutoSize = true;
            this.Tool.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tool.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Tool.Location = new System.Drawing.Point(12, 9);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(251, 41);
            this.Tool.TabIndex = 0;
            this.Tool.Text = "Serial Port Tool";
            // 
            // 版本
            // 
            this.版本.AutoSize = true;
            this.版本.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.版本.ForeColor = System.Drawing.Color.DarkMagenta;
            this.版本.Location = new System.Drawing.Point(15, 65);
            this.版本.Name = "版本";
            this.版本.Size = new System.Drawing.Size(80, 21);
            this.版本.TabIndex = 1;
            this.版本.Text = "版本：1.0";
            // 
            // 关于SerialPortTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 242);
            this.Controls.Add(this.版本);
            this.Controls.Add(this.Tool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "关于SerialPortTool";
            this.Text = "关于 SerialPortTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tool;
        private System.Windows.Forms.Label 版本;
    }
}