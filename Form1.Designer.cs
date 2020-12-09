namespace DragNDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbGraphic = new System.Windows.Forms.PictureBox();
            this.dragItem1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraphic
            // 
            this.pbGraphic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbGraphic.Location = new System.Drawing.Point(12, 12);
            this.pbGraphic.Name = "pbGraphic";
            this.pbGraphic.Size = new System.Drawing.Size(625, 391);
            this.pbGraphic.TabIndex = 0;
            this.pbGraphic.TabStop = false;
            this.pbGraphic.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbGraphic_DragDrop);
            this.pbGraphic.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbGraphic_DragEnter);
            // 
            // dragItem1
            // 
            this.dragItem1.Image = ((System.Drawing.Image)(resources.GetObject("dragItem1.Image")));
            this.dragItem1.Location = new System.Drawing.Point(646, 12);
            this.dragItem1.Name = "dragItem1";
            this.dragItem1.Size = new System.Drawing.Size(75, 104);
            this.dragItem1.TabIndex = 1;
            this.dragItem1.TabStop = false;
            this.dragItem1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragItem1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 423);
            this.Controls.Add(this.dragItem1);
            this.Controls.Add(this.pbGraphic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphic;
        private System.Windows.Forms.PictureBox dragItem1;
    }
}

