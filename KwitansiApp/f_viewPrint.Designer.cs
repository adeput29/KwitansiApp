
namespace KwitansiApp
{
    partial class f_viewPrint
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
            this.cr_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.printKwitansi1 = new KwitansiApp.printKwitansi();
            this.SuspendLayout();
            // 
            // cr_viewer
            // 
            this.cr_viewer.ActiveViewIndex = 0;
            this.cr_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_viewer.Location = new System.Drawing.Point(0, 0);
            this.cr_viewer.Name = "cr_viewer";
            this.cr_viewer.ReportSource = this.printKwitansi1;
            this.cr_viewer.Size = new System.Drawing.Size(800, 450);
            this.cr_viewer.TabIndex = 0;
            // 
            // f_viewPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cr_viewer);
            this.Name = "f_viewPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f_viewPrint";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.f_viewPrint_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_viewer;
        private printKwitansi printKwitansi1;
    }
}