namespace WinFormsApp2
{
    partial class Form2
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
            txtIdCatgoria = new TextBox();
            txtActivo = new TextBox();
            txtCodigo = new TextBox();
            txtDescrpcion = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // txtIdCatgoria
            // 
            txtIdCatgoria.Location = new Point(259, 69);
            txtIdCatgoria.Name = "txtIdCatgoria";
            txtIdCatgoria.Size = new Size(125, 27);
            txtIdCatgoria.TabIndex = 0;
            // 
            // txtActivo
            // 
            txtActivo.Location = new Point(259, 217);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(125, 27);
            txtActivo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(259, 266);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtDescrpcion
            // 
            txtDescrpcion.Location = new Point(259, 170);
            txtDescrpcion.Name = "txtDescrpcion";
            txtDescrpcion.Size = new Size(125, 27);
            txtDescrpcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(259, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 68);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "IdCategoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 269);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "CodCategoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 220);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "Activo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 177);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 122);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Nombre";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(209, 334);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 10;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btnGrabar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtDescrpcion);
            Controls.Add(txtCodigo);
            Controls.Add(txtActivo);
            Controls.Add(txtIdCatgoria);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCatgoria;
        private TextBox txtActivo;
        private TextBox txtCodigo;
        private TextBox txtDescrpcion;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGrabar;
    }
}