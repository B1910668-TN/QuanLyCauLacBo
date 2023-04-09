namespace QuanLyCauLacBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label1 = new Label();
            txtTendangnhap = new TextBox();
            txtMatkhau = new TextBox();
            btnDangnhap = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu";
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.BackColor = Color.White;
            txtTendangnhap.Location = new Point(3, 22);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(168, 27);
            txtTendangnhap.TabIndex = 3;
            txtTendangnhap.TextChanged += txtTendangnhap_TextChanged;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(177, 22);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(168, 27);
            txtMatkhau.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.Transparent;
            btnDangnhap.BackgroundImageLayout = ImageLayout.Center;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = SystemColors.ButtonFace;
            btnDangnhap.Location = new Point(3, 55);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(295, 39);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtTendangnhap);
            flowLayoutPanel1.Controls.Add(txtMatkhau);
            flowLayoutPanel1.Controls.Add(btnDangnhap);
            flowLayoutPanel1.Location = new Point(248, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(367, 168);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(782, 453);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "z";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtTendangnhap;
        private TextBox txtMatkhau;
        private Button btnDangnhap;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}