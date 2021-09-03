namespace Presentation
{
    partial class Form1
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonSalario = new System.Windows.Forms.Button();
            this.buttonSalarioMin = new System.Windows.Forms.Button();
            this.buttonSP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAcademicLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.groupBoxDatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(3, 3);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(85, 25);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(115, 25);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(218, 20);
            this.txtDni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(115, 75);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(218, 20);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(115, 123);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(218, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(115, 162);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(218, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.cmbGenero);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.cmbAcademicLevel);
            this.groupBoxDatos.Controls.Add(this.txtDni);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.txtSalario);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.txtNombres);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.txtApellidos);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 3);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(364, 288);
            this.groupBoxDatos.TabIndex = 9;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de Empleados";
            this.groupBoxDatos.Enter += new System.EventHandler(this.GroupBoxDatos_Enter);
            // 
            // buttonSalario
            // 
            this.buttonSalario.Location = new System.Drawing.Point(95, 3);
            this.buttonSalario.Name = "buttonSalario";
            this.buttonSalario.Size = new System.Drawing.Size(103, 25);
            this.buttonSalario.TabIndex = 1;
            this.buttonSalario.Text = "Salario Máximo";
            this.buttonSalario.UseVisualStyleBackColor = true;
            this.buttonSalario.Click += new System.EventHandler(this.ButtonSalario_Click);
            // 
            // buttonSalarioMin
            // 
            this.buttonSalarioMin.Location = new System.Drawing.Point(3, 34);
            this.buttonSalarioMin.Name = "buttonSalarioMin";
            this.buttonSalarioMin.Size = new System.Drawing.Size(85, 23);
            this.buttonSalarioMin.TabIndex = 2;
            this.buttonSalarioMin.Text = "Salario Mínimo";
            this.buttonSalarioMin.UseVisualStyleBackColor = true;
            this.buttonSalarioMin.Click += new System.EventHandler(this.ButtonSalarioMin_Click);
            // 
            // buttonSP
            // 
            this.buttonSP.Location = new System.Drawing.Point(95, 34);
            this.buttonSP.Name = "buttonSP";
            this.buttonSP.Size = new System.Drawing.Size(103, 23);
            this.buttonSP.TabIndex = 3;
            this.buttonSP.Text = "Salario Promedio";
            this.buttonSP.UseVisualStyleBackColor = true;
            this.buttonSP.Click += new System.EventHandler(this.ButtonSP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSalarioMin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSalario, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMen, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 309);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 62);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // buttonMen
            // 
            this.buttonMen.Location = new System.Drawing.Point(214, 34);
            this.buttonMen.Name = "buttonMen";
            this.buttonMen.Size = new System.Drawing.Size(131, 23);
            this.buttonMen.TabIndex = 5;
            this.buttonMen.Text = "Salarios Men. al Prom.";
            this.buttonMen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nivel Academico ";
            // 
            // cmbAcademicLevel
            // 
            this.cmbAcademicLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcademicLevel.FormattingEnabled = true;
            this.cmbAcademicLevel.Items.AddRange(new object[] {
            "Preescolar",
            "Primaria",
            "Secundaria ",
            "Universitario",
            "PostGrado",
            "Maestria",
            "Doctorado",
            "PostDoctorado"});
            this.cmbAcademicLevel.Location = new System.Drawing.Point(115, 207);
            this.cmbAcademicLevel.Name = "cmbAcademicLevel";
            this.cmbAcademicLevel.Size = new System.Drawing.Size(218, 21);
            this.cmbAcademicLevel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Indefinido"});
            this.cmbGenero.Location = new System.Drawing.Point(115, 247);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(218, 21);
            this.cmbGenero.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 437);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonSalario;
        private System.Windows.Forms.Button buttonSalarioMin;
        private System.Windows.Forms.Button buttonSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonMen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAcademicLevel;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
    }
}

