namespace Formulario_G1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtHombre = new System.Windows.Forms.RadioButton();
            this.rbtMujeres = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInodoros = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLavamanos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btRegistros = new System.Windows.Forms.Button();
            this.txtRegistros = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(61, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GASTO DE AGUA EN BAÑOS DE LA UNIVERSIDAD";
            this.lblTitulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreE.Location = new System.Drawing.Point(30, 111);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(60, 16);
            this.lblNombreE.TabIndex = 1;
            this.lblNombreE.Text = "Edficio:";
            this.lblNombreE.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O"});
            this.cbxEdificio.Location = new System.Drawing.Point(108, 110);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(105, 21);
            this.cbxEdificio.TabIndex = 2;
            this.cbxEdificio.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baño:";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // rbtHombre
            // 
            this.rbtHombre.AutoSize = true;
            this.rbtHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHombre.Location = new System.Drawing.Point(298, 111);
            this.rbtHombre.Name = "rbtHombre";
            this.rbtHombre.Size = new System.Drawing.Size(82, 20);
            this.rbtHombre.TabIndex = 4;
            this.rbtHombre.TabStop = true;
            this.rbtHombre.Text = "Hombres";
            this.rbtHombre.UseVisualStyleBackColor = true;
            this.rbtHombre.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbtMujeres
            // 
            this.rbtMujeres.AutoSize = true;
            this.rbtMujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMujeres.Location = new System.Drawing.Point(385, 111);
            this.rbtMujeres.Name = "rbtMujeres";
            this.rbtMujeres.Size = new System.Drawing.Size(74, 20);
            this.rbtMujeres.TabIndex = 5;
            this.rbtMujeres.TabStop = true;
            this.rbtMujeres.Text = "Mujeres";
            this.rbtMujeres.UseVisualStyleBackColor = true;
            this.rbtMujeres.CheckedChanged += new System.EventHandler(this.RbtMujeres_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad inodoros:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtInodoros
            // 
            this.txtInodoros.Location = new System.Drawing.Point(189, 156);
            this.txtInodoros.Name = "txtInodoros";
            this.txtInodoros.Size = new System.Drawing.Size(75, 20);
            this.txtInodoros.TabIndex = 8;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(232, 206);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(75, 20);
            this.txtLitros.TabIndex = 10;
            this.txtLitros.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Litros de agua expulsada";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "por inodoro:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtLavamanos
            // 
            this.txtLavamanos.Location = new System.Drawing.Point(202, 258);
            this.txtLavamanos.Name = "txtLavamanos";
            this.txtLavamanos.Size = new System.Drawing.Size(75, 20);
            this.txtLavamanos.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad lavamanos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiempo de la expulsión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "de agua:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(220, 314);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(75, 20);
            this.txtTiempo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "*Con base a que aprox 100 estudiantes usan un baño de la universidad";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(106, 373);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(95, 38);
            this.btRegistrar.TabIndex = 18;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // btRegistros
            // 
            this.btRegistros.Location = new System.Drawing.Point(239, 373);
            this.btRegistros.Name = "btRegistros";
            this.btRegistros.Size = new System.Drawing.Size(95, 38);
            this.btRegistros.TabIndex = 19;
            this.btRegistros.Text = "Visualizar Registros";
            this.btRegistros.UseVisualStyleBackColor = true;
            this.btRegistros.Click += new System.EventHandler(this.BtRegistros_Click);
            // 
            // txtRegistros
            // 
            this.txtRegistros.Location = new System.Drawing.Point(410, 144);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(313, 198);
            this.txtRegistros.TabIndex = 20;
            this.txtRegistros.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 520);
            this.Controls.Add(this.txtRegistros);
            this.Controls.Add(this.btRegistros);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLavamanos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInodoros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtMujeres);
            this.Controls.Add(this.rbtHombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.RadioButton rbtMujeres;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInodoros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLavamanos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btRegistros;
        private System.Windows.Forms.RichTextBox txtRegistros;
    }
}

