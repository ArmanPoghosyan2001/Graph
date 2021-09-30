
namespace Graph
{
    partial class Graphs
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
            this.sineBox = new System.Windows.Forms.PictureBox();
            this.cosineBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sineBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosineBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sineBox
            // 
            this.sineBox.Location = new System.Drawing.Point(12, 12);
            this.sineBox.Name = "sineBox";
            this.sineBox.Size = new System.Drawing.Size(691, 244);
            this.sineBox.TabIndex = 3;
            this.sineBox.TabStop = false;
            this.sineBox.Paint += new System.Windows.Forms.PaintEventHandler(this.sineBox_Paint);
            // 
            // cosineBox
            // 
            this.cosineBox.Location = new System.Drawing.Point(12, 278);
            this.cosineBox.Name = "cosineBox";
            this.cosineBox.Size = new System.Drawing.Size(691, 306);
            this.cosineBox.TabIndex = 3;
            this.cosineBox.TabStop = false;
            this.cosineBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cosineBox_Paint);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(818, 42);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(93, 27);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 596);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.cosineBox);
            this.Controls.Add(this.sineBox);
            this.Name = "Graphs";
            this.Text = "Sine/Cosine graphs";
            ((System.ComponentModel.ISupportInitialize)(this.sineBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosineBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sineBox;
        private System.Windows.Forms.PictureBox cosineBox;
        private System.Windows.Forms.Button drawButton;
    }
}

