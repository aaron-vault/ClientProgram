namespace ClientProgram.Views
{
    partial class EditClientForm
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
            this.cmbEditCities = new System.Windows.Forms.ComboBox();
            this.txtClientEditName = new DevExpress.XtraEditors.TextEdit();
            this.txtClientEditCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditClientAction = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientEditCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEditCities
            // 
            this.cmbEditCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCities.FormattingEnabled = true;
            this.cmbEditCities.Location = new System.Drawing.Point(157, 125);
            this.cmbEditCities.Name = "cmbEditCities";
            this.cmbEditCities.Size = new System.Drawing.Size(139, 21);
            this.cmbEditCities.TabIndex = 12;
            // 
            // txtClientEditName
            // 
            this.txtClientEditName.Location = new System.Drawing.Point(157, 83);
            this.txtClientEditName.Name = "txtClientEditName";
            this.txtClientEditName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtClientEditName.Size = new System.Drawing.Size(139, 22);
            this.txtClientEditName.TabIndex = 11;
            // 
            // txtClientEditCode
            // 
            this.txtClientEditCode.Location = new System.Drawing.Point(157, 42);
            this.txtClientEditCode.Name = "txtClientEditCode";
            this.txtClientEditCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtClientEditCode.Size = new System.Drawing.Size(139, 22);
            this.txtClientEditCode.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Город";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Наименование";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Код клиента";
            // 
            // btnEditClientAction
            // 
            this.btnEditClientAction.Location = new System.Drawing.Point(221, 162);
            this.btnEditClientAction.Name = "btnEditClientAction";
            this.btnEditClientAction.Size = new System.Drawing.Size(75, 23);
            this.btnEditClientAction.TabIndex = 14;
            this.btnEditClientAction.Text = "Изменить";
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 220);
            this.Controls.Add(this.btnEditClientAction);
            this.Controls.Add(this.cmbEditCities);
            this.Controls.Add(this.txtClientEditName);
            this.Controls.Add(this.txtClientEditCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditClientForm";
            this.Text = "Редактирование данных о клиенте";
            ((System.ComponentModel.ISupportInitialize)(this.txtClientEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientEditCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbEditCities;
        public DevExpress.XtraEditors.TextEdit txtClientEditName;
        public DevExpress.XtraEditors.TextEdit txtClientEditCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditClientAction;
    }
}