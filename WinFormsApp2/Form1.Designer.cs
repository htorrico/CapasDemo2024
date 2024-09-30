namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListar = new Button();
            dgvClientes = new DataGridView();
            button1 = new Button();
            txtFiltro = new TextBox();
            btnListarProcedimientos = new Button();
            txtContacto = new TextBox();
            txtCompania = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(83, 67);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(155, 29);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar Desconectado";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(83, 206);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(589, 188);
            dgvClientes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(274, 67);
            button1.Name = "button1";
            button1.Size = new Size(233, 29);
            button1.TabIndex = 2;
            button1.Text = "Listar Conectado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(529, 69);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(143, 27);
            txtFiltro.TabIndex = 3;
            // 
            // btnListarProcedimientos
            // 
            btnListarProcedimientos.Location = new Point(83, 171);
            btnListarProcedimientos.Name = "btnListarProcedimientos";
            btnListarProcedimientos.Size = new Size(208, 29);
            btnListarProcedimientos.TabIndex = 4;
            btnListarProcedimientos.Text = "Listar Procedimientos";
            btnListarProcedimientos.UseVisualStyleBackColor = true;
            btnListarProcedimientos.Click += btnListarProcedimientos_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(83, 124);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(143, 27);
            txtContacto.TabIndex = 5;
            // 
            // txtCompania
            // 
            txtCompania.Location = new Point(274, 124);
            txtCompania.Name = "txtCompania";
            txtCompania.Size = new Size(143, 27);
            txtCompania.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCompania);
            Controls.Add(txtContacto);
            Controls.Add(btnListarProcedimientos);
            Controls.Add(txtFiltro);
            Controls.Add(button1);
            Controls.Add(dgvClientes);
            Controls.Add(btnListar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvClientes;
        private Button button1;
        private TextBox txtFiltro;
        private Button btnListarProcedimientos;
        private TextBox txtContacto;
        private TextBox txtCompania;
    }
}
