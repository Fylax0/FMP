namespace ApinProject
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            tbTimeline = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lbTime = new Label();
            tbVolume1 = new TrackBar();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            playButton = new RoundButton();
            previousTrackButton = new RoundButton();
            nextTrackButton = new RoundButton();
            commonButton1 = new CommonButton();
            commonButton3 = new CommonButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTimeline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbVolume1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(58, 22);
            toolStripButton1.Text = "Открыть";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(106, 22);
            toolStripButton2.Text = "Папка с музыкой";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(107, 22);
            toolStripButton3.Text = "Сброс плейлиста";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // tbTimeline
            // 
            tbTimeline.Location = new Point(12, 339);
            tbTimeline.Maximum = 100;
            tbTimeline.Name = "tbTimeline";
            tbTimeline.Size = new Size(268, 45);
            tbTimeline.TabIndex = 10;
            tbTimeline.TickStyle = TickStyle.None;
            tbTimeline.Scroll += tbTimeline_Scroll;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbTime.ForeColor = Color.Black;
            lbTime.Location = new Point(12, 364);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(138, 20);
            lbTime.TabIndex = 11;
            lbTime.Text = "00:00:00/00:00:00";
            lbTime.UseCompatibleTextRendering = true;
            // 
            // tbVolume1
            // 
            tbVolume1.Location = new Point(664, 413);
            tbVolume1.Maximum = 100;
            tbVolume1.Name = "tbVolume1";
            tbVolume1.Size = new Size(136, 45);
            tbVolume1.TabIndex = 12;
            tbVolume1.TickStyle = TickStyle.None;
            tbVolume1.Value = 50;
            tbVolume1.Scroll += tbVolume1_Scroll;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Azure;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(12, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 256);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 309);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 14;
            label1.Text = "Название";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.volume;
            pictureBox1.Location = new Point(633, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // playButton
            // 
            playButton.Cursor = Cursors.Hand;
            playButton.Location = new Point(375, 388);
            playButton.Name = "playButton";
            playButton.Size = new Size(50, 50);
            playButton.TabIndex = 16;
            playButton.Click += playButton_Click;
            playButton.DoubleClick += playButton_DoubleClick;
            // 
            // previousTrackButton
            // 
            previousTrackButton.Cursor = Cursors.Hand;
            previousTrackButton.Location = new Point(333, 402);
            previousTrackButton.Name = "previousTrackButton";
            previousTrackButton.Size = new Size(36, 36);
            previousTrackButton.TabIndex = 17;
            previousTrackButton.Click += previousTrackButton_Click;
            // 
            // nextTrackButton
            // 
            nextTrackButton.Cursor = Cursors.Hand;
            nextTrackButton.Font = new Font("Times New Roman", 9F);
            nextTrackButton.Location = new Point(431, 402);
            nextTrackButton.Name = "nextTrackButton";
            nextTrackButton.Size = new Size(36, 36);
            nextTrackButton.TabIndex = 18;
            nextTrackButton.Click += nextTrackButton_Click;
            // 
            // commonButton1
            // 
            commonButton1.Location = new Point(12, 301);
            commonButton1.Name = "commonButton1";
            commonButton1.radius = 6;
            commonButton1.Size = new Size(776, 5);
            commonButton1.TabIndex = 19;
            commonButton1.textOnCover = "";
            commonButton1.textSize = 14;
            // 
            // commonButton3
            // 
            commonButton3.Location = new Point(333, 443);
            commonButton3.Name = "commonButton3";
            commonButton3.radius = 16;
            commonButton3.Size = new Size(134, 15);
            commonButton3.TabIndex = 20;
            commonButton3.textOnCover = "";
            commonButton3.textSize = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(commonButton3);
            Controls.Add(commonButton1);
            Controls.Add(nextTrackButton);
            Controls.Add(previousTrackButton);
            Controls.Add(playButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lbTime);
            Controls.Add(tbVolume1);
            Controls.Add(listBox1);
            Controls.Add(toolStrip1);
            Controls.Add(tbTimeline);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Fylax's Music Player";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTimeline).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbVolume1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private CommonButton commonButton2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private RoundButton playButton;
        private RoundButton previousTrackButton;
        private RoundButton nextTrackButton;
        private TrackBar tbTimeline;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbVolume1;
        private RoundButton btStop;
        private ListBox listBox1;
        public Label lbTime;
        private Label label1;
        private ToolStripButton toolStripButton2;
        private PictureBox pictureBox1;
        private ToolStripButton toolStripButton3;
        private CommonButton commonButton1;
        private CommonButton commonButton3;
    }
}
