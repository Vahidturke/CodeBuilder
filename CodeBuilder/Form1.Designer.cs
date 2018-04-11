namespace CodeBuilder
{
    partial class Form1
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
            this.txtSource = new System.Windows.Forms.RichTextBox();
            this.BtnCompile = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrows = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(733, 297);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "namespace CodeBuilder\n{\n   static class Program\n  {     \n    static void Main()\n " +
    "       {\n\tSystem.Console.WriteLine(\"test\");\n\t System.  Console.ReadKey();\n\n     " +
    "  }\n   }\n}";
            // 
            // BtnCompile
            // 
            this.BtnCompile.Location = new System.Drawing.Point(6, 12);
            this.BtnCompile.Name = "BtnCompile";
            this.BtnCompile.Size = new System.Drawing.Size(75, 23);
            this.BtnCompile.TabIndex = 1;
            this.BtnCompile.Text = "Compile";
            this.BtnCompile.UseVisualStyleBackColor = true;
            this.BtnCompile.Click += new System.EventHandler(this.BtnCompile_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtstatus.Location = new System.Drawing.Point(0, 0);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(733, 139);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrows);
            this.panel1.Controls.Add(this.txtSavePath);
            this.panel1.Controls.Add(this.BtnCompile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 44);
            this.panel1.TabIndex = 3;
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(468, 14);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(21, 20);
            this.btnBrows.TabIndex = 8;
            this.btnBrows.Text = "...";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.BtnBrows_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(87, 15);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(375, 20);
            this.txtSavePath.TabIndex = 7;
            this.txtSavePath.Text = "C:\\Users\\Vahid Turke\\Desktop\\server";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtstatus);
            this.splitContainer1.Size = new System.Drawing.Size(733, 440);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 484);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSource;
        private System.Windows.Forms.Button BtnCompile;
        private System.Windows.Forms.RichTextBox txtstatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.TextBox txtSavePath;
    }
}

