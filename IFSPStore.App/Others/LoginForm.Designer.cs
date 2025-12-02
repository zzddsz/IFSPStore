namespace IFSPStore.App.Others
{
    partial class LoginForm
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
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnEnter = new ReaLTaiizor.Controls.MaterialButton();
            lblDontHave = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(38, 140);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(312, 48);
            txtLogin.TabIndex = 0;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            txtLogin.Click += txtLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(38, 217);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(312, 48);
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Click += txtPassword_Click;
            // 
            // btnEnter
            // 
            btnEnter.AutoSize = false;
            btnEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnter.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnter.Depth = 0;
            btnEnter.HighEmphasis = true;
            btnEnter.Icon = null;
            btnEnter.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEnter.Location = new Point(108, 334);
            btnEnter.Margin = new Padding(4, 6, 4, 6);
            btnEnter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEnter.Name = "btnEnter";
            btnEnter.NoAccentTextColor = Color.Empty;
            btnEnter.Size = new Size(158, 36);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnter.UseAccentColor = false;
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblDontHave
            // 
            lblDontHave.AutoSize = true;
            lblDontHave.ForeColor = SystemColors.HotTrack;
            lblDontHave.Location = new Point(38, 286);
            lblDontHave.Name = "lblDontHave";
            lblDontHave.Size = new Size(137, 20);
            lblDontHave.TabIndex = 3;
            lblDontHave.Text = "Don't have a login?";
            lblDontHave.Click += lblDontHave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(38, 84);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 34);
            lblTitle.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 407);
            Controls.Add(lblTitle);
            Controls.Add(lblDontHave);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialButton btnEnter;
        private Label lblDontHave;
        private Label lblTitle;
    }
}