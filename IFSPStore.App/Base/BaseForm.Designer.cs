namespace IFSPStore.App.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            imageList1 = new ImageList(components);
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRegister = new TabPage();
            panel1 = new Panel();
            ButtonSave = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancel = new ReaLTaiizor.Controls.MaterialButton();
            tabPageList = new TabPage();
            panel2 = new Panel();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            buttonEdit = new ReaLTaiizor.Controls.MaterialButton();
            buttonNew = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewList = new DataGridView();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel1.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            imageList1.Images.SetKeyName(2, "");
            imageList1.Images.SetKeyName(3, "");
            imageList1.Images.SetKeyName(4, "");
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Depth = 0;
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.ImageList = imageList1;
            tabControlRegister.Location = new Point(3, 64);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(792, 397);
            tabControlRegister.TabIndex = 0;
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(panel1);
            tabPageRegister.ImageIndex = 1;
            tabPageRegister.Location = new Point(4, 31);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(784, 362);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Register";
            tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonSave);
            panel1.Controls.Add(ButtonCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 65);
            panel1.TabIndex = 2;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSave.Depth = 0;
            ButtonSave.HighEmphasis = true;
            ButtonSave.Icon = null;
            ButtonSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSave.Location = new Point(620, 17);
            ButtonSave.Margin = new Padding(4, 6, 4, 6);
            ButtonSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSave.Name = "ButtonSave";
            ButtonSave.NoAccentTextColor = Color.Empty;
            ButtonSave.Size = new Size(64, 36);
            ButtonSave.TabIndex = 0;
            ButtonSave.Text = "Save";
            ButtonSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSave.UseAccentColor = false;
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += btnSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancel.Depth = 0;
            ButtonCancel.HighEmphasis = true;
            ButtonCancel.Icon = null;
            ButtonCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancel.Location = new Point(692, 17);
            ButtonCancel.Margin = new Padding(4, 6, 4, 6);
            ButtonCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.NoAccentTextColor = Color.Empty;
            ButtonCancel.Size = new Size(77, 36);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancel.UseAccentColor = false;
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += btnCancel_Click;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(panel2);
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.ImageIndex = 0;
            tabPageList.Location = new Point(4, 31);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(784, 362);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "List";
            tabPageList.UseVisualStyleBackColor = true;
            tabPageList.Enter += tabPageList_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 79);
            panel2.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(696, 30);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonEdit.Depth = 0;
            buttonEdit.HighEmphasis = true;
            buttonEdit.Icon = null;
            buttonEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonEdit.Location = new Point(621, 30);
            buttonEdit.Margin = new Padding(4, 6, 4, 6);
            buttonEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonEdit.Name = "buttonEdit";
            buttonEdit.NoAccentTextColor = Color.Empty;
            buttonEdit.Size = new Size(64, 36);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Edit";
            buttonEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonEdit.UseAccentColor = false;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += btnEdit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNew.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonNew.Depth = 0;
            buttonNew.HighEmphasis = true;
            buttonNew.Icon = null;
            buttonNew.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonNew.Location = new Point(546, 30);
            buttonNew.Margin = new Padding(4, 6, 4, 6);
            buttonNew.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonNew.Name = "buttonNew";
            buttonNew.NoAccentTextColor = Color.Empty;
            buttonNew.Size = new Size(64, 36);
            buttonNew.TabIndex = 2;
            buttonNew.Text = "New";
            buttonNew.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonNew.UseAccentColor = false;
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += btnNew_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.AllowUserToAddRows = false;
            dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewList.AllowUserToResizeColumns = false;
            dataGridViewList.AllowUserToResizeRows = false;
            dataGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(6, 6);
            dataGridViewList.MultiSelect = false;
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.ReadOnly = true;
            dataGridViewList.RightToLeft = RightToLeft.No;
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewList.Size = new Size(764, 268);
            dataGridViewList.TabIndex = 3;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 464);
            Controls.Add(tabControlRegister);
            DrawerTabControl = tabControlRegister;
            Name = "BaseForm";
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton ButtonSave;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancel;
        private ReaLTaiizor.Controls.MaterialButton buttonNew;
        private ReaLTaiizor.Controls.MaterialButton buttonEdit;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        protected TabPage tabPageList;
        protected DataGridView dataGridViewList;
        protected TabPage tabPageRegister;
        private Panel panel1;
        private Panel panel2;
    }
}