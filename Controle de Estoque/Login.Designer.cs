namespace Controle_de_Estoque
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_usaurio = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pgb_login = new System.Windows.Forms.ProgressBar();
            this.tmr_login = new System.Windows.Forms.Timer(this.components);
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_usaurio
            // 
            this.lbl_usaurio.AutoSize = true;
            this.lbl_usaurio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usaurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usaurio.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_usaurio.Location = new System.Drawing.Point(118, 33);
            this.lbl_usaurio.Name = "lbl_usaurio";
            this.lbl_usaurio.Size = new System.Drawing.Size(62, 16);
            this.lbl_usaurio.TabIndex = 2;
            this.lbl_usaurio.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(121, 49);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(152, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_senha.Location = new System.Drawing.Point(118, 75);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(52, 16);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(158, 120);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pgb_login
            // 
            this.pgb_login.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.pgb_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pgb_login.ForeColor = System.Drawing.Color.Transparent;
            this.pgb_login.Location = new System.Drawing.Point(-3, 240);
            this.pgb_login.MarqueeAnimationSpeed = 60;
            this.pgb_login.Name = "pgb_login";
            this.pgb_login.Size = new System.Drawing.Size(292, 20);
            this.pgb_login.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_login.TabIndex = 8;
            this.pgb_login.Visible = false;
            this.pgb_login.Click += new System.EventHandler(this.pgb_login_Click);
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(121, 94);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(152, 20);
            this.mtb_senha.TabIndex = 2;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(285, 245);
            this.Controls.Add(this.mtb_senha);
            this.Controls.Add(this.pgb_login);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usaurio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 284);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(301, 284);
            this.Name = "frm_login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project K - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_usaurio;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer tmr_login;
        private System.Windows.Forms.ProgressBar pgb_login;
        private System.Windows.Forms.MaskedTextBox mtb_senha;
    }
}

