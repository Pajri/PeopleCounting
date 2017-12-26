namespace PeopleCounting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundSubtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerOfGravityDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerOfGravityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grassFireAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVidStop = new System.Windows.Forms.Button();
            this.btnVidPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStopReset = new System.Windows.Forms.Button();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ibxVidGray = new Emgu.CV.UI.ImageBox();
            this.ibxVidRgb = new Emgu.CV.UI.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibxVidGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxVidRgb)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.motionDetectionToolStripMenuItem,
            this.backgroundSubtractionToolStripMenuItem,
            this.centerOfGravityDetectionToolStripMenuItem,
            this.boundBlobToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.videoToolStripMenuItem.Text = "Background";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.startToolStripMenuItem.Text = "Update Background";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // motionDetectionToolStripMenuItem
            // 
            this.motionDetectionToolStripMenuItem.Name = "motionDetectionToolStripMenuItem";
            this.motionDetectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.motionDetectionToolStripMenuItem.Text = "Motion Detection";
            this.motionDetectionToolStripMenuItem.Click += new System.EventHandler(this.motionDetectionToolStripMenuItem_Click);
            // 
            // backgroundSubtractionToolStripMenuItem
            // 
            this.backgroundSubtractionToolStripMenuItem.Name = "backgroundSubtractionToolStripMenuItem";
            this.backgroundSubtractionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.backgroundSubtractionToolStripMenuItem.Text = "Background Subtraction";
            this.backgroundSubtractionToolStripMenuItem.Click += new System.EventHandler(this.backgroundSubtractionToolStripMenuItem_Click);
            // 
            // centerOfGravityDetectionToolStripMenuItem
            // 
            this.centerOfGravityDetectionToolStripMenuItem.Name = "centerOfGravityDetectionToolStripMenuItem";
            this.centerOfGravityDetectionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.centerOfGravityDetectionToolStripMenuItem.Text = "Center of Gravity Detection";
            this.centerOfGravityDetectionToolStripMenuItem.Click += new System.EventHandler(this.centerOfGravityDetectionToolStripMenuItem_Click);
            // 
            // boundBlobToolStripMenuItem
            // 
            this.boundBlobToolStripMenuItem.Name = "boundBlobToolStripMenuItem";
            this.boundBlobToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.boundBlobToolStripMenuItem.Text = "Bound Blob";
            this.boundBlobToolStripMenuItem.Click += new System.EventHandler(this.boundBlobToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerOfGravityToolStripMenuItem,
            this.grassFireAlgorithmToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // centerOfGravityToolStripMenuItem
            // 
            this.centerOfGravityToolStripMenuItem.Name = "centerOfGravityToolStripMenuItem";
            this.centerOfGravityToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.centerOfGravityToolStripMenuItem.Text = "Center of Gravity";
            this.centerOfGravityToolStripMenuItem.Click += new System.EventHandler(this.centerOfGravityToolStripMenuItem_Click);
            // 
            // grassFireAlgorithmToolStripMenuItem
            // 
            this.grassFireAlgorithmToolStripMenuItem.Name = "grassFireAlgorithmToolStripMenuItem";
            this.grassFireAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.grassFireAlgorithmToolStripMenuItem.Text = "Grass Fire Algorithm";
            this.grassFireAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.grassFireAlgorithmToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnVidStop);
            this.groupBox1.Controls.Add(this.btnVidPlay);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VideoControl";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PeopleCounting.Properties.Resources.pause_enabled;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(103, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 37);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnVidStop
            // 
            this.btnVidStop.BackgroundImage = global::PeopleCounting.Properties.Resources.stop_enabled;
            this.btnVidStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVidStop.Location = new System.Drawing.Point(55, 20);
            this.btnVidStop.Name = "btnVidStop";
            this.btnVidStop.Size = new System.Drawing.Size(42, 37);
            this.btnVidStop.TabIndex = 1;
            this.btnVidStop.UseVisualStyleBackColor = true;
            // 
            // btnVidPlay
            // 
            this.btnVidPlay.BackgroundImage = global::PeopleCounting.Properties.Resources.play_enabled;
            this.btnVidPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVidPlay.Location = new System.Drawing.Point(7, 20);
            this.btnVidPlay.Name = "btnVidPlay";
            this.btnVidPlay.Size = new System.Drawing.Size(42, 37);
            this.btnVidPlay.TabIndex = 0;
            this.btnVidPlay.UseVisualStyleBackColor = true;
            this.btnVidPlay.Click += new System.EventHandler(this.btnVidPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCountPause);
            this.groupBox2.Controls.Add(this.btnCountStopReset);
            this.groupBox2.Controls.Add(this.btnCountStart);
            this.groupBox2.Location = new System.Drawing.Point(172, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CountingControl";
            // 
            // btnCountPause
            // 
            this.btnCountPause.BackgroundImage = global::PeopleCounting.Properties.Resources.pause_enabled;
            this.btnCountPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCountPause.Location = new System.Drawing.Point(103, 20);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(42, 37);
            this.btnCountPause.TabIndex = 2;
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStopReset
            // 
            this.btnCountStopReset.BackgroundImage = global::PeopleCounting.Properties.Resources.stop_enabled;
            this.btnCountStopReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCountStopReset.Location = new System.Drawing.Point(55, 20);
            this.btnCountStopReset.Name = "btnCountStopReset";
            this.btnCountStopReset.Size = new System.Drawing.Size(42, 37);
            this.btnCountStopReset.TabIndex = 1;
            this.btnCountStopReset.UseVisualStyleBackColor = true;
            this.btnCountStopReset.Click += new System.EventHandler(this.btnCountStopReset_Click);
            // 
            // btnCountStart
            // 
            this.btnCountStart.BackgroundImage = global::PeopleCounting.Properties.Resources.play_enabled;
            this.btnCountStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCountStart.Location = new System.Drawing.Point(7, 20);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(42, 37);
            this.btnCountStart.TabIndex = 0;
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 119);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtInfo.Size = new System.Drawing.Size(968, 34);
            this.txtInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Info";
            // 
            // ibxVidGray
            // 
            this.ibxVidGray.Location = new System.Drawing.Point(498, 159);
            this.ibxVidGray.Name = "ibxVidGray";
            this.ibxVidGray.Size = new System.Drawing.Size(480, 480);
            this.ibxVidGray.TabIndex = 2;
            this.ibxVidGray.TabStop = false;
            // 
            // ibxVidRgb
            // 
            this.ibxVidRgb.Location = new System.Drawing.Point(12, 159);
            this.ibxVidRgb.Name = "ibxVidRgb";
            this.ibxVidRgb.Size = new System.Drawing.Size(480, 480);
            this.ibxVidRgb.TabIndex = 2;
            this.ibxVidRgb.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIn);
            this.groupBox3.Location = new System.Drawing.Point(346, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(59, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "In";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(6, 20);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(31, 36);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOut);
            this.groupBox4.Location = new System.Drawing.Point(411, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(59, 68);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Out";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(6, 20);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(31, 36);
            this.lblOut.TabIndex = 0;
            this.lblOut.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 629);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.ibxVidGray);
            this.Controls.Add(this.ibxVidRgb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "People Counting Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibxVidGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibxVidRgb)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVidPlay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVidStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Button btnCountStopReset;
        private System.Windows.Forms.Button btnCountStart;
        private Emgu.CV.UI.ImageBox ibxVidRgb;
        private Emgu.CV.UI.ImageBox ibxVidGray;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem motionDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundSubtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerOfGravityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerOfGravityDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grassFireAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundBlobToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblOut;
    }
}

