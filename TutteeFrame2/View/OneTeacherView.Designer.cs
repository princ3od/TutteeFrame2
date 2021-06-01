
namespace TutteeFrame2.View
{
    partial class OneTeacherView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneTeacherView));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbName = new System.Windows.Forms.Label();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbInformation = new System.Windows.Forms.Label();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.cbbSubject = new MaterialSurface.MaterialComboBox();
            this.cbbSex = new MaterialSurface.MaterialComboBox();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new MaterialSurface.MaterialTextfield();
            this.txtFirstname = new MaterialSurface.MaterialTextfield();
            this.txtSurename = new MaterialSurface.MaterialTextfield();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.materialCard2 = new MaterialSurface.MaterialCard();
            this.txtMail = new MaterialSurface.MaterialTextfield();
            this.txtPhone = new MaterialSurface.MaterialTextfield();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSurface.MaterialCard();
            this.txtPosition = new MaterialSurface.MaterialTextfield();
            this.cbbType = new MaterialSurface.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new MaterialSurface.TextButton();
            this.btnChooseAvatar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(754, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 39;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 145);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(800, 32);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.White;
            this.ptbAvatar.Image = global::TutteeFrame2.Properties.Resources.default_avatar;
            this.ptbAvatar.Location = new System.Drawing.Point(331, 2);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(140, 140);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 47;
            this.ptbAvatar.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Gray;
            this.lbID.Location = new System.Drawing.Point(0, 172);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(800, 28);
            this.lbID.TabIndex = 49;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(10, 680);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 52;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(0, 694);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(800, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 51;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 36;
            this.mainProgressbar.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.White;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.cbbSubject);
            this.materialCard1.Controls.Add(this.cbbSex);
            this.materialCard1.Controls.Add(this.dateBorn);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.txtAddress);
            this.materialCard1.Controls.Add(this.txtFirstname);
            this.materialCard1.Controls.Add(this.txtSurename);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(35, 216);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = true;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 9;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(350, 380);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 53;
            // 
            // cbbSubject
            // 
            this.cbbSubject.AutoSizing = false;
            this.cbbSubject.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.DropDownWidth = 121;
            this.cbbSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.HintText = "Môn giảng dạy";
            this.cbbSubject.ItemHeight = 41;
            this.cbbSubject.Location = new System.Drawing.Point(20, 314);
            this.cbbSubject.MaxDropDownItems = 4;
            this.cbbSubject.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSubject.Size = new System.Drawing.Size(207, 47);
            this.cbbSubject.TabIndex = 65;
            // 
            // cbbSex
            // 
            this.cbbSex.AutoSizing = false;
            this.cbbSex.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.DropDownWidth = 121;
            this.cbbSex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.HintText = "Giới tính";
            this.cbbSex.ItemHeight = 41;
            this.cbbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSex.Location = new System.Drawing.Point(20, 261);
            this.cbbSex.MaxDropDownItems = 4;
            this.cbbSex.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSex.Size = new System.Drawing.Size(117, 47);
            this.cbbSex.TabIndex = 64;
            // 
            // dateBorn
            // 
            this.dateBorn.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBorn.CustomFormat = "dd-MM-yyyy";
            this.dateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBorn.Location = new System.Drawing.Point(104, 205);
            this.dateBorn.Margin = new System.Windows.Forms.Padding(5);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(200, 29);
            this.dateBorn.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ngày sinh";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoScaleColor = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.CountText = false;
            this.txtAddress.FieldType = MaterialSurface.BoxType.Normal;
            this.txtAddress.FloatingLabelText = "FloatingLabel";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.HandleError = true;
            this.txtAddress.HelperText = "";
            this.txtAddress.HideSelection = true;
            this.txtAddress.HintText = "Địa chỉ";
            this.txtAddress.Location = new System.Drawing.Point(12, 128);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSurface.MouseState.OUT;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ShortcutsEnable = true;
            this.txtAddress.ShowCaret = true;
            this.txtAddress.Size = new System.Drawing.Size(326, 67);
            this.txtAddress.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtAddress.TabIndex = 61;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoScaleColor = true;
            this.txtFirstname.BackColor = System.Drawing.Color.White;
            this.txtFirstname.CountText = false;
            this.txtFirstname.FieldType = MaterialSurface.BoxType.Normal;
            this.txtFirstname.FloatingLabelText = "FloatingLabel";
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstname.HandleError = true;
            this.txtFirstname.HelperText = "";
            this.txtFirstname.HideSelection = true;
            this.txtFirstname.HintText = "Tên";
            this.txtFirstname.Location = new System.Drawing.Point(203, 53);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.MouseState = MaterialSurface.MouseState.OUT;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFirstname.ReadOnly = false;
            this.txtFirstname.ShortcutsEnable = true;
            this.txtFirstname.ShowCaret = true;
            this.txtFirstname.Size = new System.Drawing.Size(135, 67);
            this.txtFirstname.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtFirstname.TabIndex = 60;
            this.txtFirstname.UseSystemPasswordChar = false;
            this.txtFirstname.TextChanged += new System.EventHandler(this.OnUpdateName);
            // 
            // txtSurename
            // 
            this.txtSurename.AutoScaleColor = true;
            this.txtSurename.BackColor = System.Drawing.Color.White;
            this.txtSurename.CountText = false;
            this.txtSurename.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSurename.FloatingLabelText = "FloatingLabel";
            this.txtSurename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSurename.HandleError = true;
            this.txtSurename.HelperText = "";
            this.txtSurename.HideSelection = true;
            this.txtSurename.HintText = "Họ & tên lót";
            this.txtSurename.Location = new System.Drawing.Point(12, 53);
            this.txtSurename.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurename.MaxLength = 32767;
            this.txtSurename.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSurename.Multiline = false;
            this.txtSurename.Name = "txtSurename";
            this.txtSurename.PasswordChar = '\0';
            this.txtSurename.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSurename.ReadOnly = false;
            this.txtSurename.ShortcutsEnable = true;
            this.txtSurename.ShowCaret = true;
            this.txtSurename.Size = new System.Drawing.Size(195, 67);
            this.txtSurename.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSurename.TabIndex = 59;
            this.txtSurename.UseSystemPasswordChar = false;
            this.txtSurename.TextChanged += new System.EventHandler(this.OnUpdateName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(241, 629);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(144, 50);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "Xong";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.White;
            this.materialCard2.CardColor = System.Drawing.Color.White;
            this.materialCard2.Controls.Add(this.txtMail);
            this.materialCard2.Controls.Add(this.txtPhone);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard2.Location = new System.Drawing.Point(412, 216);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseInteract = true;
            this.materialCard2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Radius = 9;
            this.materialCard2.ShawdowDepth = 2;
            this.materialCard2.ShawdowOpacity = 50;
            this.materialCard2.Size = new System.Drawing.Size(344, 203);
            this.materialCard2.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard2.TabIndex = 55;
            // 
            // txtMail
            // 
            this.txtMail.AutoScaleColor = true;
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.CountText = false;
            this.txtMail.FieldType = MaterialSurface.BoxType.Normal;
            this.txtMail.FloatingLabelText = "FloatingLabel";
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMail.HandleError = true;
            this.txtMail.HelperText = "";
            this.txtMail.HideSelection = true;
            this.txtMail.HintText = "Mail";
            this.txtMail.Location = new System.Drawing.Point(19, 128);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MouseState = MaterialSurface.MouseState.OUT;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtMail.ReadOnly = false;
            this.txtMail.ShortcutsEnable = true;
            this.txtMail.ShowCaret = true;
            this.txtMail.Size = new System.Drawing.Size(247, 67);
            this.txtMail.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtMail.TabIndex = 61;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoScaleColor = true;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.CountText = false;
            this.txtPhone.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPhone.FloatingLabelText = "FloatingLabel";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.HandleError = true;
            this.txtPhone.HelperText = "";
            this.txtPhone.HideSelection = true;
            this.txtPhone.HintText = "Số điện thoại";
            this.txtPhone.Location = new System.Drawing.Point(20, 56);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPhone.ReadOnly = false;
            this.txtPhone.ShortcutsEnable = true;
            this.txtPhone.ShowCaret = true;
            this.txtPhone.Size = new System.Drawing.Size(247, 67);
            this.txtPhone.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPhone.TabIndex = 60;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Thông tin liên lạc";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.White;
            this.materialCard3.CardColor = System.Drawing.Color.White;
            this.materialCard3.Controls.Add(this.txtPosition);
            this.materialCard3.Controls.Add(this.cbbType);
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard3.Location = new System.Drawing.Point(412, 429);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard3.MouseInteract = true;
            this.materialCard3.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Radius = 9;
            this.materialCard3.ShawdowDepth = 2;
            this.materialCard3.ShawdowOpacity = 50;
            this.materialCard3.Size = new System.Drawing.Size(344, 167);
            this.materialCard3.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard3.TabIndex = 56;
            // 
            // txtPosition
            // 
            this.txtPosition.AutoScaleColor = true;
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.CountText = false;
            this.txtPosition.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPosition.FloatingLabelText = "FloatingLabel";
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPosition.HandleError = false;
            this.txtPosition.HelperText = "";
            this.txtPosition.HideSelection = true;
            this.txtPosition.HintText = "Vị trí";
            this.txtPosition.Location = new System.Drawing.Point(27, 101);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(5);
            this.txtPosition.MaxLength = 32767;
            this.txtPosition.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPosition.Multiline = false;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = '\0';
            this.txtPosition.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPosition.ReadOnly = false;
            this.txtPosition.ShortcutsEnable = true;
            this.txtPosition.ShowCaret = true;
            this.txtPosition.Size = new System.Drawing.Size(247, 49);
            this.txtPosition.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPosition.TabIndex = 66;
            this.txtPosition.UseSystemPasswordChar = false;
            // 
            // cbbType
            // 
            this.cbbType.AutoSizing = false;
            this.cbbType.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownWidth = 121;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.HintText = "Thuộc";
            this.cbbType.ItemHeight = 41;
            this.cbbType.Items.AddRange(new object[] {
            "Giáo viên",
            "Giáo vụ",
            "Ban giám hiệu"});
            this.cbbType.Location = new System.Drawing.Point(36, 46);
            this.cbbType.MaxDropDownItems = 4;
            this.cbbType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbType.Name = "cbbType";
            this.cbbType.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbType.Size = new System.Drawing.Size(215, 47);
            this.cbbType.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Khác";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.EffectType = MaterialSurface.ET.Custom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(412, 639);
            this.btnCancel.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.Red;
            this.btnCancel.Radius = 6;
            this.btnCancel.Size = new System.Drawing.Size(112, 40);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnExit);
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.AnimateShowHideButton = true;
            this.btnChooseAvatar.Depth = 0;
            this.btnChooseAvatar.Icon = null;
            this.btnChooseAvatar.Location = new System.Drawing.Point(431, 102);
            this.btnChooseAvatar.Mini = true;
            this.btnChooseAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAvatar.TabIndex = 58;
            this.btnChooseAvatar.Text = "materialFloatingActionButton1";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Click += new System.EventHandler(this.OnChooseAvatar);
            // 
            // OneTeacherView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneTeacherView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneTeacherView";
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialCard materialCard2;
        private MaterialSurface.MaterialCard materialCard3;
        private MaterialSurface.TextButton btnCancel;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnChooseAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSurface.MaterialComboBox cbbSubject;
        private MaterialSurface.MaterialComboBox cbbSex;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Label label2;
        private MaterialSurface.MaterialTextfield txtAddress;
        private MaterialSurface.MaterialTextfield txtFirstname;
        private MaterialSurface.MaterialTextfield txtSurename;
        private MaterialSurface.MaterialTextfield txtMail;
        private MaterialSurface.MaterialTextfield txtPhone;
        private MaterialSurface.MaterialTextfield txtPosition;
        private MaterialSurface.MaterialComboBox cbbType;
    }
}