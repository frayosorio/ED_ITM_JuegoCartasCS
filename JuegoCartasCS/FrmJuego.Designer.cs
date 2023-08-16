
namespace JuegoCartasCS
{
    partial class FrmJuego
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
            this.btnRepartir = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.tcJugadores = new System.Windows.Forms.TabControl();
            this.tpJugador1 = new System.Windows.Forms.TabPage();
            this.tpJugador2 = new System.Windows.Forms.TabPage();
            this.tcJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRepartir
            // 
            this.btnRepartir.Location = new System.Drawing.Point(32, 33);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(75, 23);
            this.btnRepartir.TabIndex = 0;
            this.btnRepartir.Text = "Repartir";
            this.btnRepartir.UseVisualStyleBackColor = true;
            this.btnRepartir.Click += new System.EventHandler(this.btnRepartir_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(143, 33);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // tcJugadores
            // 
            this.tcJugadores.Controls.Add(this.tpJugador1);
            this.tcJugadores.Controls.Add(this.tpJugador2);
            this.tcJugadores.Location = new System.Drawing.Point(32, 88);
            this.tcJugadores.Name = "tcJugadores";
            this.tcJugadores.SelectedIndex = 0;
            this.tcJugadores.Size = new System.Drawing.Size(747, 339);
            this.tcJugadores.TabIndex = 2;
            // 
            // tpJugador1
            // 
            this.tpJugador1.Location = new System.Drawing.Point(4, 22);
            this.tpJugador1.Name = "tpJugador1";
            this.tpJugador1.Padding = new System.Windows.Forms.Padding(3);
            this.tpJugador1.Size = new System.Drawing.Size(739, 313);
            this.tpJugador1.TabIndex = 0;
            this.tpJugador1.Text = "Martín Estrada Contreras";
            this.tpJugador1.UseVisualStyleBackColor = true;
            // 
            // tpJugador2
            // 
            this.tpJugador2.Location = new System.Drawing.Point(4, 22);
            this.tpJugador2.Name = "tpJugador2";
            this.tpJugador2.Padding = new System.Windows.Forms.Padding(3);
            this.tpJugador2.Size = new System.Drawing.Size(739, 313);
            this.tpJugador2.TabIndex = 1;
            this.tpJugador2.Text = "Raúl Vidal";
            this.tpJugador2.UseVisualStyleBackColor = true;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcJugadores);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnRepartir);
            this.Name = "FrmJuego";
            this.Text = "Juego  Cartas";
            this.tcJugadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepartir;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TabControl tcJugadores;
        private System.Windows.Forms.TabPage tpJugador1;
        private System.Windows.Forms.TabPage tpJugador2;
    }
}

