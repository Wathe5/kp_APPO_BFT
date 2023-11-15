
namespace KP_APPO
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreateConst = new System.Windows.Forms.Button();
            this.textBoxConstData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateVar = new System.Windows.Forms.Button();
            this.textBoxVarData = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreateLink = new System.Windows.Forms.Button();
            this.textBoxLinkData = new System.Windows.Forms.TextBox();
            this.buttonСancelLink = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLinkName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonCreateConst);
            this.groupBox1.Controls.Add(this.textBoxConstData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Константа";
            this.groupBox1.Visible = false;
            // 
            // buttonCreateConst
            // 
            this.buttonCreateConst.Location = new System.Drawing.Point(5, 135);
            this.buttonCreateConst.Name = "buttonCreateConst";
            this.buttonCreateConst.Size = new System.Drawing.Size(90, 20);
            this.buttonCreateConst.TabIndex = 1;
            this.buttonCreateConst.Text = "Создать";
            this.buttonCreateConst.UseVisualStyleBackColor = true;
            this.buttonCreateConst.Click += new System.EventHandler(this.buttonCreateConst_Click);
            // 
            // textBoxConstData
            // 
            this.textBoxConstData.Location = new System.Drawing.Point(5, 40);
            this.textBoxConstData.Name = "textBoxConstData";
            this.textBoxConstData.Size = new System.Drawing.Size(186, 20);
            this.textBoxConstData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(103, 135);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 20);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonCreateVar);
            this.groupBox2.Controls.Add(this.textBoxVarData);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxVarName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Переменная";
            this.groupBox2.Visible = false;
            // 
            // buttonCreateVar
            // 
            this.buttonCreateVar.Location = new System.Drawing.Point(5, 135);
            this.buttonCreateVar.Name = "buttonCreateVar";
            this.buttonCreateVar.Size = new System.Drawing.Size(90, 20);
            this.buttonCreateVar.TabIndex = 2;
            this.buttonCreateVar.Text = "Создать";
            this.buttonCreateVar.UseVisualStyleBackColor = true;
            this.buttonCreateVar.Click += new System.EventHandler(this.buttonCreateVar_Click);
            // 
            // textBoxVarData
            // 
            this.textBoxVarData.Location = new System.Drawing.Point(5, 90);
            this.textBoxVarData.Name = "textBoxVarData";
            this.textBoxVarData.Size = new System.Drawing.Size(186, 20);
            this.textBoxVarData.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(107, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Значение";
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.Location = new System.Drawing.Point(5, 40);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(186, 20);
            this.textBoxVarName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonCreateLink);
            this.groupBox3.Controls.Add(this.textBoxLinkData);
            this.groupBox3.Controls.Add(this.buttonСancelLink);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxLinkName);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Связь";
            this.groupBox3.Visible = false;
            // 
            // buttonCreateLink
            // 
            this.buttonCreateLink.Location = new System.Drawing.Point(5, 135);
            this.buttonCreateLink.Name = "buttonCreateLink";
            this.buttonCreateLink.Size = new System.Drawing.Size(90, 20);
            this.buttonCreateLink.TabIndex = 2;
            this.buttonCreateLink.Text = "Создать";
            this.buttonCreateLink.UseVisualStyleBackColor = true;
            this.buttonCreateLink.Click += new System.EventHandler(this.buttonCreateLink_Click);
            // 
            // textBoxLinkData
            // 
            this.textBoxLinkData.Location = new System.Drawing.Point(5, 90);
            this.textBoxLinkData.Name = "textBoxLinkData";
            this.textBoxLinkData.Size = new System.Drawing.Size(186, 20);
            this.textBoxLinkData.TabIndex = 1;
            // 
            // buttonСancelLink
            // 
            this.buttonСancelLink.Location = new System.Drawing.Point(103, 135);
            this.buttonСancelLink.Name = "buttonСancelLink";
            this.buttonСancelLink.Size = new System.Drawing.Size(90, 20);
            this.buttonСancelLink.TabIndex = 3;
            this.buttonСancelLink.Text = "Отмена";
            this.buttonСancelLink.UseVisualStyleBackColor = true;
            this.buttonСancelLink.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Значения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Названия";
            // 
            // textBoxLinkName
            // 
            this.textBoxLinkName.Location = new System.Drawing.Point(5, 40);
            this.textBoxLinkName.Name = "textBoxLinkName";
            this.textBoxLinkName.Size = new System.Drawing.Size(186, 20);
            this.textBoxLinkName.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 181);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCreateLink;
        private System.Windows.Forms.TextBox textBoxLinkData;
        private System.Windows.Forms.Button buttonСancelLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLinkName;
        private System.Windows.Forms.Button buttonCreateVar;
        private System.Windows.Forms.TextBox textBoxVarData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConstData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateConst;
    }
}