namespace prjLeerEscribirArchivo
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
            this.cmdLeerArchivoRutaFija = new System.Windows.Forms.Button();
            this.txtContenidoArchivo = new System.Windows.Forms.TextBox();
            this.cmdLeerArchivoConDialogo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdLlenarGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLeerArchivoRutaFija
            // 
            this.cmdLeerArchivoRutaFija.Location = new System.Drawing.Point(32, 38);
            this.cmdLeerArchivoRutaFija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLeerArchivoRutaFija.Name = "cmdLeerArchivoRutaFija";
            this.cmdLeerArchivoRutaFija.Size = new System.Drawing.Size(100, 28);
            this.cmdLeerArchivoRutaFija.TabIndex = 0;
            this.cmdLeerArchivoRutaFija.Text = "Leer Archivo";
            this.cmdLeerArchivoRutaFija.UseVisualStyleBackColor = true;
            this.cmdLeerArchivoRutaFija.Click += new System.EventHandler(this.cmdLeerArchivoRutaFija_Click);
            // 
            // txtContenidoArchivo
            // 
            this.txtContenidoArchivo.Location = new System.Drawing.Point(16, 86);
            this.txtContenidoArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(308, 182);
            this.txtContenidoArchivo.TabIndex = 1;
            // 
            // cmdLeerArchivoConDialogo
            // 
            this.cmdLeerArchivoConDialogo.Location = new System.Drawing.Point(191, 38);
            this.cmdLeerArchivoConDialogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLeerArchivoConDialogo.Name = "cmdLeerArchivoConDialogo";
            this.cmdLeerArchivoConDialogo.Size = new System.Drawing.Size(100, 28);
            this.cmdLeerArchivoConDialogo.TabIndex = 2;
            this.cmdLeerArchivoConDialogo.Text = "Leer Archivo";
            this.cmdLeerArchivoConDialogo.UseVisualStyleBackColor = true;
            this.cmdLeerArchivoConDialogo.Click += new System.EventHandler(this.cmdLeerArchivoConDialogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 185);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdLlenarGrid
            // 
            this.cmdLlenarGrid.Location = new System.Drawing.Point(375, 38);
            this.cmdLlenarGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLlenarGrid.Name = "cmdLlenarGrid";
            this.cmdLlenarGrid.Size = new System.Drawing.Size(128, 28);
            this.cmdLlenarGrid.TabIndex = 4;
            this.cmdLlenarGrid.Text = "Cargar Archivo";
            this.cmdLlenarGrid.UseVisualStyleBackColor = true;
            this.cmdLlenarGrid.Click += new System.EventHandler(this.cmdLlenarGrid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Escribir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdLlenarGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdLeerArchivoConDialogo);
            this.Controls.Add(this.txtContenidoArchivo);
            this.Controls.Add(this.cmdLeerArchivoRutaFija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLeerArchivoRutaFija;
        private System.Windows.Forms.TextBox txtContenidoArchivo;
        private System.Windows.Forms.Button cmdLeerArchivoConDialogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdLlenarGrid;
        private System.Windows.Forms.Button button1;
    }
}

