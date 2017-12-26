namespace PeopleCounting
{
    partial class GrassFire
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
            this.ibxGrassFire = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibxGrassFire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grass Fire Algorithm";
            // 
            // ibxGrassFire
            // 
            this.ibxGrassFire.Location = new System.Drawing.Point(17, 50);
            this.ibxGrassFire.Name = "ibxGrassFire";
            this.ibxGrassFire.Size = new System.Drawing.Size(480, 480);
            this.ibxGrassFire.TabIndex = 3;
            this.ibxGrassFire.TabStop = false;
            // 
            // GrassFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 541);
            this.Controls.Add(this.ibxGrassFire);
            this.Controls.Add(this.label1);
            this.Name = "GrassFire";
            this.Text = "GrassFire";
            ((System.ComponentModel.ISupportInitialize)(this.ibxGrassFire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox ibxGrassFire;
    }
}