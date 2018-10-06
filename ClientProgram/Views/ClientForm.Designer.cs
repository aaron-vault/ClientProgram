namespace ClientProgram.Views
{
    partial class ClientForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtClientCode = new DevExpress.XtraEditors.TextEdit();
            this.txtClientName = new DevExpress.XtraEditors.TextEdit();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.btnAddClientAction = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Код клиента";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Наименование";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Город";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(157, 41);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtClientCode.Size = new System.Drawing.Size(139, 22);
            this.txtClientCode.TabIndex = 3;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(157, 82);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtClientName.Size = new System.Drawing.Size(139, 22);
            this.txtClientName.TabIndex = 4;
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(157, 124);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(139, 21);
            this.cmbCities.TabIndex = 5;
            // 
            // btnAddClientAction
            // 
            this.btnAddClientAction.Location = new System.Drawing.Point(221, 164);
            this.btnAddClientAction.Name = "btnAddClientAction";
            this.btnAddClientAction.Size = new System.Drawing.Size(75, 23);
            this.btnAddClientAction.TabIndex = 6;
            this.btnAddClientAction.Text = "Добавить";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 220);
            this.Controls.Add(this.btnAddClientAction);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(399, 259);
            this.Name = "ClientForm";
            this.Text = "Добавление нового клиента";
            ((System.ComponentModel.ISupportInitialize)(this.txtClientCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtClientCode;
        private DevExpress.XtraEditors.TextEdit txtClientName;
        public System.Windows.Forms.ComboBox cmbCities;
        private DevExpress.XtraEditors.SimpleButton btnAddClientAction;
    }
}