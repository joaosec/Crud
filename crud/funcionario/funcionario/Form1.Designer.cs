 namespace funcionario
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
            Nome = new Label();
            Email = new Label();
            Cpf = new Label();
            Ender = new Label();
            EnderecoTxt = new TextBox();
            EmailTxt = new TextBox();
            NomeTxt = new TextBox();
            CpfTxt = new TextBox();
            BtnCad = new Button();
            btnPesquisar = new Button();
            FuncionarioId = new Label();
            LblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            BtnDeletar = new Button();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome.Location = new Point(37, 100);
            Nome.Margin = new Padding(2, 0, 2, 0);
            Nome.Name = "Nome";
            Nome.Size = new Size(168, 17);
            Nome.TabIndex = 0;
            Nome.Text = "Nome do Funcionário:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Arial Rounded MT Bold", 9F);
            Email.Location = new Point(37, 141);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(53, 17);
            Email.TabIndex = 1;
            Email.Text = "Email:";
            // 
            // Cpf
            // 
            Cpf.AutoSize = true;
            Cpf.Font = new Font("Arial Rounded MT Bold", 9F);
            Cpf.Location = new Point(37, 187);
            Cpf.Margin = new Padding(2, 0, 2, 0);
            Cpf.Name = "Cpf";
            Cpf.Size = new Size(38, 17);
            Cpf.TabIndex = 2;
            Cpf.Text = "Cpf:";
            // 
            // Ender
            // 
            Ender.AutoSize = true;
            Ender.Font = new Font("Arial Rounded MT Bold", 9F);
            Ender.Location = new Point(37, 232);
            Ender.Margin = new Padding(2, 0, 2, 0);
            Ender.Name = "Ender";
            Ender.Size = new Size(84, 17);
            Ender.TabIndex = 3;
            Ender.Text = "Endereço:";
            // 
            // EnderecoTxt
            // 
            EnderecoTxt.Location = new Point(221, 225);
            EnderecoTxt.MaxLength = 200;
            EnderecoTxt.Name = "EnderecoTxt";
            EnderecoTxt.Size = new Size(252, 27);
            EnderecoTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(221, 141);
            EmailTxt.MaxLength = 200;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(252, 27);
            EmailTxt.TabIndex = 2;
            // 
            // NomeTxt
            // 
            NomeTxt.Location = new Point(221, 100);
            NomeTxt.MaxLength = 200;
            NomeTxt.Name = "NomeTxt";
            NomeTxt.Size = new Size(252, 27);
            NomeTxt.TabIndex = 1;
            // 
            // CpfTxt
            // 
            CpfTxt.Location = new Point(221, 180);
            CpfTxt.MaxLength = 11;
            CpfTxt.Name = "CpfTxt";
            CpfTxt.Size = new Size(252, 27);
            CpfTxt.TabIndex = 3;
            // 
            // BtnCad
            // 
            BtnCad.Location = new Point(37, 325);
            BtnCad.Name = "BtnCad";
            BtnCad.Size = new Size(99, 31);
            BtnCad.TabIndex = 5;
            BtnCad.Text = "Cadastrar";
            BtnCad.UseVisualStyleBackColor = true;
            BtnCad.Click += BtnCad_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(177, 325);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 31);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // FuncionarioId
            // 
            FuncionarioId.AutoSize = true;
            FuncionarioId.Location = new Point(37, 43);
            FuncionarioId.Name = "FuncionarioId";
            FuncionarioId.Size = new Size(106, 20);
            FuncionarioId.TabIndex = 7;
            FuncionarioId.Text = "Funcionário Id:";
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(149, 43);
            LblId.Name = "LblId";
            LblId.Size = new Size(0, 20);
            LblId.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(445, 43);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 31);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(317, 325);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(99, 31);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.Location = new Point(445, 325);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(99, 31);
            BtnDeletar.TabIndex = 11;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.UseVisualStyleBackColor = true;
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 464);
            Controls.Add(BtnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(LblId);
            Controls.Add(FuncionarioId);
            Controls.Add(btnPesquisar);
            Controls.Add(BtnCad);
            Controls.Add(CpfTxt);
            Controls.Add(NomeTxt);
            Controls.Add(EmailTxt);
            Controls.Add(EnderecoTxt);
            Controls.Add(Ender);
            Controls.Add(Cpf);
            Controls.Add(Email);
            Controls.Add(Nome);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = " Funcionários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Email;
        private Label Cpf;
        private Label Ender;
        private TextBox EnderecoTxt;
        private TextBox EmailTxt;
        private TextBox NomeTxt;
        private TextBox CpfTxt;
        private Button BtnCad;
        private Button btnPesquisar;
        private Label FuncionarioId;
        private Label LblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button BtnDeletar;
    }
}
