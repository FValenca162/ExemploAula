namespace ExemploAula
{
    partial class frmlogin
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
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(216, 67);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(42, 15);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(124, 129);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(47, 15);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(124, 165);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(216, 121);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(216, 157);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 4;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 577);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "frmlogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private TextBox txtusuario;
        private TextBox txtsenha;
    }
}
