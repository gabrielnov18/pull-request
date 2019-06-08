namespace Jokenpô
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JogadaCPU = new System.Windows.Forms.PictureBox();
            this.MinhaJogada = new System.Windows.Forms.PictureBox();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.groupPlacar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlacarJogador = new System.Windows.Forms.Label();
            this.PlacarCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JogadaCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinhaJogada)).BeginInit();
            this.groupPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupPlacar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.btnPapel);
            this.splitContainer1.Panel2.Controls.Add(this.btnPedra);
            this.splitContainer1.Size = new System.Drawing.Size(638, 441);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinhaJogada);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha Jogada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JogadaCPU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada da CPU";
            // 
            // JogadaCPU
            // 
            this.JogadaCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JogadaCPU.Location = new System.Drawing.Point(17, 25);
            this.JogadaCPU.Name = "JogadaCPU";
            this.JogadaCPU.Size = new System.Drawing.Size(176, 194);
            this.JogadaCPU.TabIndex = 1;
            this.JogadaCPU.TabStop = false;
            // 
            // MinhaJogada
            // 
            this.MinhaJogada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinhaJogada.Location = new System.Drawing.Point(6, 25);
            this.MinhaJogada.Name = "MinhaJogada";
            this.MinhaJogada.Size = new System.Drawing.Size(176, 194);
            this.MinhaJogada.TabIndex = 0;
            this.MinhaJogada.TabStop = false;
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::Jokenpô.Properties.Resources.tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTesoura.Location = new System.Drawing.Point(426, 0);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(213, 174);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.Tesoura);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::Jokenpô.Properties.Resources.papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPapel.Location = new System.Drawing.Point(213, 0);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(213, 174);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.Papel);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::Jokenpô.Properties.Resources.pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPedra.Location = new System.Drawing.Point(0, 0);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(213, 174);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.Pedra);
            // 
            // groupPlacar
            // 
            this.groupPlacar.Controls.Add(this.PlacarCPU);
            this.groupPlacar.Controls.Add(this.PlacarJogador);
            this.groupPlacar.Controls.Add(this.label2);
            this.groupPlacar.Controls.Add(this.label1);
            this.groupPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPlacar.Location = new System.Drawing.Point(227, 48);
            this.groupPlacar.Name = "groupPlacar";
            this.groupPlacar.Size = new System.Drawing.Size(183, 160);
            this.groupPlacar.TabIndex = 2;
            this.groupPlacar.TabStop = false;
            this.groupPlacar.Text = "Placar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU";
            // 
            // PlacarJogador
            // 
            this.PlacarJogador.AutoSize = true;
            this.PlacarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarJogador.Location = new System.Drawing.Point(6, 62);
            this.PlacarJogador.Name = "PlacarJogador";
            this.PlacarJogador.Size = new System.Drawing.Size(51, 55);
            this.PlacarJogador.TabIndex = 2;
            this.PlacarJogador.Text = "0";
            // 
            // PlacarCPU
            // 
            this.PlacarCPU.AutoSize = true;
            this.PlacarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarCPU.Location = new System.Drawing.Point(107, 62);
            this.PlacarCPU.Name = "PlacarCPU";
            this.PlacarCPU.Size = new System.Drawing.Size(51, 55);
            this.PlacarCPU.TabIndex = 3;
            this.PlacarCPU.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 441);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpô";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JogadaCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinhaJogada)).EndInit();
            this.groupPlacar.ResumeLayout(false);
            this.groupPlacar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox JogadaCPU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox MinhaJogada;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.GroupBox groupPlacar;
        private System.Windows.Forms.Label PlacarCPU;
        private System.Windows.Forms.Label PlacarJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

