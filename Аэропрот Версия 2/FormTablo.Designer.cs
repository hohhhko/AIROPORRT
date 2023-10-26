namespace Аэропрот
{
    partial class FormTablo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablo));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.labelMsk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.labelIrk = new System.Windows.Forms.Label();
            this.ButtonDecore = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridReisi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReisi)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(15, 328);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(83, 33);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGrid.Location = new System.Drawing.Point(182, -2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(594, 192);
            this.DataGrid.TabIndex = 1;
            // 
            // labelMsk
            // 
            this.labelMsk.AutoSize = true;
            this.labelMsk.Location = new System.Drawing.Point(12, 73);
            this.labelMsk.Name = "labelMsk";
            this.labelMsk.Size = new System.Drawing.Size(91, 13);
            this.labelMsk.TabIndex = 2;
            this.labelMsk.Text = "Время в Москве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Location = new System.Drawing.Point(12, 39);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(86, 13);
            this.labelNow.TabIndex = 4;
            this.labelNow.Text = "Текушее время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Location = new System.Drawing.Point(12, 115);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(91, 13);
            this.labelSur.TabIndex = 8;
            this.labelSur.Text = "Время в Сургуте";
            // 
            // labelIrk
            // 
            this.labelIrk.AutoSize = true;
            this.labelIrk.Location = new System.Drawing.Point(12, 162);
            this.labelIrk.Name = "labelIrk";
            this.labelIrk.Size = new System.Drawing.Size(100, 13);
            this.labelIrk.TabIndex = 9;
            this.labelIrk.Text = "Время в Иркутске";
            // 
            // ButtonDecore
            // 
            this.ButtonDecore.Location = new System.Drawing.Point(12, 264);
            this.ButtonDecore.Name = "ButtonDecore";
            this.ButtonDecore.Size = new System.Drawing.Size(93, 42);
            this.ButtonDecore.TabIndex = 10;
            this.ButtonDecore.Text = "Офромление билета";
            this.ButtonDecore.UseVisualStyleBackColor = true;
            this.ButtonDecore.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Меню рабочего";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // DataGridReisi
            // 
            this.DataGridReisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridReisi.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridReisi.Location = new System.Drawing.Point(182, 196);
            this.DataGridReisi.Name = "DataGridReisi";
            this.DataGridReisi.Size = new System.Drawing.Size(593, 165);
            this.DataGridReisi.TabIndex = 12;
            // 
            // FormTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.DataGridReisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonDecore);
            this.Controls.Add(this.labelIrk);
            this.Controls.Add(this.labelSur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMsk);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTablo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табло рейсов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTablo_FormClosed);
            this.Load += new System.EventHandler(this.FormTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label labelMsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.Label labelIrk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button ButtonDecore;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridReisi;
    }
}