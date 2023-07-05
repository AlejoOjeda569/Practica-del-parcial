namespace simulacion_parcial_._Wform
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnOk = new Button();
            txtAltura = new TextBox();
            Altura = new Label();
            txtRadio = new TextBox();
            label1 = new Label();
            dgvConos = new DataGridView();
            colradio = new DataGridViewTextBoxColumn();
            colaltura = new DataGridViewTextBoxColumn();
            colgeneratriz = new DataGridViewTextBoxColumn();
            colarea = new DataGridViewTextBoxColumn();
            colvolumen = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtAltura);
            splitContainer1.Panel1.Controls.Add(Altura);
            splitContainer1.Panel1.Controls.Add(txtRadio);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvConos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(625, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 47);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(180, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 47);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(47, 197);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(90, 47);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(111, 144);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // Altura
            // 
            Altura.AutoSize = true;
            Altura.Location = new Point(47, 147);
            Altura.Name = "Altura";
            Altura.Size = new Size(39, 15);
            Altura.TabIndex = 2;
            Altura.Text = "Altura";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(111, 47);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Radio";
            // 
            // dgvConos
            // 
            dgvConos.AllowUserToAddRows = false;
            dgvConos.AllowUserToDeleteRows = false;
            dgvConos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConos.Columns.AddRange(new DataGridViewColumn[] { colradio, colaltura, colgeneratriz, colarea, colvolumen });
            dgvConos.Dock = DockStyle.Fill;
            dgvConos.Location = new Point(0, 0);
            dgvConos.Name = "dgvConos";
            dgvConos.ReadOnly = true;
            dgvConos.RowTemplate.Height = 25;
            dgvConos.Size = new Size(800, 180);
            dgvConos.TabIndex = 0;
            dgvConos.CellContentClick += dgvConos_CellContentClick;
            // 
            // colradio
            // 
            colradio.HeaderText = "radio";
            colradio.Name = "colradio";
            colradio.ReadOnly = true;
            // 
            // colaltura
            // 
            colaltura.HeaderText = "Altura";
            colaltura.Name = "colaltura";
            colaltura.ReadOnly = true;
            // 
            // colgeneratriz
            // 
            colgeneratriz.HeaderText = "Generatriz";
            colgeneratriz.Name = "colgeneratriz";
            colgeneratriz.ReadOnly = true;
            // 
            // colarea
            // 
            colarea.HeaderText = "Area";
            colarea.Name = "colarea";
            colarea.ReadOnly = true;
            // 
            // colvolumen
            // 
            colvolumen.HeaderText = "Volumen";
            colvolumen.Name = "colvolumen";
            colvolumen.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtAltura;
        private Label Altura;
        private TextBox txtRadio;
        private Label label1;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnOk;
        private DataGridView dgvConos;
        private DataGridViewTextBoxColumn colradio;
        private DataGridViewTextBoxColumn colaltura;
        private DataGridViewTextBoxColumn colgeneratriz;
        private DataGridViewTextBoxColumn colarea;
        private DataGridViewTextBoxColumn colvolumen;
        private ErrorProvider errorProvider1;
    }
}