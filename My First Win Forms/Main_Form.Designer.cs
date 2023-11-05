namespace My_First_Win_Forms
{
    partial class Form2
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
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnShowMessageForm = new System.Windows.Forms.Button();
            this.btnShowGroupForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(35, 43);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(155, 72);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Part1";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(35, 164);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(155, 72);
            this.btnShowDialog.TabIndex = 1;
            this.btnShowDialog.Text = "Show Form as Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnShowMessageForm
            // 
            this.btnShowMessageForm.Location = new System.Drawing.Point(35, 284);
            this.btnShowMessageForm.Name = "btnShowMessageForm";
            this.btnShowMessageForm.Size = new System.Drawing.Size(155, 72);
            this.btnShowMessageForm.TabIndex = 2;
            this.btnShowMessageForm.Text = "Show Message Form";
            this.btnShowMessageForm.UseVisualStyleBackColor = true;
            this.btnShowMessageForm.Click += new System.EventHandler(this.btnShowMessageForm_Click);
            // 
            // btnShowGroupForm
            // 
            this.btnShowGroupForm.Location = new System.Drawing.Point(35, 411);
            this.btnShowGroupForm.Name = "btnShowGroupForm";
            this.btnShowGroupForm.Size = new System.Drawing.Size(155, 72);
            this.btnShowGroupForm.TabIndex = 3;
            this.btnShowGroupForm.Text = "Show Group Form";
            this.btnShowGroupForm.UseVisualStyleBackColor = true;
            this.btnShowGroupForm.Click += new System.EventHandler(this.btnShowGroupForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 510);
            this.Controls.Add(this.btnShowGroupForm);
            this.Controls.Add(this.btnShowMessageForm);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "Form2";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnShowMessageForm;
        private System.Windows.Forms.Button btnShowGroupForm;
    }
}