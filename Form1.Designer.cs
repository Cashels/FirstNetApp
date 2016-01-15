namespace Vickypedia.AgeCalc
{
    partial class Form1
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblYears = new DevExpress.XtraEditors.LabelControl();
            this.lblMonths = new DevExpress.XtraEditors.LabelControl();
            this.lblDays = new DevExpress.XtraEditors.LabelControl();
            this.lblHours = new DevExpress.XtraEditors.LabelControl();
            this.lblMinutes = new DevExpress.XtraEditors.LabelControl();
            this.lblSeconds = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bsAgeCalculator = new System.Windows.Forms.BindingSource(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgeCalculator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Birthdate:";
            // 
            // edtBirthDate
            // 
            this.edtBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsAgeCalculator, "BirthDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "G"));
            this.edtBirthDate.EditValue = new System.DateTime(2012, 10, 4, 0, 0, 0, 0);
            this.edtBirthDate.Location = new System.Drawing.Point(132, 12);
            this.edtBirthDate.Name = "edtBirthDate";
            this.edtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtBirthDate.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.edtBirthDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtBirthDate.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.edtBirthDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edtBirthDate.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.edtBirthDate.Size = new System.Drawing.Size(139, 20);
            this.edtBirthDate.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(103, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Age:";
            // 
            // lblYears
            // 
            this.lblYears.AllowHtmlString = true;
            this.lblYears.Location = new System.Drawing.Point(132, 94);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(63, 13);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "labelControl4";
            // 
            // lblMonths
            // 
            this.lblMonths.AllowHtmlString = true;
            this.lblMonths.Location = new System.Drawing.Point(132, 113);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(63, 13);
            this.lblMonths.TabIndex = 4;
            this.lblMonths.Text = "labelControl4";
            // 
            // lblDays
            // 
            this.lblDays.AllowHtmlString = true;
            this.lblDays.Location = new System.Drawing.Point(132, 132);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(63, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "labelControl4";
            // 
            // lblHours
            // 
            this.lblHours.AllowHtmlString = true;
            this.lblHours.Location = new System.Drawing.Point(132, 151);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(63, 13);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "labelControl4";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AllowHtmlString = true;
            this.lblMinutes.Location = new System.Drawing.Point(132, 170);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(63, 13);
            this.lblMinutes.TabIndex = 4;
            this.lblMinutes.Text = "labelControl4";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AllowHtmlString = true;
            this.lblSeconds.Location = new System.Drawing.Point(132, 189);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(63, 13);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "labelControl4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // bsAgeCalculator
            // 
            this.bsAgeCalculator.DataSource = typeof(Vickypedia.AgeCalc.AgeCalculator);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Vickypedia.AgeCalc.Properties.Resources.alarm;
            this.pictureEdit1.Location = new System.Drawing.Point(326, 94);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 226);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.edtBirthDate);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgeCalculator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit edtBirthDate;
        private System.Windows.Forms.BindingSource bsAgeCalculator;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblYears;
        private DevExpress.XtraEditors.LabelControl lblMonths;
        private DevExpress.XtraEditors.LabelControl lblDays;
        private DevExpress.XtraEditors.LabelControl lblHours;
        private DevExpress.XtraEditors.LabelControl lblMinutes;
        private DevExpress.XtraEditors.LabelControl lblSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

