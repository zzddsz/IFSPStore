namespace IFSPStore.App.Register
{
    partial class SaleForm
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1 = new GroupBox();
            lblValue = new ReaLTaiizor.Controls.MaterialLabel();
            lblQuantityItems = new ReaLTaiizor.Controls.MaterialLabel();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            txtTotalValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnitValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            dataGridViewItems = new DataGridView();
            txtCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            txtUser = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDateSale = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(3, 113);
            tabControlRegister.Margin = new Padding(3, 5, 3, 5);
            tabControlRegister.Size = new Size(730, 610);
            // 
            // tabPageList
            // 
            tabPageList.Margin = new Padding(3, 4, 3, 4);
            tabPageList.Padding = new Padding(3, 4, 3, 4);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtDateSale);
            tabPageRegister.Controls.Add(txtUser);
            tabPageRegister.Controls.Add(txtCustomer);
            tabPageRegister.Controls.Add(groupBox1);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Margin = new Padding(3, 5, 3, 5);
            tabPageRegister.Padding = new Padding(3, 5, 3, 5);
            tabPageRegister.Size = new Size(722, 575);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(groupBox1, 0);
            tabPageRegister.Controls.SetChildIndex(txtCustomer, 0);
            tabPageRegister.Controls.SetChildIndex(txtUser, 0);
            tabPageRegister.Controls.SetChildIndex(txtDateSale, 0);
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
            txtId.Location = new Point(576, 8);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(122, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblValue);
            groupBox1.Controls.Add(lblQuantityItems);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtTotalValue);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitValue);
            groupBox1.Controls.Add(txtProduct);
            groupBox1.Controls.Add(dataGridViewItems);
            groupBox1.Location = new Point(7, 155);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(695, 335);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Products";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Depth = 0;
            lblValue.FlatStyle = FlatStyle.Flat;
            lblValue.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValue.Location = new Point(507, 305);
            lblValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(99, 19);
            lblValue.TabIndex = 8;
            lblValue.Text = "Total Value: 0";
            // 
            // lblQuantityItems
            // 
            lblQuantityItems.AutoSize = true;
            lblQuantityItems.Depth = 0;
            lblQuantityItems.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQuantityItems.Location = new Point(6, 301);
            lblQuantityItems.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQuantityItems.Name = "lblQuantityItems";
            lblQuantityItems.Size = new Size(81, 19);
            lblQuantityItems.TabIndex = 7;
            lblQuantityItems.Text = "Products: 0";
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(614, 33);
            btnAdd.Margin = new Padding(5, 8, 5, 8);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTotalValue
            // 
            txtTotalValue.AnimateReadOnly = false;
            txtTotalValue.AutoCompleteMode = AutoCompleteMode.None;
            txtTotalValue.AutoCompleteSource = AutoCompleteSource.None;
            txtTotalValue.BackgroundImageLayout = ImageLayout.None;
            txtTotalValue.CharacterCasing = CharacterCasing.Normal;
            txtTotalValue.Depth = 0;
            txtTotalValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalValue.HideSelection = true;
            txtTotalValue.Hint = "Total Value";
            txtTotalValue.LeadingIcon = null;
            txtTotalValue.Location = new Point(465, 29);
            txtTotalValue.Margin = new Padding(3, 4, 3, 4);
            txtTotalValue.MaxLength = 32767;
            txtTotalValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.PasswordChar = '\0';
            txtTotalValue.PrefixSuffixText = null;
            txtTotalValue.ReadOnly = true;
            txtTotalValue.RightToLeft = RightToLeft.No;
            txtTotalValue.SelectedText = "";
            txtTotalValue.SelectionLength = 0;
            txtTotalValue.SelectionStart = 0;
            txtTotalValue.ShortcutsEnabled = true;
            txtTotalValue.Size = new Size(130, 48);
            txtTotalValue.TabIndex = 3;
            txtTotalValue.TabStop = false;
            txtTotalValue.TextAlign = HorizontalAlignment.Left;
            txtTotalValue.TrailingIcon = null;
            txtTotalValue.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Quantity";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(371, 29);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(87, 48);
            txtQuantity.TabIndex = 2;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // txtUnitValue
            // 
            txtUnitValue.AnimateReadOnly = false;
            txtUnitValue.AutoCompleteMode = AutoCompleteMode.None;
            txtUnitValue.AutoCompleteSource = AutoCompleteSource.None;
            txtUnitValue.BackgroundImageLayout = ImageLayout.None;
            txtUnitValue.CharacterCasing = CharacterCasing.Normal;
            txtUnitValue.Depth = 0;
            txtUnitValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnitValue.HideSelection = true;
            txtUnitValue.Hint = "Unit Value";
            txtUnitValue.LeadingIcon = null;
            txtUnitValue.Location = new Point(262, 29);
            txtUnitValue.Margin = new Padding(3, 4, 3, 4);
            txtUnitValue.MaxLength = 32767;
            txtUnitValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnitValue.Name = "txtUnitValue";
            txtUnitValue.PasswordChar = '\0';
            txtUnitValue.PrefixSuffixText = null;
            txtUnitValue.ReadOnly = false;
            txtUnitValue.RightToLeft = RightToLeft.No;
            txtUnitValue.SelectedText = "";
            txtUnitValue.SelectionLength = 0;
            txtUnitValue.SelectionStart = 0;
            txtUnitValue.ShortcutsEnabled = true;
            txtUnitValue.Size = new Size(103, 48);
            txtUnitValue.TabIndex = 1;
            txtUnitValue.TabStop = false;
            txtUnitValue.TextAlign = HorizontalAlignment.Left;
            txtUnitValue.TrailingIcon = null;
            txtUnitValue.UseSystemPasswordChar = false;
            txtUnitValue.Leave += txtUnitValue_Leave;
            // 
            // txtProduct
            // 
            txtProduct.AutoResize = false;
            txtProduct.BackColor = Color.FromArgb(255, 255, 255);
            txtProduct.Depth = 0;
            txtProduct.DrawMode = DrawMode.OwnerDrawVariable;
            txtProduct.DropDownHeight = 174;
            txtProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProduct.DropDownWidth = 121;
            txtProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtProduct.FormattingEnabled = true;
            txtProduct.Hint = "Product";
            txtProduct.IntegralHeight = false;
            txtProduct.ItemHeight = 43;
            txtProduct.Location = new Point(3, 28);
            txtProduct.Margin = new Padding(3, 4, 3, 4);
            txtProduct.MaxDropDownItems = 4;
            txtProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(251, 49);
            txtProduct.StartIndex = 0;
            txtProduct.TabIndex = 0;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.AllowUserToDeleteRows = false;
            dataGridViewItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(3, 101);
            dataGridViewItems.Margin = new Padding(3, 4, 3, 4);
            dataGridViewItems.MultiSelect = false;
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(689, 200);
            dataGridViewItems.TabIndex = 5;
            // 
            // txtCustomer
            // 
            txtCustomer.AutoResize = false;
            txtCustomer.BackColor = Color.FromArgb(255, 255, 255);
            txtCustomer.Depth = 0;
            txtCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            txtCustomer.DropDownHeight = 174;
            txtCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCustomer.DropDownWidth = 121;
            txtCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCustomer.FormattingEnabled = true;
            txtCustomer.Hint = "Customer";
            txtCustomer.IntegralHeight = false;
            txtCustomer.ItemHeight = 43;
            txtCustomer.Location = new Point(10, 81);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.MaxDropDownItems = 4;
            txtCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(687, 49);
            txtCustomer.StartIndex = 0;
            txtCustomer.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.AutoResize = false;
            txtUser.BackColor = Color.FromArgb(255, 255, 255);
            txtUser.Depth = 0;
            txtUser.DrawMode = DrawMode.OwnerDrawVariable;
            txtUser.DropDownHeight = 174;
            txtUser.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUser.DropDownWidth = 121;
            txtUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtUser.FormattingEnabled = true;
            txtUser.Hint = "User";
            txtUser.IntegralHeight = false;
            txtUser.ItemHeight = 43;
            txtUser.Location = new Point(240, 7);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.MaxDropDownItems = 4;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(329, 49);
            txtUser.StartIndex = 0;
            txtUser.TabIndex = 1;
            // 
            // txtDateSale
            // 
            txtDateSale.AllowPromptAsInput = true;
            txtDateSale.AnimateReadOnly = false;
            txtDateSale.AsciiOnly = false;
            txtDateSale.BackgroundImageLayout = ImageLayout.None;
            txtDateSale.BeepOnError = false;
            txtDateSale.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDateSale.Depth = 0;
            txtDateSale.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDateSale.HidePromptOnLeave = false;
            txtDateSale.HideSelection = true;
            txtDateSale.Hint = "DateSale";
            txtDateSale.InsertKeyMode = InsertKeyMode.Default;
            txtDateSale.LeadingIcon = null;
            txtDateSale.Location = new Point(10, 9);
            txtDateSale.Margin = new Padding(3, 4, 3, 4);
            txtDateSale.Mask = "99/99/9999";
            txtDateSale.MaxLength = 32767;
            txtDateSale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDateSale.Name = "txtDateSale";
            txtDateSale.PasswordChar = '\0';
            txtDateSale.PrefixSuffixText = null;
            txtDateSale.PromptChar = '_';
            txtDateSale.ReadOnly = false;
            txtDateSale.RejectInputOnFirstFailure = false;
            txtDateSale.ResetOnPrompt = true;
            txtDateSale.ResetOnSpace = true;
            txtDateSale.RightToLeft = RightToLeft.No;
            txtDateSale.SelectedText = "";
            txtDateSale.SelectionLength = 0;
            txtDateSale.SelectionStart = 0;
            txtDateSale.ShortcutsEnabled = true;
            txtDateSale.Size = new Size(223, 48);
            txtDateSale.SkipLiterals = true;
            txtDateSale.TabIndex = 0;
            txtDateSale.TabStop = false;
            txtDateSale.Text = "  /  /";
            txtDateSale.TextAlign = HorizontalAlignment.Center;
            txtDateSale.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDateSale.TrailingIcon = null;
            txtDateSale.UseSystemPasswordChar = false;
            txtDateSale.ValidatingType = null;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 728);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "SaleForm";
            Padding = new Padding(3, 113, 3, 5);
            Text = "Cadastro de Vendas";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox groupBox1;
        private DataGridView dataGridViewItems;
        private ReaLTaiizor.Controls.MaterialComboBox txtUser;
        private ReaLTaiizor.Controls.MaterialComboBox txtCustomer;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDateSale;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnitValue;
        private ReaLTaiizor.Controls.MaterialComboBox txtProduct;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalValue;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialLabel lblValue;
        private ReaLTaiizor.Controls.MaterialLabel lblQuantityItems;
    }
}