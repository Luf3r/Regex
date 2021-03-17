namespace DataForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDate = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this.btn_Fillup = new System.Windows.Forms.Button();
            this._lblName = new System.Windows.Forms.Label();
            this._lblDate = new System.Windows.Forms.Label();
            this._lblEmail = new System.Windows.Forms.Label();
            this._lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // _txtName
            // 
            resources.ApplyResources(this._txtName, "_txtName");
            this._txtName.Name = "_txtName";
            // 
            // _txtDate
            // 
            resources.ApplyResources(this._txtDate, "_txtDate");
            this._txtDate.Name = "_txtDate";
            // 
            // _txtEmail
            // 
            resources.ApplyResources(this._txtEmail, "_txtEmail");
            this._txtEmail.Name = "_txtEmail";
            // 
            // _txtPhone
            // 
            resources.ApplyResources(this._txtPhone, "_txtPhone");
            this._txtPhone.Name = "_txtPhone";
            // 
            // btn_Fillup
            // 
            resources.ApplyResources(this.btn_Fillup, "btn_Fillup");
            this.btn_Fillup.Name = "btn_Fillup";
            this.btn_Fillup.UseVisualStyleBackColor = true;
            this.btn_Fillup.Click += new System.EventHandler(this.btn_FillUpClick);
            // 
            // _lblName
            // 
            resources.ApplyResources(this._lblName, "_lblName");
            this._lblName.Name = "_lblName";
            // 
            // _lblDate
            // 
            resources.ApplyResources(this._lblDate, "_lblDate");
            this._lblDate.Name = "_lblDate";
            // 
            // _lblEmail
            // 
            resources.ApplyResources(this._lblEmail, "_lblEmail");
            this._lblEmail.Name = "_lblEmail";
            // 
            // _lblPhone
            // 
            resources.ApplyResources(this._lblPhone, "_lblPhone");
            this._lblPhone.Name = "_lblPhone";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblPhone);
            this.Controls.Add(this._lblEmail);
            this.Controls.Add(this._lblDate);
            this.Controls.Add(this._lblName);
            this.Controls.Add(this.btn_Fillup);
            this.Controls.Add(this._txtPhone);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtDate);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label _lblDate;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.Label _lblPhone;

        private System.Windows.Forms.Label _lblName;

        private System.Windows.Forms.Button btn_Fillup;

        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtPhone;

        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDate;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}