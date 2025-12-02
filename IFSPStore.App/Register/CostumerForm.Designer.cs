namespace IFSPStore.App.Register
{
    partial class CostumerForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDocument = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCity = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDistrict = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 438);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtDistrict);
            tabPageRegister.Controls.Add(txtCity);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtDocument);
            tabPageRegister.Controls.Add(txtAddress);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(786, 403);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtAddress, 0);
            tabPageRegister.Controls.SetChildIndex(txtDocument, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtCity, 0);
            tabPageRegister.Controls.SetChildIndex(txtDistrict, 0);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(22, 18);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(612, 48);
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.AutoCompleteMode = AutoCompleteMode.None;
            txtAddress.AutoCompleteSource = AutoCompleteSource.None;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(22, 72);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.ReadOnly = false;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(752, 48);
            txtAddress.TabIndex = 4;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtDocument
            // 
            txtDocument.AnimateReadOnly = false;
            txtDocument.AutoCompleteMode = AutoCompleteMode.None;
            txtDocument.AutoCompleteSource = AutoCompleteSource.None;
            txtDocument.BackgroundImageLayout = ImageLayout.None;
            txtDocument.CharacterCasing = CharacterCasing.Normal;
            txtDocument.Depth = 0;
            txtDocument.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocument.HideSelection = true;
            txtDocument.Hint = "Document";
            txtDocument.LeadingIcon = null;
            txtDocument.Location = new Point(22, 126);
            txtDocument.MaxLength = 32767;
            txtDocument.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocument.Name = "txtDocument";
            txtDocument.PasswordChar = '\0';
            txtDocument.PrefixSuffixText = null;
            txtDocument.ReadOnly = false;
            txtDocument.RightToLeft = RightToLeft.No;
            txtDocument.SelectedText = "";
            txtDocument.SelectionLength = 0;
            txtDocument.SelectionStart = 0;
            txtDocument.ShortcutsEnabled = true;
            txtDocument.Size = new Size(752, 48);
            txtDocument.TabIndex = 5;
            txtDocument.TabStop = false;
            txtDocument.TextAlign = HorizontalAlignment.Left;
            txtDocument.TrailingIcon = null;
            txtDocument.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(658, 18);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(116, 48);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCity
            // 
            txtCity.AutoResize = false;
            txtCity.BackColor = Color.FromArgb(255, 255, 255);
            txtCity.Depth = 0;
            txtCity.DrawMode = DrawMode.OwnerDrawVariable;
            txtCity.DropDownHeight = 174;
            txtCity.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCity.DropDownWidth = 121;
            txtCity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCity.FormattingEnabled = true;
            txtCity.Hint = "City";
            txtCity.IntegralHeight = false;
            txtCity.ItemHeight = 43;
            txtCity.Location = new Point(22, 260);
            txtCity.MaxDropDownItems = 4;
            txtCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(752, 49);
            txtCity.StartIndex = 0;
            txtCity.TabIndex = 7;
            // 
            // txtDistrict
            // 
            txtDistrict.AnimateReadOnly = false;
            txtDistrict.AutoCompleteMode = AutoCompleteMode.None;
            txtDistrict.AutoCompleteSource = AutoCompleteSource.None;
            txtDistrict.BackgroundImageLayout = ImageLayout.None;
            txtDistrict.CharacterCasing = CharacterCasing.Normal;
            txtDistrict.Depth = 0;
            txtDistrict.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDistrict.HideSelection = true;
            txtDistrict.Hint = "District";
            txtDistrict.LeadingIcon = null;
            txtDistrict.Location = new Point(22, 180);
            txtDistrict.MaxLength = 32767;
            txtDistrict.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDistrict.Name = "txtDistrict";
            txtDistrict.PasswordChar = '\0';
            txtDistrict.PrefixSuffixText = null;
            txtDistrict.ReadOnly = false;
            txtDistrict.RightToLeft = RightToLeft.No;
            txtDistrict.SelectedText = "";
            txtDistrict.SelectionLength = 0;
            txtDistrict.SelectionStart = 0;
            txtDistrict.ShortcutsEnabled = true;
            txtDistrict.Size = new Size(752, 48);
            txtDistrict.TabIndex = 8;
            txtDistrict.TabStop = false;
            txtDistrict.TextAlign = HorizontalAlignment.Left;
            txtDistrict.TrailingIcon = null;
            txtDistrict.UseSystemPasswordChar = false;
            // 
            // CostumerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Location = new Point(0, 0);
            Name = "CostumerForm";
            Text = "CostumerForm";
            Load += CostumerForm_Load;
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAddress;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDocument;
        private ReaLTaiizor.Controls.MaterialComboBox txtCity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDistrict;
    }
}