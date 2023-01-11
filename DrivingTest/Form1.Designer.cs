namespace DrivingTest
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
            this.qustionanswers = new System.Windows.Forms.ListBox();
            this.questionLB = new System.Windows.Forms.Label();
            this.answeroutputLB = new System.Windows.Forms.Label();
            this.submitBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qustionanswers
            // 
            this.qustionanswers.FormattingEnabled = true;
            this.qustionanswers.Items.AddRange(new object[] {
            "between 10 and 45 feet",
            "between 15 and 50 feet",
            "between 15 and 20 feet",
            "between 5 and 50 feet"});
            this.qustionanswers.Location = new System.Drawing.Point(12, 34);
            this.qustionanswers.Name = "qustionanswers";
            this.qustionanswers.Size = new System.Drawing.Size(327, 56);
            this.qustionanswers.TabIndex = 0;
            // 
            // questionLB
            // 
            this.questionLB.AutoSize = true;
            this.questionLB.Location = new System.Drawing.Point(13, 15);
            this.questionLB.Name = "questionLB";
            this.questionLB.Size = new System.Drawing.Size(326, 13);
            this.questionLB.TabIndex = 1;
            this.questionLB.Text = "At a railroad crossing, you must stop ____ before the railroad tracks.";
            // 
            // answeroutputLB
            // 
            this.answeroutputLB.AutoSize = true;
            this.answeroutputLB.Location = new System.Drawing.Point(41, 123);
            this.answeroutputLB.Name = "answeroutputLB";
            this.answeroutputLB.Size = new System.Drawing.Size(127, 13);
            this.answeroutputLB.TabIndex = 2;
            this.answeroutputLB.Text = "The correct answer was: ";
            // 
            // submitBUT
            // 
            this.submitBUT.Location = new System.Drawing.Point(27, 97);
            this.submitBUT.Name = "submitBUT";
            this.submitBUT.Size = new System.Drawing.Size(75, 23);
            this.submitBUT.TabIndex = 3;
            this.submitBUT.Text = "Submit";
            this.submitBUT.UseVisualStyleBackColor = true;
            this.submitBUT.Click += new System.EventHandler(this.SubmitBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 198);
            this.Controls.Add(this.submitBUT);
            this.Controls.Add(this.answeroutputLB);
            this.Controls.Add(this.questionLB);
            this.Controls.Add(this.qustionanswers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox qustionanswers;
        private System.Windows.Forms.Label questionLB;
        private System.Windows.Forms.Label answeroutputLB;
        private System.Windows.Forms.Button submitBUT;
    }
}

