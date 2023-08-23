
namespace University
{
    partial class FormInstructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstructors));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnDELETE = new DevExpress.XtraEditors.SimpleButton();
            this.btnUPDATE = new DevExpress.XtraEditors.SimpleButton();
            this.btnERASE = new DevExpress.XtraEditors.SimpleButton();
            this.btnSAVE = new DevExpress.XtraEditors.SimpleButton();
            this.textMAIL = new DevExpress.XtraEditors.TextEdit();
            this.textSURNAME = new DevExpress.XtraEditors.TextEdit();
            this.textNAME = new DevExpress.XtraEditors.TextEdit();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSURNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1001, 444);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(354, 515);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnDELETE);
            this.xtraTabPage1.Controls.Add(this.btnUPDATE);
            this.xtraTabPage1.Controls.Add(this.btnERASE);
            this.xtraTabPage1.Controls.Add(this.btnSAVE);
            this.xtraTabPage1.Controls.Add(this.textMAIL);
            this.xtraTabPage1.Controls.Add(this.textSURNAME);
            this.xtraTabPage1.Controls.Add(this.textNAME);
            this.xtraTabPage1.Controls.Add(this.textID);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(354, 515);
            this.xtraTabPage1.Text = "InstructorInfo";
            // 
            // btnDELETE
            // 
            this.btnDELETE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDELETE.ImageOptions.Image")));
            this.btnDELETE.Location = new System.Drawing.Point(135, 330);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(100, 41);
            this.btnDELETE.TabIndex = 24;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUPDATE.ImageOptions.Image")));
            this.btnUPDATE.Location = new System.Drawing.Point(135, 283);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(100, 41);
            this.btnUPDATE.TabIndex = 23;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnERASE
            // 
            this.btnERASE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnERASE.ImageOptions.Image")));
            this.btnERASE.Location = new System.Drawing.Point(135, 236);
            this.btnERASE.Name = "btnERASE";
            this.btnERASE.Size = new System.Drawing.Size(100, 41);
            this.btnERASE.TabIndex = 22;
            this.btnERASE.Text = "ERASE";
            this.btnERASE.Click += new System.EventHandler(this.btnERASE_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSAVE.ImageOptions.Image")));
            this.btnSAVE.Location = new System.Drawing.Point(135, 189);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(100, 41);
            this.btnSAVE.TabIndex = 21;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // textMAIL
            // 
            this.textMAIL.Location = new System.Drawing.Point(135, 144);
            this.textMAIL.Name = "textMAIL";
            this.textMAIL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMAIL.Properties.Appearance.Options.UseFont = true;
            this.textMAIL.Size = new System.Drawing.Size(100, 24);
            this.textMAIL.TabIndex = 20;
            // 
            // textSURNAME
            // 
            this.textSURNAME.Location = new System.Drawing.Point(135, 103);
            this.textSURNAME.Name = "textSURNAME";
            this.textSURNAME.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSURNAME.Properties.Appearance.Options.UseFont = true;
            this.textSURNAME.Size = new System.Drawing.Size(100, 24);
            this.textSURNAME.TabIndex = 19;
            // 
            // textNAME
            // 
            this.textNAME.Location = new System.Drawing.Point(135, 62);
            this.textNAME.Name = "textNAME";
            this.textNAME.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textNAME.Properties.Appearance.Options.UseFont = true;
            this.textNAME.Size = new System.Drawing.Size(100, 24);
            this.textNAME.TabIndex = 18;
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(135, 15);
            this.textID.Name = "textID";
            this.textID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textID.Properties.Appearance.Options.UseFont = true;
            this.textID.Size = new System.Drawing.Size(100, 24);
            this.textID.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(76, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 18);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "MAIL:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(71, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "NAME:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 18);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "SURNAME:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "ID:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1007, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(356, 559);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // FormInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 511);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormInstructors";
            this.Text = "FormInstructors";
            this.Load += new System.EventHandler(this.FormInstructors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMAIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSURNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnDELETE;
        private DevExpress.XtraEditors.SimpleButton btnUPDATE;
        private DevExpress.XtraEditors.SimpleButton btnERASE;
        private DevExpress.XtraEditors.SimpleButton btnSAVE;
        private DevExpress.XtraEditors.TextEdit textMAIL;
        private DevExpress.XtraEditors.TextEdit textSURNAME;
        private DevExpress.XtraEditors.TextEdit textNAME;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}