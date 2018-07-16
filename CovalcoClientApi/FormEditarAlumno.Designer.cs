namespace CovalcoClientApi
{
    partial class FormEditarAlumno
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEdit_nombre = new System.Windows.Forms.TextBox();
            this.tbEdit_apellido = new System.Windows.Forms.TextBox();
            this.tbEdit_dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEdit_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(134, 222);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.ButtonClickEditar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dni";
            // 
            // tbEdit_nombre
            // 
            this.tbEdit_nombre.Location = new System.Drawing.Point(117, 94);
            this.tbEdit_nombre.Name = "tbEdit_nombre";
            this.tbEdit_nombre.Size = new System.Drawing.Size(182, 20);
            this.tbEdit_nombre.TabIndex = 2;
            // 
            // tbEdit_apellido
            // 
            this.tbEdit_apellido.Location = new System.Drawing.Point(117, 132);
            this.tbEdit_apellido.Name = "tbEdit_apellido";
            this.tbEdit_apellido.Size = new System.Drawing.Size(182, 20);
            this.tbEdit_apellido.TabIndex = 2;
            // 
            // tbEdit_dni
            // 
            this.tbEdit_dni.Location = new System.Drawing.Point(117, 170);
            this.tbEdit_dni.Name = "tbEdit_dni";
            this.tbEdit_dni.Size = new System.Drawing.Size(182, 20);
            this.tbEdit_dni.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editar Alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id";
            // 
            // tbEdit_id
            // 
            this.tbEdit_id.Enabled = false;
            this.tbEdit_id.Location = new System.Drawing.Point(117, 55);
            this.tbEdit_id.Name = "tbEdit_id";
            this.tbEdit_id.Size = new System.Drawing.Size(79, 20);
            this.tbEdit_id.TabIndex = 2;
            // 
            // FormEditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 257);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEdit_dni);
            this.Controls.Add(this.tbEdit_apellido);
            this.Controls.Add(this.tbEdit_id);
            this.Controls.Add(this.tbEdit_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editar);
            this.Name = "FormEditarAlumno";
            this.Text = "FormEditarAlumno";
            this.Load += new System.EventHandler(this.LoadFormEditar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEdit_nombre;
        private System.Windows.Forms.TextBox tbEdit_apellido;
        private System.Windows.Forms.TextBox tbEdit_dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEdit_id;
    }
}