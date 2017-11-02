namespace MergePDFUI
{
    partial class FormMain
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
            this.uxHeadingLabel = new System.Windows.Forms.Label();
            this.uxOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.uxOutputFileLabel = new System.Windows.Forms.Label();
            this.uxFileslistBox = new System.Windows.Forms.ListBox();
            this.uxSelectFilesButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxMoveUpButton = new System.Windows.Forms.Button();
            this.uxMoveDownButton = new System.Windows.Forms.Button();
            this.uxMergePdfButton = new System.Windows.Forms.Button();
            this.uxOutputFileButton = new System.Windows.Forms.Button();
            this.uxInstructionsLabel = new System.Windows.Forms.Label();
            this.uxRemoveButton = new System.Windows.Forms.Button();
            this.uxRemoveAllButton = new System.Windows.Forms.Button();
            this.uxResultTextBox = new System.Windows.Forms.TextBox();
            this.uxInputFilesLabel = new System.Windows.Forms.Label();
            this.uxResultLabel = new System.Windows.Forms.Label();
            this.uxProjectLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // uxHeadingLabel
            // 
            this.uxHeadingLabel.AutoSize = true;
            this.uxHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHeadingLabel.Location = new System.Drawing.Point(291, 22);
            this.uxHeadingLabel.Name = "uxHeadingLabel";
            this.uxHeadingLabel.Size = new System.Drawing.Size(151, 26);
            this.uxHeadingLabel.TabIndex = 0;
            this.uxHeadingLabel.Text = "Merge PDF UI";
            // 
            // uxOutputFileTextBox
            // 
            this.uxOutputFileTextBox.Location = new System.Drawing.Point(119, 59);
            this.uxOutputFileTextBox.Name = "uxOutputFileTextBox";
            this.uxOutputFileTextBox.ReadOnly = true;
            this.uxOutputFileTextBox.Size = new System.Drawing.Size(487, 20);
            this.uxOutputFileTextBox.TabIndex = 1;
            // 
            // uxOutputFileLabel
            // 
            this.uxOutputFileLabel.AutoSize = true;
            this.uxOutputFileLabel.Location = new System.Drawing.Point(25, 62);
            this.uxOutputFileLabel.Name = "uxOutputFileLabel";
            this.uxOutputFileLabel.Size = new System.Drawing.Size(89, 13);
            this.uxOutputFileLabel.TabIndex = 2;
            this.uxOutputFileLabel.Text = "Output File Name";
            // 
            // uxFileslistBox
            // 
            this.uxFileslistBox.FormattingEnabled = true;
            this.uxFileslistBox.Location = new System.Drawing.Point(119, 104);
            this.uxFileslistBox.Name = "uxFileslistBox";
            this.uxFileslistBox.Size = new System.Drawing.Size(487, 277);
            this.uxFileslistBox.TabIndex = 3;
            // 
            // uxSelectFilesButton
            // 
            this.uxSelectFilesButton.Location = new System.Drawing.Point(612, 104);
            this.uxSelectFilesButton.Name = "uxSelectFilesButton";
            this.uxSelectFilesButton.Size = new System.Drawing.Size(75, 23);
            this.uxSelectFilesButton.TabIndex = 4;
            this.uxSelectFilesButton.Text = "Select Files";
            this.uxSelectFilesButton.UseVisualStyleBackColor = true;
            this.uxSelectFilesButton.Click += new System.EventHandler(this.uxSelectFilesButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pdf";
            this.openFileDialog.Filter = "Pdf Documents|*.pdf";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select files to merge";
            // 
            // uxMoveUpButton
            // 
            this.uxMoveUpButton.Location = new System.Drawing.Point(612, 146);
            this.uxMoveUpButton.Name = "uxMoveUpButton";
            this.uxMoveUpButton.Size = new System.Drawing.Size(75, 23);
            this.uxMoveUpButton.TabIndex = 5;
            this.uxMoveUpButton.Text = "Move Up";
            this.uxMoveUpButton.UseVisualStyleBackColor = true;
            this.uxMoveUpButton.Click += new System.EventHandler(this.uxMoveUpButton_Click);
            // 
            // uxMoveDownButton
            // 
            this.uxMoveDownButton.Location = new System.Drawing.Point(612, 176);
            this.uxMoveDownButton.Name = "uxMoveDownButton";
            this.uxMoveDownButton.Size = new System.Drawing.Size(75, 23);
            this.uxMoveDownButton.TabIndex = 6;
            this.uxMoveDownButton.Text = "Move Down";
            this.uxMoveDownButton.UseVisualStyleBackColor = true;
            this.uxMoveDownButton.Click += new System.EventHandler(this.uxMoveDownButton_Click);
            // 
            // uxMergePdfButton
            // 
            this.uxMergePdfButton.Location = new System.Drawing.Point(119, 387);
            this.uxMergePdfButton.Name = "uxMergePdfButton";
            this.uxMergePdfButton.Size = new System.Drawing.Size(487, 23);
            this.uxMergePdfButton.TabIndex = 7;
            this.uxMergePdfButton.Text = "Merge Pdf Files";
            this.uxMergePdfButton.UseVisualStyleBackColor = true;
            this.uxMergePdfButton.Click += new System.EventHandler(this.uxMergePdfButton_Click);
            // 
            // uxOutputFileButton
            // 
            this.uxOutputFileButton.Location = new System.Drawing.Point(612, 58);
            this.uxOutputFileButton.Name = "uxOutputFileButton";
            this.uxOutputFileButton.Size = new System.Drawing.Size(75, 23);
            this.uxOutputFileButton.TabIndex = 8;
            this.uxOutputFileButton.Text = "Select File";
            this.uxOutputFileButton.UseVisualStyleBackColor = true;
            this.uxOutputFileButton.Click += new System.EventHandler(this.uxOutputFileButton_Click);
            // 
            // uxInstructionsLabel
            // 
            this.uxInstructionsLabel.AutoSize = true;
            this.uxInstructionsLabel.Location = new System.Drawing.Point(119, 85);
            this.uxInstructionsLabel.Name = "uxInstructionsLabel";
            this.uxInstructionsLabel.Size = new System.Drawing.Size(412, 13);
            this.uxInstructionsLabel.TabIndex = 9;
            this.uxInstructionsLabel.Text = "Select files you want to merge and order them using Move Up and Move Down button";
            // 
            // uxRemoveButton
            // 
            this.uxRemoveButton.Location = new System.Drawing.Point(612, 205);
            this.uxRemoveButton.Name = "uxRemoveButton";
            this.uxRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.uxRemoveButton.TabIndex = 11;
            this.uxRemoveButton.Text = "Remove";
            this.uxRemoveButton.UseVisualStyleBackColor = true;
            this.uxRemoveButton.Click += new System.EventHandler(this.uxRemoveButton_Click);
            // 
            // uxRemoveAllButton
            // 
            this.uxRemoveAllButton.Location = new System.Drawing.Point(612, 234);
            this.uxRemoveAllButton.Name = "uxRemoveAllButton";
            this.uxRemoveAllButton.Size = new System.Drawing.Size(75, 23);
            this.uxRemoveAllButton.TabIndex = 12;
            this.uxRemoveAllButton.Text = "Remove All";
            this.uxRemoveAllButton.UseVisualStyleBackColor = true;
            this.uxRemoveAllButton.Click += new System.EventHandler(this.uxRemoveAllButton_Click);
            // 
            // uxResultTextBox
            // 
            this.uxResultTextBox.Location = new System.Drawing.Point(122, 417);
            this.uxResultTextBox.Multiline = true;
            this.uxResultTextBox.Name = "uxResultTextBox";
            this.uxResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResultTextBox.Size = new System.Drawing.Size(484, 87);
            this.uxResultTextBox.TabIndex = 13;
            // 
            // uxInputFilesLabel
            // 
            this.uxInputFilesLabel.AutoSize = true;
            this.uxInputFilesLabel.Location = new System.Drawing.Point(25, 104);
            this.uxInputFilesLabel.Name = "uxInputFilesLabel";
            this.uxInputFilesLabel.Size = new System.Drawing.Size(86, 13);
            this.uxInputFilesLabel.TabIndex = 14;
            this.uxInputFilesLabel.Text = "Input File Names";
            // 
            // uxResultLabel
            // 
            this.uxResultLabel.AutoSize = true;
            this.uxResultLabel.Location = new System.Drawing.Point(25, 417);
            this.uxResultLabel.Name = "uxResultLabel";
            this.uxResultLabel.Size = new System.Drawing.Size(93, 13);
            this.uxResultLabel.TabIndex = 15;
            this.uxResultLabel.Text = "MergePDF Output";
            // 
            // uxProjectLinkLabel
            // 
            this.uxProjectLinkLabel.AutoSize = true;
            this.uxProjectLinkLabel.Location = new System.Drawing.Point(612, 275);
            this.uxProjectLinkLabel.Name = "uxProjectLinkLabel";
            this.uxProjectLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.uxProjectLinkLabel.TabIndex = 16;
            this.uxProjectLinkLabel.TabStop = true;
            this.uxProjectLinkLabel.Text = "More Info";
            this.uxProjectLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxProjectLinkLabel_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 528);
            this.Controls.Add(this.uxProjectLinkLabel);
            this.Controls.Add(this.uxResultLabel);
            this.Controls.Add(this.uxInputFilesLabel);
            this.Controls.Add(this.uxResultTextBox);
            this.Controls.Add(this.uxRemoveAllButton);
            this.Controls.Add(this.uxRemoveButton);
            this.Controls.Add(this.uxInstructionsLabel);
            this.Controls.Add(this.uxOutputFileButton);
            this.Controls.Add(this.uxMergePdfButton);
            this.Controls.Add(this.uxMoveDownButton);
            this.Controls.Add(this.uxMoveUpButton);
            this.Controls.Add(this.uxSelectFilesButton);
            this.Controls.Add(this.uxFileslistBox);
            this.Controls.Add(this.uxOutputFileLabel);
            this.Controls.Add(this.uxOutputFileTextBox);
            this.Controls.Add(this.uxHeadingLabel);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Merge PDF UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxHeadingLabel;
        private System.Windows.Forms.TextBox uxOutputFileTextBox;
        private System.Windows.Forms.Label uxOutputFileLabel;
        private System.Windows.Forms.ListBox uxFileslistBox;
        private System.Windows.Forms.Button uxSelectFilesButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button uxMoveUpButton;
        private System.Windows.Forms.Button uxMoveDownButton;
        private System.Windows.Forms.Button uxMergePdfButton;
        private System.Windows.Forms.Button uxOutputFileButton;
        private System.Windows.Forms.Label uxInstructionsLabel;
        private System.Windows.Forms.Button uxRemoveButton;
        private System.Windows.Forms.Button uxRemoveAllButton;
        private System.Windows.Forms.TextBox uxResultTextBox;
        private System.Windows.Forms.Label uxInputFilesLabel;
        private System.Windows.Forms.Label uxResultLabel;
        private System.Windows.Forms.LinkLabel uxProjectLinkLabel;
    }
}

