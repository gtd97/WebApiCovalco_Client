namespace CovalcoClientApi
{
    partial class FormGrid
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
            this.grid_form = new System.Windows.Forms.DataGridView();
            this.button_añadir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_form)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_form
            // 
            this.grid_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_form.Location = new System.Drawing.Point(30, 70);
            this.grid_form.Name = "grid_form";
            this.grid_form.Size = new System.Drawing.Size(443, 176);
            this.grid_form.TabIndex = 0;
            // 
            // button_añadir
            // 
            this.button_añadir.Location = new System.Drawing.Point(126, 267);
            this.button_añadir.Name = "button_añadir";
            this.button_añadir.Size = new System.Drawing.Size(75, 23);
            this.button_añadir.TabIndex = 1;
            this.button_añadir.Text = "Añadir";
            this.button_añadir.UseVisualStyleBackColor = true;
            this.button_añadir.Click += new System.EventHandler(this.Button_añadir);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Actualizar);
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_añadir);
            this.Controls.Add(this.grid_form);
            this.Name = "FormGrid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_form;
        private System.Windows.Forms.Button button_añadir;
        private System.Windows.Forms.Button button2;
    }
}

