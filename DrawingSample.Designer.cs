namespace Painter
{
    partial class DrawingSample
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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(64, 40);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 58);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(64, 40);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(12, 196);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(64, 40);
            this.btnArc.TabIndex = 2;
            this.btnArc.Text = "Arc";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnCurve
            // 
            this.btnCurve.Location = new System.Drawing.Point(12, 242);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(64, 40);
            this.btnCurve.TabIndex = 4;
            this.btnCurve.Text = "Curve";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(12, 104);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(64, 40);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(12, 288);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(64, 40);
            this.btnText.TabIndex = 6;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(12, 334);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(64, 40);
            this.btnImage.TabIndex = 7;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.DrawShape);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Location = new System.Drawing.Point(12, 150);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(64, 40);
            this.btnPolygon.TabIndex = 8;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.DrawShape);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(635, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 25);
            this.lblLocation.TabIndex = 9;
            // 
            // DrawingSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnCurve);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLine);
            this.Name = "DrawingSample";
            this.Text = "DrawingSample";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingSample_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Label lblLocation;
    }
}