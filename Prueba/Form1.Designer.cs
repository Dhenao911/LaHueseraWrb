namespace Prueba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.txDuraccion = new System.Windows.Forms.TextBox();
            this.txAño = new System.Windows.Forms.TextBox();
            this.txGenero = new System.Windows.Forms.TextBox();
            this.txTitulo = new System.Windows.Forms.TextBox();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duraccion minutos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año de lanzamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codigo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Location = new System.Drawing.Point(565, 91);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(360, 450);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(75, 613);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(101, 50);
            this.btBuscar.TabIndex = 10;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(170, 137);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(231, 27);
            this.txCodigo.TabIndex = 11;
            // 
            // txEstado
            // 
            this.txEstado.Location = new System.Drawing.Point(170, 357);
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(100, 27);
            this.txEstado.TabIndex = 12;
            // 
            // txDuraccion
            // 
            this.txDuraccion.Location = new System.Drawing.Point(314, 309);
            this.txDuraccion.Name = "txDuraccion";
            this.txDuraccion.Size = new System.Drawing.Size(100, 27);
            this.txDuraccion.TabIndex = 13;
            // 
            // txAño
            // 
            this.txAño.Location = new System.Drawing.Point(324, 263);
            this.txAño.Name = "txAño";
            this.txAño.Size = new System.Drawing.Size(100, 27);
            this.txAño.TabIndex = 14;
            // 
            // txGenero
            // 
            this.txGenero.Location = new System.Drawing.Point(170, 224);
            this.txGenero.Name = "txGenero";
            this.txGenero.Size = new System.Drawing.Size(167, 27);
            this.txGenero.TabIndex = 15;
            // 
            // txTitulo
            // 
            this.txTitulo.Location = new System.Drawing.Point(160, 180);
            this.txTitulo.Name = "txTitulo";
            this.txTitulo.Size = new System.Drawing.Size(241, 27);
            this.txTitulo.TabIndex = 16;
            // 
            // txDescripcion
            // 
            this.txDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescripcion.Location = new System.Drawing.Point(76, 435);
            this.txDescripcion.Multiline = true;
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txDescripcion.Size = new System.Drawing.Size(338, 134);
            this.txDescripcion.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 750);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.txTitulo);
            this.Controls.Add(this.txGenero);
            this.Controls.Add(this.txAño);
            this.Controls.Add(this.txDuraccion);
            this.Controls.Add(this.txEstado);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.TextBox txDuraccion;
        private System.Windows.Forms.TextBox txAño;
        private System.Windows.Forms.TextBox txGenero;
        private System.Windows.Forms.TextBox txTitulo;
        private System.Windows.Forms.TextBox txDescripcion;
    }
}

