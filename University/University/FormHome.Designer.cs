
namespace University
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHOME = new DevExpress.XtraBars.BarButtonItem();
            this.btnINSTRUCTOR = new DevExpress.XtraBars.BarButtonItem();
            this.btnSTUDENTS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnHOME,
            this.btnINSTRUCTOR,
            this.btnSTUDENTS,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1364, 150);
            // 
            // btnHOME
            // 
            this.btnHOME.Caption = "HOME";
            this.btnHOME.Id = 1;
            this.btnHOME.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHOME.ImageOptions.Image")));
            this.btnHOME.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHOME.ImageOptions.LargeImage")));
            this.btnHOME.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHOME.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHOME.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHOME.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnHOME.Name = "btnHOME";
            // 
            // btnINSTRUCTOR
            // 
            this.btnINSTRUCTOR.Caption = "INSTRUCTORS";
            this.btnINSTRUCTOR.Id = 2;
            this.btnINSTRUCTOR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnINSTRUCTOR.ImageOptions.Image")));
            this.btnINSTRUCTOR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnINSTRUCTOR.ImageOptions.LargeImage")));
            this.btnINSTRUCTOR.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnINSTRUCTOR.ItemAppearance.Normal.Options.UseFont = true;
            this.btnINSTRUCTOR.Name = "btnINSTRUCTOR";
            this.btnINSTRUCTOR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnINSTRUCTOR_ItemClick);
            // 
            // btnSTUDENTS
            // 
            this.btnSTUDENTS.Caption = "STUDENTS";
            this.btnSTUDENTS.Id = 3;
            this.btnSTUDENTS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSTUDENTS.ImageOptions.Image")));
            this.btnSTUDENTS.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSTUDENTS.ImageOptions.LargeImage")));
            this.btnSTUDENTS.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSTUDENTS.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSTUDENTS.Name = "btnSTUDENTS";
            this.btnSTUDENTS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSTUDENTS_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ADVISOR";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "UNIVERSITY SYSTEM MANAGEMENT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHOME);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnINSTRUCTOR);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSTUDENTS);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 626);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormHome";
            this.Text = "EUL";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnHOME;
        private DevExpress.XtraBars.BarButtonItem btnINSTRUCTOR;
        private DevExpress.XtraBars.BarButtonItem btnSTUDENTS;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

