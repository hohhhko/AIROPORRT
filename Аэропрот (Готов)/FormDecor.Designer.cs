namespace Аэропрот
{
    partial class FormDecor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDecor));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ComboBoxPlace = new System.Windows.Forms.ComboBox();
            this.ButtonForm = new System.Windows.Forms.Button();
            this.TextBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeChose = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 144);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(97, 34);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ComboBoxPlace
            // 
            this.ComboBoxPlace.FormattingEnabled = true;
            this.ComboBoxPlace.Items.AddRange(new object[] {
            "Сургут",
            "Москва",
            "Иркутск",
            "Самара",
            "Сочи"});
            this.ComboBoxPlace.Location = new System.Drawing.Point(269, 43);
            this.ComboBoxPlace.Name = "ComboBoxPlace";
            this.ComboBoxPlace.Size = new System.Drawing.Size(133, 21);
            this.ComboBoxPlace.TabIndex = 1;
            // 
            // ButtonForm
            // 
            this.ButtonForm.Location = new System.Drawing.Point(504, 63);
            this.ButtonForm.Name = "ButtonForm";
            this.ButtonForm.Size = new System.Drawing.Size(97, 71);
            this.ButtonForm.TabIndex = 2;
            this.ButtonForm.Text = "Оформить билет";
            this.ButtonForm.UseVisualStyleBackColor = true;
            this.ButtonForm.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBoxFIO
            // 
            this.TextBoxFIO.Location = new System.Drawing.Point(12, 44);
            this.TextBoxFIO.Name = "TextBoxFIO";
            this.TextBoxFIO.Size = new System.Drawing.Size(238, 20);
            this.TextBoxFIO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ф.И.О";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Место Назначаения";
            // 
            // DateTimeChose
            // 
            this.DateTimeChose.Location = new System.Drawing.Point(114, 101);
            this.DateTimeChose.Name = "DateTimeChose";
            this.DateTimeChose.Size = new System.Drawing.Size(123, 20);
            this.DateTimeChose.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Время";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер билета";
            // 
            // FormDecor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 190);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimeChose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFIO);
            this.Controls.Add(this.ButtonForm);
            this.Controls.Add(this.ComboBoxPlace);
            this.Controls.Add(this.ButtonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDecor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление Билета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDecor_FormClosed);
            this.Load += new System.EventHandler(this.FormDecor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox ComboBoxPlace;
        private System.Windows.Forms.Button ButtonForm;
        private System.Windows.Forms.TextBox TextBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimeChose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}