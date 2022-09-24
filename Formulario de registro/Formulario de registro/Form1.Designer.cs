
namespace Formulario_de_registro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lid = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.ldui = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textdui = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lsalario = new System.Windows.Forms.Label();
            this.textsalario = new System.Windows.Forms.TextBox();
            this.textafp = new System.Windows.Forms.TextBox();
            this.AFP = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ISSS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Location = new System.Drawing.Point(52, 44);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(21, 13);
            this.lid.TabIndex = 0;
            this.lid.Text = "ID:";
            this.lid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(52, 86);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(47, 13);
            this.lname.TabIndex = 1;
            this.lname.Text = "Nombre:";
            // 
            // ldui
            // 
            this.ldui.AutoSize = true;
            this.ldui.Location = new System.Drawing.Point(52, 128);
            this.ldui.Name = "ldui";
            this.ldui.Size = new System.Drawing.Size(29, 13);
            this.ldui.TabIndex = 2;
            this.ldui.Text = "DUI:";
            this.ldui.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(131, 41);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 3;
            this.textid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(131, 83);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 4;
            // 
            // textdui
            // 
            this.textdui.Location = new System.Drawing.Point(131, 125);
            this.textdui.Name = "textdui";
            this.textdui.Size = new System.Drawing.Size(100, 20);
            this.textdui.TabIndex = 5;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(55, 254);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 6;
            this.btguardar.Text = "Save!";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lsalario
            // 
            this.lsalario.AutoSize = true;
            this.lsalario.Location = new System.Drawing.Point(52, 178);
            this.lsalario.Name = "lsalario";
            this.lsalario.Size = new System.Drawing.Size(39, 13);
            this.lsalario.TabIndex = 8;
            this.lsalario.Text = "Salario";
            this.lsalario.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textsalario
            // 
            this.textsalario.Location = new System.Drawing.Point(131, 175);
            this.textsalario.Name = "textsalario";
            this.textsalario.Size = new System.Drawing.Size(100, 20);
            this.textsalario.TabIndex = 9;
            this.textsalario.TextChanged += new System.EventHandler(this.textsalario_TextChanged);
            // 
            // textafp
            // 
            this.textafp.Location = new System.Drawing.Point(389, 41);
            this.textafp.Name = "textafp";
            this.textafp.Size = new System.Drawing.Size(100, 20);
            this.textafp.TabIndex = 11;
            this.textafp.TextChanged += new System.EventHandler(this.textafp_TextChanged);
            // 
            // AFP
            // 
            this.AFP.Location = new System.Drawing.Point(291, 39);
            this.AFP.Name = "AFP";
            this.AFP.Size = new System.Drawing.Size(75, 23);
            this.AFP.TabIndex = 12;
            this.AFP.Text = "AFP";
            this.AFP.UseVisualStyleBackColor = true;
            this.AFP.Click += new System.EventHandler(this.btafp_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(379, 313);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 13;
            this.labelRegistro.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 14;
            this.button1.Text = "ISSS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ISSS
            // 
            this.ISSS.Location = new System.Drawing.Point(291, 83);
            this.ISSS.Name = "ISSS";
            this.ISSS.Size = new System.Drawing.Size(75, 23);
            this.ISSS.TabIndex = 15;
            this.ISSS.Text = "ISSS";
            this.ISSS.UseVisualStyleBackColor = true;
            this.ISSS.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Salario Neto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ISSS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.textafp);
            this.Controls.Add(this.textsalario);
            this.Controls.Add(this.lsalario);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.textdui);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.ldui);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label ldui;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textdui;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lsalario;
        private System.Windows.Forms.TextBox textafp;
        private System.Windows.Forms.TextBox textsalario;
        private System.Windows.Forms.Button AFP;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ISSS;
        private System.Windows.Forms.Button button1;
    }
}

