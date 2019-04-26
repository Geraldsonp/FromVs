namespace Payroll_System
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalHoursTxt = new System.Windows.Forms.TextBox();
            this.PaymentHTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.LastNametTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnRemoveEmplo = new System.Windows.Forms.Button();
            this.Clearallbtn = new System.Windows.Forms.Button();
            this.btnPayThis = new System.Windows.Forms.Button();
            this.btnHours = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employe ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "P/H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Horas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(269, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TotalHoursTxt
            // 
            this.TotalHoursTxt.Location = new System.Drawing.Point(365, 307);
            this.TotalHoursTxt.Name = "TotalHoursTxt";
            this.TotalHoursTxt.Size = new System.Drawing.Size(100, 20);
            this.TotalHoursTxt.TabIndex = 4;
            // 
            // PaymentHTxt
            // 
            this.PaymentHTxt.Location = new System.Drawing.Point(365, 275);
            this.PaymentHTxt.Name = "PaymentHTxt";
            this.PaymentHTxt.Size = new System.Drawing.Size(100, 20);
            this.PaymentHTxt.TabIndex = 4;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(365, 243);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.ReadOnly = true;
            this.AgeTxt.Size = new System.Drawing.Size(100, 20);
            this.AgeTxt.TabIndex = 4;
            // 
            // LastNametTxt
            // 
            this.LastNametTxt.Location = new System.Drawing.Point(365, 213);
            this.LastNametTxt.Name = "LastNametTxt";
            this.LastNametTxt.Size = new System.Drawing.Size(100, 20);
            this.LastNametTxt.TabIndex = 4;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(365, 181);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 4;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Location = new System.Drawing.Point(13, 177);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(105, 23);
            this.BtnAddEmployee.TabIndex = 5;
            this.BtnAddEmployee.Text = "Add";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(145, 206);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(105, 23);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Caculate Payment";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnRemoveEmplo
            // 
            this.BtnRemoveEmplo.Location = new System.Drawing.Point(13, 206);
            this.BtnRemoveEmplo.Name = "BtnRemoveEmplo";
            this.BtnRemoveEmplo.Size = new System.Drawing.Size(105, 23);
            this.BtnRemoveEmplo.TabIndex = 5;
            this.BtnRemoveEmplo.Text = "Remove";
            this.BtnRemoveEmplo.UseVisualStyleBackColor = true;
            this.BtnRemoveEmplo.Click += new System.EventHandler(this.BtnRemoveEmplo_Click);
            // 
            // Clearallbtn
            // 
            this.Clearallbtn.Location = new System.Drawing.Point(145, 264);
            this.Clearallbtn.Name = "Clearallbtn";
            this.Clearallbtn.Size = new System.Drawing.Size(105, 23);
            this.Clearallbtn.TabIndex = 5;
            this.Clearallbtn.Text = "Clear All";
            this.Clearallbtn.UseVisualStyleBackColor = true;
            this.Clearallbtn.Click += new System.EventHandler(this.Clearallbtn_Click);
            // 
            // btnPayThis
            // 
            this.btnPayThis.Location = new System.Drawing.Point(145, 235);
            this.btnPayThis.Name = "btnPayThis";
            this.btnPayThis.Size = new System.Drawing.Size(105, 23);
            this.btnPayThis.TabIndex = 5;
            this.btnPayThis.Text = "Pay This";
            this.btnPayThis.UseVisualStyleBackColor = true;
            this.btnPayThis.Click += new System.EventHandler(this.btnPayThis_Click);
            // 
            // btnHours
            // 
            this.btnHours.Location = new System.Drawing.Point(145, 179);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(105, 23);
            this.btnHours.TabIndex = 5;
            this.btnHours.Text = "Add Hours";
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(13, 235);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(105, 23);
            this.btnImage.TabIndex = 5;
            this.btnImage.Text = "Change Image";
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 378);
            this.Controls.Add(this.btnHours);
            this.Controls.Add(this.btnPayThis);
            this.Controls.Add(this.Clearallbtn);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.BtnRemoveEmplo);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.LastNametTxt);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.PaymentHTxt);
            this.Controls.Add(this.TotalHoursTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "GP ENTERPRICE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TotalHoursTxt;
        private System.Windows.Forms.TextBox PaymentHTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox LastNametTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnRemoveEmplo;
        private System.Windows.Forms.Button Clearallbtn;
        private System.Windows.Forms.Button btnPayThis;
        private System.Windows.Forms.Button btnHours;
        private System.Windows.Forms.Button btnImage;
    }
}

