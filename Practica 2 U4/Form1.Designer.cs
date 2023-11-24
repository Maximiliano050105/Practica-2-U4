namespace Practica_2_U4
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPapas = new TextBox();
            txtRefresco = new TextBox();
            txtTe = new TextBox();
            txtSandwich = new TextBox();
            txtHotDog = new TextBox();
            txtHamburguesa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion por pedidos";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 147);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(89, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro Pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 109);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(196, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "No.3 (Sandwich, Refresco, Papas";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(191, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "No.2 (HotDog, Refresco, Papas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(224, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "No.1 (Hamburguesa, Refresco, Papas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtPapas);
            groupBox2.Controls.Add(txtRefresco);
            groupBox2.Controls.Add(txtTe);
            groupBox2.Controls.Add(txtSandwich);
            groupBox2.Controls.Add(txtHotDog);
            groupBox2.Controls.Add(txtHamburguesa);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(301, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alimentos seleccionados";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 368);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 12;
            label8.Text = "Papas fritas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 308);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 11;
            label7.Text = "Refresco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 244);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "Te";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 181);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Sandwich";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 122);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "HotDog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 52);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 7;
            label3.Text = "Hamburguesa";
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(17, 365);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(100, 23);
            txtPapas.TabIndex = 6;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(17, 305);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(100, 23);
            txtRefresco.TabIndex = 5;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(17, 241);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(100, 23);
            txtTe.TabIndex = 4;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(17, 178);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(100, 23);
            txtSandwich.TabIndex = 3;
            // 
            // txtHotDog
            // 
            txtHotDog.Location = new Point(17, 119);
            txtHotDog.Name = "txtHotDog";
            txtHotDog.Size = new Size(100, 23);
            txtHotDog.TabIndex = 2;
            // 
            // txtHamburguesa
            // 
            txtHamburguesa.Location = new Point(17, 49);
            txtHamburguesa.Name = "txtHamburguesa";
            txtHamburguesa.Size = new Size(100, 23);
            txtHamburguesa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 223);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 2;
            label1.Text = "Total a cobrar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(85, 283);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(32, 361);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 361);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(647, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPapas;
        private TextBox txtRefresco;
        private TextBox txtTe;
        private TextBox txtSandwich;
        private TextBox txtHotDog;
        private TextBox txtHamburguesa;
        private Label label2;
        private Label label1;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
