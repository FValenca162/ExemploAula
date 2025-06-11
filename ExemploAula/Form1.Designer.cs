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
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllogin.Location = new Point(223, 54);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(120, 47);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(87, 161);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(108, 37);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(87, 211);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(89, 37);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(235, 175);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(168, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(235, 226);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(168, 23);
            txtsenha.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(235, 317);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(148, 51);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 577);
            Controls.Add(btnlogin);
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
        private Button btnlogin;
    }
}
