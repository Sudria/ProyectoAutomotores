namespace SudriaAutomotores
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
            this.Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBRepeatP = new System.Windows.Forms.TextBox();
            this.TBTel = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.BAdd = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.DGUser = new System.Windows.Forms.DataGridView();
            this.CBUser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(404, 316);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Conectar";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "F. de nac";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Repetir contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Teléfono";
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Checked = true;
            this.RBMale.Location = new System.Drawing.Point(186, 74);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(73, 17);
            this.RBMale.TabIndex = 10;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Masculino";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(186, 98);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(71, 17);
            this.RBFemale.TabIndex = 11;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Femenino";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(186, 46);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 20);
            this.TBApellido.TabIndex = 12;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(186, 19);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 13;
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(186, 156);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(100, 20);
            this.TBDni.TabIndex = 14;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(186, 183);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 15;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(185, 217);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 16;
            // 
            // TBRepeatP
            // 
            this.TBRepeatP.Location = new System.Drawing.Point(411, 218);
            this.TBRepeatP.Name = "TBRepeatP";
            this.TBRepeatP.Size = new System.Drawing.Size(100, 20);
            this.TBRepeatP.TabIndex = 17;
            // 
            // TBTel
            // 
            this.TBTel.Location = new System.Drawing.Point(186, 259);
            this.TBTel.Name = "TBTel";
            this.TBTel.Size = new System.Drawing.Size(100, 20);
            this.TBTel.TabIndex = 18;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(186, 126);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 19;
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(66, 316);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 20;
            this.BAdd.Text = "Agregar";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(188, 316);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 23);
            this.BDelete.TabIndex = 21;
            this.BDelete.Text = "Borrar";
            this.BDelete.UseVisualStyleBackColor = true;
            // 
            // DGUser
            // 
            this.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUser.Location = new System.Drawing.Point(12, 395);
            this.DGUser.Name = "DGUser";
            this.DGUser.Size = new System.Drawing.Size(1130, 127);
            this.DGUser.TabIndex = 22;
            // 
            // CBUser
            // 
            this.CBUser.FormattingEnabled = true;
            this.CBUser.Items.AddRange(new object[] {
            "Usuario",
            "Admin",
            "Editor"});
            this.CBUser.Location = new System.Drawing.Point(411, 259);
            this.CBUser.Name = "CBUser";
            this.CBUser.Size = new System.Drawing.Size(100, 21);
            this.CBUser.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 614);
            this.Controls.Add(this.CBUser);
            this.Controls.Add(this.DGUser);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.date);
            this.Controls.Add(this.TBTel);
            this.Controls.Add(this.TBRepeatP);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.RBFemale);
            this.Controls.Add(this.RBMale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBRepeatP;
        private System.Windows.Forms.TextBox TBTel;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.DataGridView DGUser;
        private System.Windows.Forms.ComboBox CBUser;
    }
}

