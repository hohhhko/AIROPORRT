namespace Аэропрот
{
    partial class FormReis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReis));
            this.button1 = new System.Windows.Forms.Button();
            this.Datareais = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBoxName = new System.Windows.Forms.ComboBox();
            this.ComboBoxTime = new System.Windows.Forms.ComboBox();
            this.ComboBoxPlace = new System.Windows.Forms.ComboBox();
            this.ComboBoxTicek = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datareais)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datareais
            // 
            this.Datareais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datareais.Location = new System.Drawing.Point(95, 12);
            this.Datareais.Name = "Datareais";
            this.Datareais.Size = new System.Drawing.Size(458, 144);
            this.Datareais.TabIndex = 1;
            this.Datareais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datareais_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добваить рейс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ComboBoxName
            // 
            this.ComboBoxName.FormattingEnabled = true;
            this.ComboBoxName.Location = new System.Drawing.Point(102, 181);
            this.ComboBoxName.Name = "ComboBoxName";
            this.ComboBoxName.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxName.TabIndex = 3;
            // 
            // ComboBoxTime
            // 
            this.ComboBoxTime.FormattingEnabled = true;
            this.ComboBoxTime.Location = new System.Drawing.Point(241, 181);
            this.ComboBoxTime.Name = "ComboBoxTime";
            this.ComboBoxTime.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTime.TabIndex = 4;
            // 
            // ComboBoxPlace
            // 
            this.ComboBoxPlace.FormattingEnabled = true;
            this.ComboBoxPlace.Location = new System.Drawing.Point(241, 229);
            this.ComboBoxPlace.Name = "ComboBoxPlace";
            this.ComboBoxPlace.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPlace.TabIndex = 5;
            // 
            // ComboBoxTicek
            // 
            this.ComboBoxTicek.FormattingEnabled = true;
            this.ComboBoxTicek.Location = new System.Drawing.Point(102, 229);
            this.ComboBoxTicek.Name = "ComboBoxTicek";
            this.ComboBoxTicek.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTicek.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "Показать Рейсы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пилот";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер билета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Место";
            // 
            // FormReis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 269);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ComboBoxTicek);
            this.Controls.Add(this.ComboBoxPlace);
            this.Controls.Add(this.ComboBoxTime);
            this.Controls.Add(this.ComboBoxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Datareais);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование рейсов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReis_FormClosed);
            this.Load += new System.EventHandler(this.FormReis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datareais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Datareais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBoxName;
        private System.Windows.Forms.ComboBox ComboBoxTime;
        private System.Windows.Forms.ComboBox ComboBoxPlace;
        private System.Windows.Forms.ComboBox ComboBoxTicek;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}