namespace ControleFesta
{
    partial class pibbackground
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
            this.pibicone = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblsair = new System.Windows.Forms.LinkLabel();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsobrenome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbsobrenome = new System.Windows.Forms.TextBox();
            this.txbidade = new System.Windows.Forms.NumericUpDown();
            this.txbsaudacao = new System.Windows.Forms.TextBox();
            this.txbexibicao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibicone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pibicone
            // 
            this.pibicone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibicone.Image = global::ControleFesta.Properties.Resources.nasa_Q1p7bh3SHj8_unsplash__1_;
            this.pibicone.Location = new System.Drawing.Point(39, 89);
            this.pibicone.Name = "pibicone";
            this.pibicone.Size = new System.Drawing.Size(379, 253);
            this.pibicone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibicone.TabIndex = 0;
            this.pibicone.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(466, 89);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(282, 45);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Controle de Acesso";
            this.lbltitulo.UseMnemonic = false;
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(543, 286);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(137, 13);
            this.lblidade.TabIndex = 2;
            this.lblidade.Text = "Ano de Nascimento:";
            this.lblidade.Click += new System.EventHandler(this.lblidade_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnverificar.Location = new System.Drawing.Point(474, 346);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(274, 34);
            this.btnverificar.TabIndex = 5;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(474, 386);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(274, 39);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblsair
            // 
            this.lblsair.AutoSize = true;
            this.lblsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsair.LinkColor = System.Drawing.Color.Red;
            this.lblsair.Location = new System.Drawing.Point(763, 9);
            this.lblsair.Name = "lblsair";
            this.lblsair.Size = new System.Drawing.Size(25, 24);
            this.lblsair.TabIndex = 7;
            this.lblsair.TabStop = true;
            this.lblsair.Text = "X";
            this.lblsair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblsair_LinkClicked);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(586, 153);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(47, 13);
            this.lblnome.TabIndex = 8;
            this.lblnome.Text = "Nome:";
            // 
            // lblsobrenome
            // 
            this.lblsobrenome.AutoSize = true;
            this.lblsobrenome.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsobrenome.Location = new System.Drawing.Point(569, 219);
            this.lblsobrenome.Name = "lblsobrenome";
            this.lblsobrenome.Size = new System.Drawing.Size(84, 13);
            this.lblsobrenome.TabIndex = 9;
            this.lblsobrenome.Text = "Sobrenome:";
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(474, 182);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(271, 20);
            this.txbnome.TabIndex = 11;
            this.txbnome.TextChanged += new System.EventHandler(this.txbnome_TextChanged);
            // 
            // txbsobrenome
            // 
            this.txbsobrenome.Location = new System.Drawing.Point(474, 247);
            this.txbsobrenome.Name = "txbsobrenome";
            this.txbsobrenome.Size = new System.Drawing.Size(271, 20);
            this.txbsobrenome.TabIndex = 12;
            this.txbsobrenome.TextChanged += new System.EventHandler(this.txbsobrenome_TextChanged);
            // 
            // txbidade
            // 
            this.txbidade.Location = new System.Drawing.Point(474, 309);
            this.txbidade.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txbidade.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txbidade.Name = "txbidade";
            this.txbidade.Size = new System.Drawing.Size(271, 20);
            this.txbidade.TabIndex = 4;
            this.txbidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbidade.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txbidade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txbsaudacao
            // 
            this.txbsaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsaudacao.Location = new System.Drawing.Point(183, 38);
            this.txbsaudacao.Name = "txbsaudacao";
            this.txbsaudacao.ReadOnly = true;
            this.txbsaudacao.Size = new System.Drawing.Size(450, 20);
            this.txbsaudacao.TabIndex = 13;
            this.txbsaudacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbsaudacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbexibicao
            // 
            this.txbexibicao.Location = new System.Drawing.Point(183, 59);
            this.txbexibicao.Name = "txbexibicao";
            this.txbexibicao.ReadOnly = true;
            this.txbexibicao.Size = new System.Drawing.Size(450, 20);
            this.txbexibicao.TabIndex = 14;
            this.txbexibicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbexibicao.TextChanged += new System.EventHandler(this.txbexibicao_TextChanged);
            // 
            // pibbackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleFesta.Properties.Resources.diagonal_motion_lines_white_background_1017_33198;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbexibicao);
            this.Controls.Add(this.txbsaudacao);
            this.Controls.Add(this.txbsobrenome);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.lblsobrenome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txbidade);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pibicone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pibbackground";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pibicone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibicone;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.LinkLabel lblsair;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsobrenome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbsobrenome;
        private System.Windows.Forms.NumericUpDown txbidade;
        private System.Windows.Forms.TextBox txbsaudacao;
        private System.Windows.Forms.TextBox txbexibicao;
    }
}