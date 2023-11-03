namespace inventario
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
            datos = new GroupBox();
            txtcant = new TextBox();
            txtprecio = new TextBox();
            label2 = new Label();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dvgdatos = new DataGridView();
            btnnuevo = new Button();
            btneditar = new Button();
            btnguardar = new Button();
            btneliminar = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            SuspendLayout();
            // 
            // datos
            // 
            datos.BackColor = SystemColors.ButtonFace;
            datos.BackgroundImageLayout = ImageLayout.None;
            datos.Controls.Add(txtcant);
            datos.Controls.Add(txtprecio);
            datos.Controls.Add(label2);
            datos.Controls.Add(txtname);
            datos.Controls.Add(label4);
            datos.Controls.Add(label3);
            datos.FlatStyle = FlatStyle.System;
            datos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            datos.ForeColor = SystemColors.ActiveCaptionText;
            datos.Location = new Point(14, 11);
            datos.Name = "datos";
            datos.Size = new Size(448, 338);
            datos.TabIndex = 2;
            datos.TabStop = false;
            datos.Tag = "";
            datos.Text = "datos";
            datos.Enter += groupBox1_Enter;
            // 
            // txtcant
            // 
            txtcant.Cursor = Cursors.IBeam;
            txtcant.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtcant.Location = new Point(27, 244);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(140, 24);
            txtcant.TabIndex = 7;
            txtcant.Text = "cantidad";
            txtcant.Enter += txtcant_Enter;
            txtcant.Leave += txtcant_Leave;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = SystemColors.HighlightText;
            txtprecio.Cursor = Cursors.IBeam;
            txtprecio.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.InfoText;
            txtprecio.Location = new Point(27, 181);
            txtprecio.Name = "txtprecio";
            txtprecio.RightToLeft = RightToLeft.No;
            txtprecio.Size = new Size(140, 24);
            txtprecio.TabIndex = 10;
            txtprecio.Text = "precio";
            txtprecio.Enter += txtprecio_Enter;
            txtprecio.Leave += txtprecio_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 223);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // txtname
            // 
            txtname.Cursor = Cursors.IBeam;
            txtname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(27, 104);
            txtname.Name = "txtname";
            txtname.Size = new Size(238, 24);
            txtname.TabIndex = 8;
            txtname.Text = "producto";
            txtname.Enter += txtname_Enter;
            txtname.Leave += txtname_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 74);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre producto";
            label3.UseWaitCursor = true;
            // 
            // dvgdatos
            // 
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dvgdatos.Location = new Point(6, 416);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.RowHeadersWidth = 51;
            dvgdatos.RowTemplate.Height = 29;
            dvgdatos.Size = new Size(1051, 266);
            dvgdatos.TabIndex = 17;
            dvgdatos.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnnuevo
            // 
            btnnuevo.BackColor = SystemColors.HotTrack;
            btnnuevo.ForeColor = SystemColors.ButtonHighlight;
            btnnuevo.Location = new Point(678, 33);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(170, 60);
            btnnuevo.TabIndex = 18;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = false;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.HotTrack;
            btneditar.ForeColor = SystemColors.ButtonHighlight;
            btneditar.Location = new Point(678, 192);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(170, 60);
            btneditar.TabIndex = 19;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = SystemColors.HotTrack;
            btnguardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            btnguardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            btnguardar.ForeColor = SystemColors.ButtonHighlight;
            btnguardar.Location = new Point(678, 115);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(170, 60);
            btnguardar.TabIndex = 20;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = SystemColors.HotTrack;
            btneliminar.ForeColor = SystemColors.ButtonHighlight;
            btneliminar.Location = new Point(678, 277);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(170, 60);
            btneliminar.TabIndex = 21;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre producto";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 198;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1069, 689);
            Controls.Add(btneliminar);
            Controls.Add(btnguardar);
            Controls.Add(btneditar);
            Controls.Add(btnnuevo);
            Controls.Add(dvgdatos);
            Controls.Add(datos);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "Eliminar";
            Load += Form1_Load;
            datos.ResumeLayout(false);
            datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox datos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcant;
        private TextBox txtname;
        private TextBox txtprecio;
        private DataGridView dvgdatos;
        private Button btnnuevo;
        private Button btneditar;
        private Button btnguardar;
        private Button btneliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}