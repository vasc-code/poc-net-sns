
namespace PocAwsSnsPublisher
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbAndroid = new System.Windows.Forms.CheckBox();
            this.cbIos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.ForeColor = System.Drawing.Color.Orange;
            this.txtInput.Location = new System.Drawing.Point(13, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(361, 72);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Olá como vai, está é uma mensagem de exemplo";
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(13, 139);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(361, 348);
            this.lvItems.TabIndex = 2;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mensagens";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(299, 110);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbAndroid
            // 
            this.cbAndroid.AutoSize = true;
            this.cbAndroid.Location = new System.Drawing.Point(13, 111);
            this.cbAndroid.Name = "cbAndroid";
            this.cbAndroid.Size = new System.Drawing.Size(69, 19);
            this.cbAndroid.TabIndex = 4;
            this.cbAndroid.Text = "Android";
            this.cbAndroid.UseVisualStyleBackColor = true;
            // 
            // cbIos
            // 
            this.cbIos.AutoSize = true;
            this.cbIos.Location = new System.Drawing.Point(88, 111);
            this.cbIos.Name = "cbIos";
            this.cbIos.Size = new System.Drawing.Size(44, 19);
            this.cbIos.TabIndex = 5;
            this.cbIos.Text = "iOS";
            this.cbIos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 499);
            this.Controls.Add(this.cbIos);
            this.Controls.Add(this.cbAndroid);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocAwsSns Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox cbAndroid;
        private System.Windows.Forms.CheckBox cbIos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

