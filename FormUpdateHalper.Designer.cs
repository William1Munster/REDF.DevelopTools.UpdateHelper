namespace REDF.DevelopTools.UpdateHelper
{
    partial class FormUpdateHalper
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCheckFIles = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDelFileInfo = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSaveFileList = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnReadFileXML = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnCheckOneFile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnUpdateXML = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grcRelease = new DevExpress.XtraEditors.GroupControl();
            this.gControl = new DevExpress.XtraGrid.GridControl();
            this.bsAssemblyInfor = new System.Windows.Forms.BindingSource(this.components);
            this.dsAssemblyInfor = new REDF.DevelopTools.UpdateHelper.Entity.DsAssemblyInfor();
            this.gView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblyMD5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblySize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcRelease)).BeginInit();
            this.grcRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssemblyInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAssemblyInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnCheckFIles,
            this.btnSaveFileList,
            this.btnDelFileInfo,
            this.btnCheckOneFile,
            this.btnReadFileXML,
            this.btnUpdateXML});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheckFIles),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelFileInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveFileList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReadFileXML, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheckOneFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateXML)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCheckFIles
            // 
            this.btnCheckFIles.Caption = "更新列表";
            this.btnCheckFIles.Id = 0;
            this.btnCheckFIles.ImageUri.Uri = "SendBehindText";
            this.btnCheckFIles.Name = "btnCheckFIles";
            this.btnCheckFIles.Tag = "选择要更新的文件目录，生成目录下的所有文件以及文件夹的md5信息";
            this.btnCheckFIles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheckFIles_ItemClick);
            // 
            // btnDelFileInfo
            // 
            this.btnDelFileInfo.Caption = "排除涉及文件";
            this.btnDelFileInfo.Id = 2;
            this.btnDelFileInfo.ImageUri.Uri = "Cancel";
            this.btnDelFileInfo.Name = "btnDelFileInfo";
            this.btnDelFileInfo.Tag = "排除不用更新的文件信息";
            this.btnDelFileInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelFileInfo_ItemClick);
            // 
            // btnSaveFileList
            // 
            this.btnSaveFileList.Caption = "发布列表";
            this.btnSaveFileList.Id = 1;
            this.btnSaveFileList.ImageUri.Uri = "Up";
            this.btnSaveFileList.Name = "btnSaveFileList";
            this.btnSaveFileList.Tag = "将文件信息生成到xml中";
            this.btnSaveFileList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveFileList_ItemClick);
            // 
            // btnReadFileXML
            // 
            this.btnReadFileXML.Caption = "读取更新xml";
            this.btnReadFileXML.Id = 4;
            this.btnReadFileXML.ImageUri.Uri = "Preview";
            this.btnReadFileXML.Name = "btnReadFileXML";
            this.btnReadFileXML.Tag = "读取已经生成的xml";
            this.btnReadFileXML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReadFileXML_ItemClick);
            // 
            // btnCheckOneFile
            // 
            this.btnCheckOneFile.Caption = "更改特定文件";
            this.btnCheckOneFile.Id = 3;
            this.btnCheckOneFile.ImageUri.Uri = "Refresh";
            this.btnCheckOneFile.Name = "btnCheckOneFile";
            this.btnCheckOneFile.Tag = "对于单个文件修改,直接修改xml中对应的信息";
            this.btnCheckOneFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCheckOneFile_ItemClick);
            // 
            // btnUpdateXML
            // 
            this.btnUpdateXML.Caption = "更新发布信息";
            this.btnUpdateXML.Id = 5;
            this.btnUpdateXML.ImageUri.Uri = "Replace";
            this.btnUpdateXML.Name = "btnUpdateXML";
            this.btnUpdateXML.Tag = "保存更改后的文件信息";
            this.btnUpdateXML.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateXML_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(883, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            this.barDockControlBottom.Size = new System.Drawing.Size(883, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 397);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(883, 60);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 397);
            // 
            // grcRelease
            // 
            this.grcRelease.Controls.Add(this.gControl);
            this.grcRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcRelease.Location = new System.Drawing.Point(0, 60);
            this.grcRelease.Name = "grcRelease";
            this.grcRelease.Size = new System.Drawing.Size(883, 397);
            this.grcRelease.TabIndex = 6;
            this.grcRelease.Text = "发布文件";
            // 
            // gControl
            // 
            this.gControl.DataSource = this.bsAssemblyInfor;
            this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl.Location = new System.Drawing.Point(2, 21);
            this.gControl.MainView = this.gView;
            this.gControl.Name = "gControl";
            this.gControl.Size = new System.Drawing.Size(879, 374);
            this.gControl.TabIndex = 3;
            this.gControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView});
            // 
            // bsAssemblyInfor
            // 
            this.bsAssemblyInfor.DataMember = "AssemblyInfor";
            this.bsAssemblyInfor.DataSource = this.dsAssemblyInfor;
            // 
            // dsAssemblyInfor
            // 
            this.dsAssemblyInfor.DataSetName = "DsAssemblyInfor";
            this.dsAssemblyInfor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gView
            // 
            this.gView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssemblyName,
            this.colAssemblyMD5,
            this.colAssemblySize});
            this.gView.GridControl = this.gControl;
            this.gView.Name = "gView";
            this.gView.OptionsBehavior.Editable = false;
            this.gView.OptionsView.ShowGroupPanel = false;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.Caption = "文件名称";
            this.colAssemblyName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Visible = true;
            this.colAssemblyName.VisibleIndex = 0;
            this.colAssemblyName.Width = 482;
            // 
            // colAssemblyMD5
            // 
            this.colAssemblyMD5.Caption = "MD5值";
            this.colAssemblyMD5.FieldName = "AssemblyMD5";
            this.colAssemblyMD5.Name = "colAssemblyMD5";
            this.colAssemblyMD5.Visible = true;
            this.colAssemblyMD5.VisibleIndex = 1;
            this.colAssemblyMD5.Width = 219;
            // 
            // colAssemblySize
            // 
            this.colAssemblySize.Caption = "文件大小";
            this.colAssemblySize.DisplayFormat.FormatString = "{0} kb";
            this.colAssemblySize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAssemblySize.FieldName = "AssemblySize";
            this.colAssemblySize.Name = "colAssemblySize";
            this.colAssemblySize.Visible = true;
            this.colAssemblySize.VisibleIndex = 2;
            this.colAssemblySize.Width = 147;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateHalper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 480);
            this.Controls.Add(this.grcRelease);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormUpdateHalper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateHalper";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcRelease)).EndInit();
            this.grcRelease.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssemblyInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAssemblyInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnCheckFIles;
        private DevExpress.XtraBars.BarLargeButtonItem btnDelFileInfo;
        private DevExpress.XtraBars.BarLargeButtonItem btnSaveFileList;
        private DevExpress.XtraBars.BarLargeButtonItem btnReadFileXML;
        private DevExpress.XtraBars.BarLargeButtonItem btnCheckOneFile;
        private DevExpress.XtraBars.BarLargeButtonItem btnUpdateXML;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grcRelease;
        private DevExpress.XtraGrid.GridControl gControl;
        private System.Windows.Forms.BindingSource bsAssemblyInfor;
        private Entity.DsAssemblyInfor dsAssemblyInfor;
        private DevExpress.XtraGrid.Views.Grid.GridView gView;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyName;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyMD5;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblySize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}