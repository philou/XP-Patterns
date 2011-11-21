namespace Notes
{
  partial class NoteView
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
      this._contentTextBox = new System.Windows.Forms.TextBox();
      this._saveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // _contentTextBox
      // 
      this._contentTextBox.Location = new System.Drawing.Point(12, 13);
      this._contentTextBox.Multiline = true;
      this._contentTextBox.Name = "_contentTextBox";
      this._contentTextBox.Size = new System.Drawing.Size(268, 227);
      this._contentTextBox.TabIndex = 1;
      this._contentTextBox.TextChanged += new System.EventHandler(this.OnContentTextBoxTextChanged);
      // 
      // _saveButton
      // 
      this._saveButton.Location = new System.Drawing.Point(205, 246);
      this._saveButton.Name = "_saveButton";
      this._saveButton.Size = new System.Drawing.Size(75, 23);
      this._saveButton.TabIndex = 2;
      this._saveButton.Text = "Save";
      this._saveButton.UseVisualStyleBackColor = true;
      // 
      // NoteView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 281);
      this.Controls.Add(this._saveButton);
      this.Controls.Add(this._contentTextBox);
      this.Name = "NoteView";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox _contentTextBox;
    private System.Windows.Forms.Button _saveButton;
  }
}

