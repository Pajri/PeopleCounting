namespace PeopleCounting
{
    partial class CenterOfGravity
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
            this.label1 = new System.Windows.Forms.Label();
            this.ibxGravityCenter = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibxGravityCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center of Graavity Detection";
            // 
            // ibxGravityCenter
            // 
            this.ibxGravityCenter.Location = new System.Drawing.Point(18, 42);
            this.ibxGravityCenter.Name = "ibxGravityCenter";
            this.ibxGravityCenter.Size = new System.Drawing.Size(480, 480);
            this.ibxGravityCenter.TabIndex = 2;
            this.ibxGravityCenter.TabStop = false;
            // 
            // CenterOfGravity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 541);
            this.Controls.Add(this.ibxGravityCenter);
            this.Controls.Add(this.label1);
            this.Name = "CenterOfGravity";
            this.Text = "CenterOfGravity";
            ((System.ComponentModel.ISupportInitialize)(this.ibxGravityCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox ibxGravityCenter;
    }
}