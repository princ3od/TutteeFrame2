
namespace TutteeFrame2.View
{
    partial class OneStudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneStudentView));
            this.cbbCurrentClass = new MaterialSurface.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSurface.MaterialCard();
            this.txtCurrentClass = new MaterialSurface.MaterialTextfield();
            this.cbbStatus = new MaterialSurface.MaterialComboBox();
            this.txtPhone = new MaterialSurface.MaterialTextfield();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbSex = new MaterialSurface.MaterialComboBox();
            this.dateBornPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new MaterialSurface.MaterialTextfield();
            this.txtMail = new MaterialSurface.MaterialTextfield();
            this.materialCard2 = new MaterialSurface.MaterialCard();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.txtFirstname = new MaterialSurface.MaterialTextfield();
            this.txtSurname = new MaterialSurface.MaterialTextfield();
            this.btnCancel = new MaterialSurface.TextButton();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnChooseAvatar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCurrentClass
            // 
            this.cbbCurrentClass.AutoSizing = false;
            this.cbbCurrentClass.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbCurrentClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbCurrentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCurrentClass.DropDownWidth = 121;
            this.cbbCurrentClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbCurrentClass.FormattingEnabled = true;
            this.cbbCurrentClass.HintText = "Thay đổi";
            this.cbbCurrentClass.ItemHeight = 41;
            this.cbbCurrentClass.Items.AddRange(new object[] {
            "Giáo viên",
            "Giáo vụ",
            "Ban giám hiệu"});
            this.cbbCurrentClass.Location = new System.Drawing.Point(209, 65);
            this.cbbCurrentClass.MaxDropDownItems = 4;
            this.cbbCurrentClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbCurrentClass.Name = "cbbCurrentClass";
            this.cbbCurrentClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbCurrentClass.Size = new System.Drawing.Size(111, 47);
            this.cbbCurrentClass.TabIndex = 65;
            this.cbbCurrentClass.SelectedIndexChanged += new System.EventHandler(this.cbbCurrentClass_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 42;
            this.label5.Text = "Khác";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.White;
            this.materialCard3.CardColor = System.Drawing.Color.White;
            this.materialCard3.Controls.Add(this.txtCurrentClass);
            this.materialCard3.Controls.Add(this.cbbStatus);
            this.materialCard3.Controls.Add(this.cbbCurrentClass);
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard3.Location = new System.Drawing.Point(434, 474);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard3.MouseInteract = true;
            this.materialCard3.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Radius = 9;
            this.materialCard3.ShawdowDepth = 2;
            this.materialCard3.ShawdowOpacity = 50;
            this.materialCard3.Size = new System.Drawing.Size(366, 217);
            this.materialCard3.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard3.TabIndex = 68;
            // 
            // txtCurrentClass
            // 
            this.txtCurrentClass.AutoScaleColor = true;
            this.txtCurrentClass.BackColor = System.Drawing.Color.White;
            this.txtCurrentClass.CountText = false;
            this.txtCurrentClass.Enabled = false;
            this.txtCurrentClass.FieldType = MaterialSurface.BoxType.Normal;
            this.txtCurrentClass.FloatingLabelText = "FloatingLabel";
            this.txtCurrentClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCurrentClass.HandleError = true;
            this.txtCurrentClass.HelperText = "";
            this.txtCurrentClass.HideSelection = true;
            this.txtCurrentClass.HintText = "Lớp hiện tại";
            this.txtCurrentClass.Location = new System.Drawing.Point(19, 56);
            this.txtCurrentClass.MaxLength = 32767;
            this.txtCurrentClass.MouseState = MaterialSurface.MouseState.OUT;
            this.txtCurrentClass.Multiline = false;
            this.txtCurrentClass.Name = "txtCurrentClass";
            this.txtCurrentClass.PasswordChar = '\0';
            this.txtCurrentClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtCurrentClass.ReadOnly = false;
            this.txtCurrentClass.ShortcutsEnable = true;
            this.txtCurrentClass.ShowCaret = true;
            this.txtCurrentClass.Size = new System.Drawing.Size(184, 72);
            this.txtCurrentClass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtCurrentClass.TabIndex = 67;
            this.txtCurrentClass.UseSystemPasswordChar = false;
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoSizing = false;
            this.cbbStatus.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.DropDownWidth = 121;
            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.HintText = "Trạng thái ";
            this.cbbStatus.ItemHeight = 41;
            this.cbbStatus.Items.AddRange(new object[] {
            "Đã nghĩ học",
            "Đang học"});
            this.cbbStatus.Location = new System.Drawing.Point(30, 143);
            this.cbbStatus.MaxDropDownItems = 4;
            this.cbbStatus.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbStatus.Size = new System.Drawing.Size(174, 47);
            this.cbbStatus.TabIndex = 66;
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
            this.txtPhone.Size = new System.Drawing.Size(247, 72);
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
            this.label4.Size = new System.Drawing.Size(205, 35);
            this.label4.TabIndex = 42;
            this.label4.Text = "Thông tin liên lạc";
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
            "Nữ",
            "Nam"});
            this.cbbSex.Location = new System.Drawing.Point(20, 261);
            this.cbbSex.MaxDropDownItems = 4;
            this.cbbSex.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSex.Size = new System.Drawing.Size(117, 47);
            this.cbbSex.TabIndex = 64;
            // 
            // dateBornPicker
            // 
            this.dateBornPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBornPicker.CustomFormat = "dd-MM-yyyy";
            this.dateBornPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBornPicker.Location = new System.Drawing.Point(122, 208);
            this.dateBornPicker.Margin = new System.Windows.Forms.Padding(5);
            this.dateBornPicker.Name = "dateBornPicker";
            this.dateBornPicker.Size = new System.Drawing.Size(200, 34);
            this.dateBornPicker.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
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
            this.txtAddress.Size = new System.Drawing.Size(326, 72);
            this.txtAddress.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtAddress.TabIndex = 61;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtMail
            // 
            this.txtMail.AutoScaleColor = true;
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.CountText = false;
            this.txtMail.Enabled = false;
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
            this.txtMail.Size = new System.Drawing.Size(247, 72);
            this.txtMail.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtMail.TabIndex = 61;
            this.txtMail.UseSystemPasswordChar = false;
            this.txtMail.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.White;
            this.materialCard2.CardColor = System.Drawing.Color.White;
            this.materialCard2.Controls.Add(this.txtMail);
            this.materialCard2.Controls.Add(this.txtPhone);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard2.Location = new System.Drawing.Point(434, 226);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseInteract = true;
            this.materialCard2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Radius = 9;
            this.materialCard2.ShawdowDepth = 2;
            this.materialCard2.ShawdowOpacity = 50;
            this.materialCard2.Size = new System.Drawing.Size(366, 238);
            this.materialCard2.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard2.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(250, 721);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(160, 50);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "Xong";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnClickConfirmButton);
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
            this.txtFirstname.Size = new System.Drawing.Size(135, 72);
            this.txtFirstname.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtFirstname.TabIndex = 60;
            this.txtFirstname.UseSystemPasswordChar = false;
            // 
            // txtSurname
            // 
            this.txtSurname.AutoScaleColor = true;
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.CountText = false;
            this.txtSurname.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSurname.FloatingLabelText = "FloatingLabel";
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSurname.HandleError = true;
            this.txtSurname.HelperText = "";
            this.txtSurname.HideSelection = true;
            this.txtSurname.HintText = "Họ & tên lót";
            this.txtSurname.Location = new System.Drawing.Point(12, 53);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSurname.ReadOnly = false;
            this.txtSurname.ShortcutsEnable = true;
            this.txtSurname.ShowCaret = true;
            this.txtSurname.Size = new System.Drawing.Size(195, 72);
            this.txtSurname.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSurname.TabIndex = 59;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.EffectType = MaterialSurface.ET.Custom;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(437, 721);
            this.btnCancel.MouseState = MaterialSurface.MouseState.OUT;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.Red;
            this.btnCancel.Radius = 6;
            this.btnCancel.Size = new System.Drawing.Size(160, 50);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.White;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.cbbSex);
            this.materialCard1.Controls.Add(this.dateBornPicker);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.txtAddress);
            this.materialCard1.Controls.Add(this.txtFirstname);
            this.materialCard1.Controls.Add(this.txtSurname);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(60, 226);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = true;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 9;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(350, 465);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-4, 799);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(851, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 63;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 36;
            this.mainProgressbar.Visible = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(22, 155);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(800, 32);
            this.lbName.TabIndex = 61;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Gray;
            this.lbID.Location = new System.Drawing.Point(22, 182);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(800, 28);
            this.lbID.TabIndex = 62;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(776, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 59;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(1, 780);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(103, 19);
            this.lbInformation.TabIndex = 64;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.AnimateShowHideButton = true;
            this.btnChooseAvatar.Depth = 0;
            this.btnChooseAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseAvatar.Icon = null;
            this.btnChooseAvatar.Location = new System.Drawing.Point(450, 112);
            this.btnChooseAvatar.Mini = true;
            this.btnChooseAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAvatar.TabIndex = 71;
            this.btnChooseAvatar.Text = "Chọn ảnh đại diện\r\n";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.White;
            this.ptbAvatar.Image = global::TutteeFrame2.Properties.Resources.default_avatar;
            this.ptbAvatar.Location = new System.Drawing.Point(350, 12);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(140, 140);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 70;
            this.ptbAvatar.TabStop = false;
            // 
            // OneStudentView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(850, 807);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbInformation);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneStudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneStudentView";
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.MaterialComboBox cbbCurrentClass;
        private System.Windows.Forms.Label label5;
        private MaterialSurface.MaterialCard materialCard3;
        private MaterialSurface.MaterialTextfield txtPhone;
        private System.Windows.Forms.Label label4;
        private MaterialSurface.MaterialComboBox cbbSex;
        private System.Windows.Forms.DateTimePicker dateBornPicker;
        private System.Windows.Forms.Label label2;
        private MaterialSurface.MaterialTextfield txtAddress;
        private MaterialSurface.MaterialTextfield txtMail;
        private MaterialSurface.MaterialCard materialCard2;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialTextfield txtFirstname;
        private MaterialSurface.MaterialTextfield txtSurname;
        private MaterialSurface.TextButton btnCancel;
        private MaterialSurface.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.MaterialComboBox cbbStatus;
        private MaterialSurface.MaterialTextfield txtCurrentClass;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnChooseAvatar;
        private System.Windows.Forms.PictureBox ptbAvatar;
    }
}