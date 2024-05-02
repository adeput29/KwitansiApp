
namespace KwitansiApp
{
    partial class f_db
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcon = new System.Windows.Forms.Label();
            this.t_server = new System.Windows.Forms.TextBox();
            this.t_dbsql = new System.Windows.Forms.TextBox();
            this.b_App = new System.Windows.Forms.Button();
            this.b_Test = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB";
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Location = new System.Drawing.Point(28, 145);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(32, 13);
            this.labelcon.TabIndex = 2;
            this.labelcon.Text = "Conn";
            // 
            // t_server
            // 
            this.t_server.Location = new System.Drawing.Point(81, 20);
            this.t_server.Name = "t_server";
            this.t_server.Size = new System.Drawing.Size(146, 20);
            this.t_server.TabIndex = 3;
            // 
            // t_dbsql
            // 
            this.t_dbsql.Location = new System.Drawing.Point(81, 52);
            this.t_dbsql.Name = "t_dbsql";
            this.t_dbsql.Size = new System.Drawing.Size(146, 20);
            this.t_dbsql.TabIndex = 4;
            // 
            // b_App
            // 
            this.b_App.Location = new System.Drawing.Point(88, 107);
            this.b_App.Name = "b_App";
            this.b_App.Size = new System.Drawing.Size(138, 23);
            this.b_App.TabIndex = 25;
            this.b_App.Text = "Run App";
            this.b_App.UseVisualStyleBackColor = true;
            this.b_App.Click += new System.EventHandler(this.b_App_Click);
            // 
            // b_Test
            // 
            this.b_Test.Location = new System.Drawing.Point(156, 78);
            this.b_Test.Name = "b_Test";
            this.b_Test.Size = new System.Drawing.Size(71, 23);
            this.b_Test.TabIndex = 24;
            this.b_Test.Text = "Test Conn";
            this.b_Test.UseVisualStyleBackColor = true;
            this.b_Test.Click += new System.EventHandler(this.b_Test_Click);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(88, 78);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(62, 23);
            this.b_Save.TabIndex = 23;
            this.b_Save.Text = "Save";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // f_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 179);
            this.Controls.Add(this.b_App);
            this.Controls.Add(this.b_Test);
            this.Controls.Add(this.b_Save);
            this.Controls.Add(this.t_dbsql);
            this.Controls.Add(this.t_server);
            this.Controls.Add(this.labelcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_db";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcon;
        private System.Windows.Forms.TextBox t_server;
        private System.Windows.Forms.TextBox t_dbsql;
        private System.Windows.Forms.Button b_App;
        private System.Windows.Forms.Button b_Test;
        private System.Windows.Forms.Button b_Save;
    }
}