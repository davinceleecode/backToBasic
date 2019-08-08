namespace BackToBasic
{
    partial class frmReflection
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
            this.listMethods = new System.Windows.Forms.ListBox();
            this.listProperties = new System.Windows.Forms.ListBox();
            this.listConstructors = new System.Windows.Forms.ListBox();
            this.btnDiscoverTypeInfo = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMethods
            // 
            this.listMethods.FormattingEnabled = true;
            this.listMethods.Location = new System.Drawing.Point(12, 56);
            this.listMethods.Name = "listMethods";
            this.listMethods.Size = new System.Drawing.Size(167, 264);
            this.listMethods.TabIndex = 0;
            // 
            // listProperties
            // 
            this.listProperties.FormattingEnabled = true;
            this.listProperties.Location = new System.Drawing.Point(185, 56);
            this.listProperties.Name = "listProperties";
            this.listProperties.Size = new System.Drawing.Size(167, 264);
            this.listProperties.TabIndex = 1;
            // 
            // listConstructors
            // 
            this.listConstructors.FormattingEnabled = true;
            this.listConstructors.Location = new System.Drawing.Point(358, 56);
            this.listConstructors.Name = "listConstructors";
            this.listConstructors.Size = new System.Drawing.Size(167, 264);
            this.listConstructors.TabIndex = 2;
            // 
            // btnDiscoverTypeInfo
            // 
            this.btnDiscoverTypeInfo.Location = new System.Drawing.Point(358, 12);
            this.btnDiscoverTypeInfo.Name = "btnDiscoverTypeInfo";
            this.btnDiscoverTypeInfo.Size = new System.Drawing.Size(167, 23);
            this.btnDiscoverTypeInfo.TabIndex = 3;
            this.btnDiscoverTypeInfo.Text = "Discover Type Information";
            this.btnDiscoverTypeInfo.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInfo.Click += new System.EventHandler(this.btnDiscoverTypeInfo_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(91, 12);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(261, 20);
            this.txtTypeName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Methods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Constructors";
            // 
            // frmReflection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.btnDiscoverTypeInfo);
            this.Controls.Add(this.listConstructors);
            this.Controls.Add(this.listProperties);
            this.Controls.Add(this.listMethods);
            this.Name = "frmReflection";
            this.Text = "frmReflection";
            this.Load += new System.EventHandler(this.frmReflection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMethods;
        private System.Windows.Forms.ListBox listProperties;
        private System.Windows.Forms.ListBox listConstructors;
        private System.Windows.Forms.Button btnDiscoverTypeInfo;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}