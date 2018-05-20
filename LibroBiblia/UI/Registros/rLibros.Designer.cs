namespace LibroBiblia.UI.Registros
{
    partial class rLibros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.Siglas_textBox = new System.Windows.Forms.TextBox();
            this.TipoId_comboBox = new System.Windows.Forms.ComboBox();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.LibroId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libro Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Siglas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(117, 127);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(239, 20);
            this.Descripcion_textBox.TabIndex = 1;
            // 
            // Siglas_textBox
            // 
            this.Siglas_textBox.Location = new System.Drawing.Point(117, 165);
            this.Siglas_textBox.Name = "Siglas_textBox";
            this.Siglas_textBox.Size = new System.Drawing.Size(100, 20);
            this.Siglas_textBox.TabIndex = 2;
            // 
            // TipoId_comboBox
            // 
            this.TipoId_comboBox.FormattingEnabled = true;
            this.TipoId_comboBox.Items.AddRange(new object[] {
            "",
            "Nuevo",
            "Antiguo"});
            this.TipoId_comboBox.Location = new System.Drawing.Point(117, 208);
            this.TipoId_comboBox.Name = "TipoId_comboBox";
            this.TipoId_comboBox.Size = new System.Drawing.Size(100, 21);
            this.TipoId_comboBox.TabIndex = 3;
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = global::LibroBiblia.Properties.Resources.Save;
            this.Guardar_button.Location = new System.Drawing.Point(7, 52);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(41, 38);
            this.Guardar_button.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Guardar_button, "Guardar Libro");
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // LibroId_numericUpDown
            // 
            this.LibroId_numericUpDown.Location = new System.Drawing.Point(117, 87);
            this.LibroId_numericUpDown.Name = "LibroId_numericUpDown";
            this.LibroId_numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.LibroId_numericUpDown.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(108, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Libro de la Biblia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibroBiblia.Properties.Resources.Modify;
            this.pictureBox1.Location = new System.Drawing.Point(39, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.Eliminar_button);
            this.groupBox2.Controls.Add(this.Nuevo_button);
            this.groupBox2.Controls.Add(this.Guardar_button);
            this.groupBox2.Location = new System.Drawing.Point(374, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(55, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = global::LibroBiblia.Properties.Resources.Delete;
            this.Eliminar_button.Location = new System.Drawing.Point(7, 95);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(41, 38);
            this.Eliminar_button.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Eliminar_button, "Eliminar Libro");
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::LibroBiblia.Properties.Resources.new2;
            this.Nuevo_button.Location = new System.Drawing.Point(7, 9);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(41, 38);
            this.Nuevo_button.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Nuevo_button, "Nuevo Libro");
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(436, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LibroId_numericUpDown);
            this.Controls.Add(this.TipoId_comboBox);
            this.Controls.Add(this.Siglas_textBox);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros Libros";
            ((System.ComponentModel.ISupportInitialize)(this.LibroId_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.TextBox Siglas_textBox;
        private System.Windows.Forms.ComboBox TipoId_comboBox;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.NumericUpDown LibroId_numericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}