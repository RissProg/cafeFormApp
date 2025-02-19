namespace cafeFormApp
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
            panel1 = new Panel();
            label3 = new Label();
            moneyLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            OdemeButton = new Button();
            sepetListBox = new ListBox();
            label2 = new Label();
            lattePictureBox = new PictureBox();
            cookiePictureBox = new PictureBox();
            mochaPictureBox = new PictureBox();
            cakePictureBox = new PictureBox();
            americanoPictureBox = new PictureBox();
            sandwichPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lattePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cookiePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mochaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cakePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)americanoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sandwichPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(moneyLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 252);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGoldenrod;
            label3.Location = new Point(0, 222);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 3;
            label3.Text = "Bakiye";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // moneyLabel
            // 
            moneyLabel.Dock = DockStyle.Bottom;
            moneyLabel.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            moneyLabel.ForeColor = Color.DarkGoldenrod;
            moneyLabel.Location = new Point(0, 237);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(125, 15);
            moneyLabel.TabIndex = 2;
            moneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(0, 73);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Kahve Diyari";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Resource1.cafeicon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(OdemeButton);
            panel2.Controls.Add(sepetListBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(559, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 252);
            panel2.TabIndex = 1;
            // 
            // OdemeButton
            // 
            OdemeButton.BackColor = Color.LightGray;
            OdemeButton.Dock = DockStyle.Fill;
            OdemeButton.FlatAppearance.BorderSize = 0;
            OdemeButton.FlatStyle = FlatStyle.Flat;
            OdemeButton.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OdemeButton.ForeColor = Color.DarkGoldenrod;
            OdemeButton.Location = new Point(0, 197);
            OdemeButton.Name = "OdemeButton";
            OdemeButton.Size = new Size(125, 55);
            OdemeButton.TabIndex = 2;
            OdemeButton.Text = "Odeme Yap";
            OdemeButton.UseVisualStyleBackColor = false;
            OdemeButton.Click += OdemeButton_Click;
            // 
            // sepetListBox
            // 
            sepetListBox.BackColor = Color.LightGray;
            sepetListBox.BorderStyle = BorderStyle.None;
            sepetListBox.Dock = DockStyle.Top;
            sepetListBox.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sepetListBox.ForeColor = Color.DarkGoldenrod;
            sepetListBox.FormattingEnabled = true;
            sepetListBox.ItemHeight = 14;
            sepetListBox.Location = new Point(0, 15);
            sepetListBox.Name = "sepetListBox";
            sepetListBox.Size = new Size(125, 182);
            sepetListBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 0;
            label2.Text = "Sepet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lattePictureBox
            // 
            lattePictureBox.Cursor = Cursors.Hand;
            lattePictureBox.Image = Resource1.Cafe_Latte_PNG_Image;
            lattePictureBox.Location = new Point(131, 15);
            lattePictureBox.Name = "lattePictureBox";
            lattePictureBox.Size = new Size(150, 75);
            lattePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            lattePictureBox.TabIndex = 2;
            lattePictureBox.TabStop = false;
            lattePictureBox.Click += lattePictureBox_Click;
            // 
            // cookiePictureBox
            // 
            cookiePictureBox.Cursor = Cursors.Hand;
            cookiePictureBox.Image = Resource1.cookie;
            cookiePictureBox.Location = new Point(378, 12);
            cookiePictureBox.Name = "cookiePictureBox";
            cookiePictureBox.Size = new Size(150, 75);
            cookiePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cookiePictureBox.TabIndex = 3;
            cookiePictureBox.TabStop = false;
            cookiePictureBox.Click += cookiePictureBox_Click;
            // 
            // mochaPictureBox
            // 
            mochaPictureBox.Cursor = Cursors.Hand;
            mochaPictureBox.Image = Resource1.mocha;
            mochaPictureBox.Location = new Point(131, 96);
            mochaPictureBox.Name = "mochaPictureBox";
            mochaPictureBox.Size = new Size(150, 75);
            mochaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mochaPictureBox.TabIndex = 4;
            mochaPictureBox.TabStop = false;
            mochaPictureBox.Click += mochaPictureBox_Click;
            // 
            // cakePictureBox
            // 
            cakePictureBox.Cursor = Cursors.Hand;
            cakePictureBox.Image = Resource1.cake;
            cakePictureBox.Location = new Point(378, 96);
            cakePictureBox.Name = "cakePictureBox";
            cakePictureBox.Size = new Size(150, 75);
            cakePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cakePictureBox.TabIndex = 5;
            cakePictureBox.TabStop = false;
            cakePictureBox.Click += cakePictureBox_Click;
            // 
            // americanoPictureBox
            // 
            americanoPictureBox.Cursor = Cursors.Hand;
            americanoPictureBox.Image = Resource1.americano;
            americanoPictureBox.Location = new Point(131, 177);
            americanoPictureBox.Name = "americanoPictureBox";
            americanoPictureBox.Size = new Size(150, 75);
            americanoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            americanoPictureBox.TabIndex = 6;
            americanoPictureBox.TabStop = false;
            americanoPictureBox.Click += americanoPictureBox_Click;
            // 
            // sandwichPictureBox
            // 
            sandwichPictureBox.Cursor = Cursors.Hand;
            sandwichPictureBox.Image = Resource1.sandwich;
            sandwichPictureBox.Location = new Point(378, 177);
            sandwichPictureBox.Name = "sandwichPictureBox";
            sandwichPictureBox.Size = new Size(150, 75);
            sandwichPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            sandwichPictureBox.TabIndex = 7;
            sandwichPictureBox.TabStop = false;
            sandwichPictureBox.Click += sandwichPictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(684, 252);
            Controls.Add(sandwichPictureBox);
            Controls.Add(americanoPictureBox);
            Controls.Add(cakePictureBox);
            Controls.Add(mochaPictureBox);
            Controls.Add(cookiePictureBox);
            Controls.Add(lattePictureBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kahve Diyari";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lattePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cookiePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mochaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cakePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)americanoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)sandwichPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label moneyLabel;
        private Label label1;
        private ListBox sepetListBox;
        private Label label2;
        private PictureBox lattePictureBox;
        private PictureBox cookiePictureBox;
        private PictureBox mochaPictureBox;
        private PictureBox cakePictureBox;
        private PictureBox americanoPictureBox;
        private PictureBox sandwichPictureBox;
        private Button OdemeButton;
        private Label label3;
    }
}
