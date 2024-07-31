namespace Chat_app
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            PuertoLocal = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            PuertoVisitante = new TextBox();
            button2 = new Button();
            Chat = new TextBox();
            Historial = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(177, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(PuertoLocal);
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 58);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Puerto";
            label2.Click += label2_Click;
            // 
            // PuertoLocal
            // 
            PuertoLocal.Location = new Point(94, 22);
            PuertoLocal.Name = "PuertoLocal";
            PuertoLocal.Size = new Size(100, 23);
            PuertoLocal.TabIndex = 1;
            PuertoLocal.TextChanged += textBox2_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(PuertoVisitante);
            groupBox2.Location = new Point(39, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 60);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitante";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 25);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Puerto";
            label4.Click += label4_Click;
            // 
            // PuertoVisitante
            // 
            PuertoVisitante.Location = new Point(89, 22);
            PuertoVisitante.Name = "PuertoVisitante";
            PuertoVisitante.Size = new Size(100, 23);
            PuertoVisitante.TabIndex = 3;
            PuertoVisitante.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(49, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Empezar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Chat
            // 
            Chat.Location = new Point(258, 382);
            Chat.Name = "Chat";
            Chat.RightToLeft = RightToLeft.Yes;
            Chat.Size = new Size(530, 23);
            Chat.TabIndex = 7;
            Chat.TextChanged += textBox1_TextChanged;
            // 
            // Historial
            // 
            Historial.FormattingEnabled = true;
            Historial.ItemHeight = 15;
            Historial.Location = new Point(258, 18);
            Historial.Name = "Historial";
            Historial.Size = new Size(530, 349);
            Historial.TabIndex = 8;
            Historial.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Historial);
            Controls.Add(Chat);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
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

        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox PuertoLocal;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox PuertoVisitante;
        private Button button2;
        private TextBox Chat;
        private ListBox Historial;
    }
}
