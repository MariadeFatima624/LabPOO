namespace wfaFormas
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
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.pbFormas = new System.Windows.Forms.PictureBox();
            this.panelCirculo = new System.Windows.Forms.Panel();
            this.listViewFormas = new System.Windows.Forms.ListView();
            this.labelRaio = new System.Windows.Forms.Label();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.panelRetangulo = new System.Windows.Forms.Panel();
            this.tbBaseR = new System.Windows.Forms.TextBox();
            this.labelBaseR = new System.Windows.Forms.Label();
            this.labelAlturaR = new System.Windows.Forms.Label();
            this.tbAlturaR = new System.Windows.Forms.TextBox();
            this.buttonArea = new System.Windows.Forms.Button();
            this.panelTriangulo = new System.Windows.Forms.Panel();
            this.tbAlturaT = new System.Windows.Forms.TextBox();
            this.labelAlturaT = new System.Windows.Forms.Label();
            this.tbBaseT = new System.Windows.Forms.TextBox();
            this.labelBaseT = new System.Windows.Forms.Label();
            this.panelQuadrado = new System.Windows.Forms.Panel();
            this.tbLadoQ = new System.Windows.Forms.TextBox();
            this.labelLadoQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormas)).BeginInit();
            this.panelCirculo.SuspendLayout();
            this.panelRetangulo.SuspendLayout();
            this.panelTriangulo.SuspendLayout();
            this.panelQuadrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(365, 13);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(59, 17);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.Text = "Círculo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Location = new System.Drawing.Point(365, 64);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rbQuadrado.TabIndex = 1;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            this.rbQuadrado.CheckedChanged += new System.EventHandler(this.rbQuadrado_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Location = new System.Drawing.Point(365, 115);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rbRetangulo.TabIndex = 2;
            this.rbRetangulo.Text = "Retângulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(365, 166);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 3;
            this.rbTriangulo.Text = "Triângulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // pbFormas
            // 
            this.pbFormas.Image = global::wfaFormas.Properties.Resources.triangulo;
            this.pbFormas.Location = new System.Drawing.Point(48, 13);
            this.pbFormas.Name = "pbFormas";
            this.pbFormas.Size = new System.Drawing.Size(282, 172);
            this.pbFormas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormas.TabIndex = 4;
            this.pbFormas.TabStop = false;
            // 
            // panelCirculo
            // 
            this.panelCirculo.Controls.Add(this.tbRaio);
            this.panelCirculo.Controls.Add(this.labelRaio);
            this.panelCirculo.Location = new System.Drawing.Point(48, 216);
            this.panelCirculo.Name = "panelCirculo";
            this.panelCirculo.Size = new System.Drawing.Size(282, 100);
            this.panelCirculo.TabIndex = 5;
            // 
            // listViewFormas
            // 
            this.listViewFormas.HideSelection = false;
            this.listViewFormas.Location = new System.Drawing.Point(48, 333);
            this.listViewFormas.Name = "listViewFormas";
            this.listViewFormas.Size = new System.Drawing.Size(641, 97);
            this.listViewFormas.TabIndex = 7;
            this.listViewFormas.UseCompatibleStateImageBehavior = false;
            // 
            // labelRaio
            // 
            this.labelRaio.AutoSize = true;
            this.labelRaio.Location = new System.Drawing.Point(13, 42);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(32, 13);
            this.labelRaio.TabIndex = 0;
            this.labelRaio.Text = "Raio:";
            // 
            // tbRaio
            // 
            this.tbRaio.Location = new System.Drawing.Point(51, 39);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(205, 20);
            this.tbRaio.TabIndex = 1;
            // 
            // panelRetangulo
            // 
            this.panelRetangulo.Controls.Add(this.tbAlturaR);
            this.panelRetangulo.Controls.Add(this.labelAlturaR);
            this.panelRetangulo.Controls.Add(this.tbBaseR);
            this.panelRetangulo.Controls.Add(this.labelBaseR);
            this.panelRetangulo.Location = new System.Drawing.Point(48, 216);
            this.panelRetangulo.Name = "panelRetangulo";
            this.panelRetangulo.Size = new System.Drawing.Size(282, 100);
            this.panelRetangulo.TabIndex = 7;
            // 
            // tbBaseR
            // 
            this.tbBaseR.Location = new System.Drawing.Point(53, 17);
            this.tbBaseR.Name = "tbBaseR";
            this.tbBaseR.Size = new System.Drawing.Size(205, 20);
            this.tbBaseR.TabIndex = 1;
            // 
            // labelBaseR
            // 
            this.labelBaseR.AutoSize = true;
            this.labelBaseR.Location = new System.Drawing.Point(13, 20);
            this.labelBaseR.Name = "labelBaseR";
            this.labelBaseR.Size = new System.Drawing.Size(34, 13);
            this.labelBaseR.TabIndex = 0;
            this.labelBaseR.Text = "Base:";
            // 
            // labelAlturaR
            // 
            this.labelAlturaR.AutoSize = true;
            this.labelAlturaR.Location = new System.Drawing.Point(13, 62);
            this.labelAlturaR.Name = "labelAlturaR";
            this.labelAlturaR.Size = new System.Drawing.Size(37, 13);
            this.labelAlturaR.TabIndex = 2;
            this.labelAlturaR.Text = "Altura:";
            // 
            // tbAlturaR
            // 
            this.tbAlturaR.Location = new System.Drawing.Point(53, 62);
            this.tbAlturaR.Name = "tbAlturaR";
            this.tbAlturaR.Size = new System.Drawing.Size(205, 20);
            this.tbAlturaR.TabIndex = 3;
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(365, 247);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 8;
            this.buttonArea.Text = "Área";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonArea_MouseClick);
            // 
            // panelTriangulo
            // 
            this.panelTriangulo.Controls.Add(this.tbAlturaT);
            this.panelTriangulo.Controls.Add(this.labelAlturaT);
            this.panelTriangulo.Controls.Add(this.tbBaseT);
            this.panelTriangulo.Controls.Add(this.labelBaseT);
            this.panelTriangulo.Location = new System.Drawing.Point(48, 216);
            this.panelTriangulo.Name = "panelTriangulo";
            this.panelTriangulo.Size = new System.Drawing.Size(282, 100);
            this.panelTriangulo.TabIndex = 8;
            // 
            // tbAlturaT
            // 
            this.tbAlturaT.Location = new System.Drawing.Point(53, 62);
            this.tbAlturaT.Name = "tbAlturaT";
            this.tbAlturaT.Size = new System.Drawing.Size(205, 20);
            this.tbAlturaT.TabIndex = 3;
            // 
            // labelAlturaT
            // 
            this.labelAlturaT.AutoSize = true;
            this.labelAlturaT.Location = new System.Drawing.Point(13, 62);
            this.labelAlturaT.Name = "labelAlturaT";
            this.labelAlturaT.Size = new System.Drawing.Size(37, 13);
            this.labelAlturaT.TabIndex = 2;
            this.labelAlturaT.Text = "Altura:";
            // 
            // tbBaseT
            // 
            this.tbBaseT.Location = new System.Drawing.Point(53, 17);
            this.tbBaseT.Name = "tbBaseT";
            this.tbBaseT.Size = new System.Drawing.Size(205, 20);
            this.tbBaseT.TabIndex = 1;
            // 
            // labelBaseT
            // 
            this.labelBaseT.AutoSize = true;
            this.labelBaseT.Location = new System.Drawing.Point(13, 20);
            this.labelBaseT.Name = "labelBaseT";
            this.labelBaseT.Size = new System.Drawing.Size(34, 13);
            this.labelBaseT.TabIndex = 0;
            this.labelBaseT.Text = "Base:";
            // 
            // panelQuadrado
            // 
            this.panelQuadrado.Controls.Add(this.tbLadoQ);
            this.panelQuadrado.Controls.Add(this.labelLadoQ);
            this.panelQuadrado.Location = new System.Drawing.Point(48, 216);
            this.panelQuadrado.Name = "panelQuadrado";
            this.panelQuadrado.Size = new System.Drawing.Size(282, 100);
            this.panelQuadrado.TabIndex = 6;
            // 
            // tbLadoQ
            // 
            this.tbLadoQ.Location = new System.Drawing.Point(51, 39);
            this.tbLadoQ.Name = "tbLadoQ";
            this.tbLadoQ.Size = new System.Drawing.Size(205, 20);
            this.tbLadoQ.TabIndex = 1;
            // 
            // labelLadoQ
            // 
            this.labelLadoQ.AutoSize = true;
            this.labelLadoQ.Location = new System.Drawing.Point(13, 42);
            this.labelLadoQ.Name = "labelLadoQ";
            this.labelLadoQ.Size = new System.Drawing.Size(34, 13);
            this.labelLadoQ.TabIndex = 0;
            this.labelLadoQ.Text = "Lado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.panelQuadrado);
            this.Controls.Add(this.panelTriangulo);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.panelRetangulo);
            this.Controls.Add(this.listViewFormas);
            this.Controls.Add(this.panelCirculo);
            this.Controls.Add(this.pbFormas);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbQuadrado);
            this.Controls.Add(this.rbCirculo);
            this.Name = "Form1";
            this.Text = "Calcula áreas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFormas)).EndInit();
            this.panelCirculo.ResumeLayout(false);
            this.panelCirculo.PerformLayout();
            this.panelRetangulo.ResumeLayout(false);
            this.panelRetangulo.PerformLayout();
            this.panelTriangulo.ResumeLayout(false);
            this.panelTriangulo.PerformLayout();
            this.panelQuadrado.ResumeLayout(false);
            this.panelQuadrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.PictureBox pbFormas;
        private System.Windows.Forms.Panel panelCirculo;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.Label labelRaio;
        private System.Windows.Forms.ListView listViewFormas;
        private System.Windows.Forms.Panel panelRetangulo;
        private System.Windows.Forms.TextBox tbAlturaR;
        private System.Windows.Forms.Label labelAlturaR;
        private System.Windows.Forms.TextBox tbBaseR;
        private System.Windows.Forms.Label labelBaseR;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Panel panelTriangulo;
        private System.Windows.Forms.TextBox tbAlturaT;
        private System.Windows.Forms.Label labelAlturaT;
        private System.Windows.Forms.TextBox tbBaseT;
        private System.Windows.Forms.Label labelBaseT;
        private System.Windows.Forms.Panel panelQuadrado;
        private System.Windows.Forms.TextBox tbLadoQ;
        private System.Windows.Forms.Label labelLadoQ;
    }
}

