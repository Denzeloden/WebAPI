
namespace Password_Generator
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
            this.output = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.listView_options = new System.Windows.Forms.ListView();
            this.Options = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(9, 9);
            this.output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(241, 22);
            this.output.TabIndex = 0;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Generate.Location = new System.Drawing.Point(275, 4);
            this.Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(87, 28);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.generate_button);
            // 
            // listView_options
            // 
            this.listView_options.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Options});
            this.listView_options.HideSelection = false;
            this.listView_options.Location = new System.Drawing.Point(9, 48);
            this.listView_options.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_options.MultiSelect = false;
            this.listView_options.Name = "listView_options";
            this.listView_options.Size = new System.Drawing.Size(241, 84);
            this.listView_options.TabIndex = 2;
            this.listView_options.UseCompatibleStateImageBehavior = false;
            this.listView_options.View = System.Windows.Forms.View.Details;
            // 
            // Options
            // 
            this.Options.Text = "Options";
            // 
            // Select_button
            // 
            this.Select_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Select_button.Location = new System.Drawing.Point(275, 48);
            this.Select_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(87, 28);
            this.Select_button.TabIndex = 3;
            this.Select_button.Text = "Select";
            this.Select_button.UseVisualStyleBackColor = false;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(388, 143);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.listView_options);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.output);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListView listView_options;
        private System.Windows.Forms.ColumnHeader Options;
        private System.Windows.Forms.Button Select_button;
    }
}

