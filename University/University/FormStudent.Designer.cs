
namespace University
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnDELETE2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUPDATE2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnERASE2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSAVE2 = new DevExpress.XtraEditors.SimpleButton();
            this.textMAIL2 = new DevExpress.XtraEditors.TextEdit();
            this.textSURNAME2 = new DevExpress.XtraEditors.TextEdit();
            this.textNAME2 = new DevExpress.XtraEditors.TextEdit();
            this.textID2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSURNAME2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1027, 513);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1034, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(333, 513);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnDELETE2);
            this.xtraTabPage1.Controls.Add(this.btnUPDATE2);
            this.xtraTabPage1.Controls.Add(this.btnERASE2);
            this.xtraTabPage1.Controls.Add(this.btnSAVE2);
            this.xtraTabPage1.Controls.Add(this.textMAIL2);
            this.xtraTabPage1.Controls.Add(this.textSURNAME2);
            this.xtraTabPage1.Controls.Add(this.textNAME2);
            this.xtraTabPage1.Controls.Add(this.textID2);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(331, 488);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // btnDELETE2
            // 
            this.btnDELETE2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDELETE2.ImageOptions.Image")));
            this.btnDELETE2.Location = new System.Drawing.Point(132, 344);
            this.btnDELETE2.Name = "btnDELETE2";
            this.btnDELETE2.Size = new System.Drawing.Size(100, 41);
            this.btnDELETE2.TabIndex = 36;
            this.btnDELETE2.Text = "DELETE";
            this.btnDELETE2.Click += new System.EventHandler(this.btnDELETE2_Click);
            // 
            // btnUPDATE2
            // 
            this.btnUPDATE2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUPDATE2.ImageOptions.Image")));
            this.btnUPDATE2.Location = new System.Drawing.Point(132, 297);
            this.btnUPDATE2.Name = "btnUPDATE2";
            this.btnUPDATE2.Size = new System.Drawing.Size(100, 41);
            this.btnUPDATE2.TabIndex = 35;
            this.btnUPDATE2.Text = "UPDATE";
            this.btnUPDATE2.Click += new System.EventHandler(this.btnUPDATE2_Click);
            // 
            // btnERASE2
            // 
            this.btnERASE2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnERASE2.ImageOptions.Image")));
            this.btnERASE2.Location = new System.Drawing.Point(132, 250);
            this.btnERASE2.Name = "btnERASE2";
            this.btnERASE2.Size = new System.Drawing.Size(100, 41);
            this.btnERASE2.TabIndex = 34;
            this.btnERASE2.Text = "ERASE";
            this.btnERASE2.Click += new System.EventHandler(this.btnERASE2_Click);
            // 
            // btnSAVE2
            // 
            this.btnSAVE2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSAVE2.ImageOptions.Image")));
            this.btnSAVE2.Location = new System.Drawing.Point(132, 203);
            this.btnSAVE2.Name = "btnSAVE2";
            this.btnSAVE2.Size = new System.Drawing.Size(100, 41);
            this.btnSAVE2.TabIndex = 33;
            this.btnSAVE2.Text = "SAVE";
            this.btnSAVE2.Click += new System.EventHandler(this.btnSAVE2_Click);
            // 
            // textMAIL2
            // 
            this.textMAIL2.Location = new System.Drawing.Point(132, 158);
            this.textMAIL2.Name = "textMAIL2";
            this.textMAIL2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMAIL2.Properties.Appearance.Options.UseFont = true;
            this.textMAIL2.Size = new System.Drawing.Size(100, 24);
            this.textMAIL2.TabIndex = 32;
            // 
            // textSURNAME2
            // 
            this.textSURNAME2.Location = new System.Drawing.Point(132, 117);
            this.textSURNAME2.Name = "textSURNAME2";
            this.textSURNAME2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSURNAME2.Properties.Appearance.Options.UseFont = true;
            this.textSURNAME2.Size = new System.Drawing.Size(100, 24);
            this.textSURNAME2.TabIndex = 31;
            // 
            // textNAME2
            // 
            this.textNAME2.Location = new System.Drawing.Point(132, 76);
            this.textNAME2.Name = "textNAME2";
            this.textNAME2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNAME2.Properties.Appearance.Options.UseFont = true;
            this.textNAME2.Size = new System.Drawing.Size(100, 24);
            this.textNAME2.TabIndex = 30;
            // 
            // textID2
            // 
            this.textID2.Enabled = false;
            this.textID2.Location = new System.Drawing.Point(132, 29);
            this.textID2.Name = "textID2";
            this.textID2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textID2.Properties.Appearance.Options.UseFont = true;
            this.textID2.Size = new System.Drawing.Size(100, 24);
            this.textID2.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 18);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "DEPARTMENT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 18);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "NAME:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 18);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "SURNAME:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(91, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "ID:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(331, 488);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 511);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSURNAME2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnDELETE2;
        private DevExpress.XtraEditors.SimpleButton btnUPDATE2;
        private DevExpress.XtraEditors.SimpleButton btnERASE2;
        private DevExpress.XtraEditors.SimpleButton btnSAVE2;
        private DevExpress.XtraEditors.TextEdit textMAIL2;
        private DevExpress.XtraEditors.TextEdit textSURNAME2;
        private DevExpress.XtraEditors.TextEdit textNAME2;
        private DevExpress.XtraEditors.TextEdit textID2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}