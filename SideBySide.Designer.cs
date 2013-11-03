namespace SvnSlider
{
	partial class SideBySide
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
			this.MainTable = new System.Windows.Forms.TableLayoutPanel();
			this.LeftLogBox = new System.Windows.Forms.TextBox();
			this.RightLogBox = new System.Windows.Forms.TextBox();
			this.LeftRevText = new System.Windows.Forms.RichTextBox();
			this.RightRevText = new System.Windows.Forms.RichTextBox();
			this.PathTable = new System.Windows.Forms.TableLayoutPanel();
			this.PathLabel = new System.Windows.Forms.Label();
			this.PathInput = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.FindTable = new System.Windows.Forms.TableLayoutPanel();
			this.FindLabel = new System.Windows.Forms.Label();
			this.FindInput = new System.Windows.Forms.TextBox();
			this.PrevButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.InformationText = new System.Windows.Forms.StatusBar();
			this.SliderTable = new System.Windows.Forms.TableLayoutPanel();
			this.RevisionSlider = new System.Windows.Forms.TrackBar();
			this.SliderLabel = new System.Windows.Forms.Label();
			this.MainTable.SuspendLayout();
			this.PathTable.SuspendLayout();
			this.FindTable.SuspendLayout();
			this.SliderTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RevisionSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTable
			// 
			this.MainTable.ColumnCount = 2;
			this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.MainTable.Controls.Add(this.LeftLogBox, 0, 3);
			this.MainTable.Controls.Add(this.RightLogBox, 1, 3);
			this.MainTable.Controls.Add(this.LeftRevText, 0, 2);
			this.MainTable.Controls.Add(this.RightRevText, 1, 2);
			this.MainTable.Controls.Add(this.PathTable, 0, 0);
			this.MainTable.Controls.Add(this.FindTable, 0, 4);
			this.MainTable.Controls.Add(this.InformationText, 0, 5);
			this.MainTable.Controls.Add(this.SliderTable, 0, 1);
			this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTable.Location = new System.Drawing.Point(0, 0);
			this.MainTable.Margin = new System.Windows.Forms.Padding(0);
			this.MainTable.Name = "MainTable";
			this.MainTable.RowCount = 6;
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.MainTable.Size = new System.Drawing.Size(371, 310);
			this.MainTable.TabIndex = 0;
			// 
			// LeftLogBox
			// 
			this.LeftLogBox.BackColor = System.Drawing.SystemColors.Window;
			this.LeftLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LeftLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LeftLogBox.Location = new System.Drawing.Point(0, 151);
			this.LeftLogBox.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
			this.LeftLogBox.Multiline = true;
			this.LeftLogBox.Name = "LeftLogBox";
			this.LeftLogBox.ReadOnly = true;
			this.LeftLogBox.Size = new System.Drawing.Size(184, 99);
			this.LeftLogBox.TabIndex = 4;
			// 
			// RightLogBox
			// 
			this.RightLogBox.BackColor = System.Drawing.SystemColors.Window;
			this.RightLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RightLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightLogBox.Location = new System.Drawing.Point(186, 151);
			this.RightLogBox.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
			this.RightLogBox.Multiline = true;
			this.RightLogBox.Name = "RightLogBox";
			this.RightLogBox.ReadOnly = true;
			this.RightLogBox.Size = new System.Drawing.Size(185, 99);
			this.RightLogBox.TabIndex = 5;
			// 
			// LeftRevText
			// 
			this.LeftRevText.BackColor = System.Drawing.SystemColors.Window;
			this.LeftRevText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LeftRevText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LeftRevText.Location = new System.Drawing.Point(0, 60);
			this.LeftRevText.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
			this.LeftRevText.Name = "LeftRevText";
			this.LeftRevText.ReadOnly = true;
			this.LeftRevText.Size = new System.Drawing.Size(184, 89);
			this.LeftRevText.TabIndex = 6;
			this.LeftRevText.Text = "";
			this.LeftRevText.WordWrap = false;
			// 
			// RightRevText
			// 
			this.RightRevText.BackColor = System.Drawing.SystemColors.Window;
			this.RightRevText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RightRevText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RightRevText.Location = new System.Drawing.Point(186, 60);
			this.RightRevText.Margin = new System.Windows.Forms.Padding(1, 0, 0, 1);
			this.RightRevText.Name = "RightRevText";
			this.RightRevText.ReadOnly = true;
			this.RightRevText.Size = new System.Drawing.Size(185, 89);
			this.RightRevText.TabIndex = 7;
			this.RightRevText.Text = "";
			this.RightRevText.WordWrap = false;
			// 
			// PathTable
			// 
			this.PathTable.ColumnCount = 3;
			this.MainTable.SetColumnSpan(this.PathTable, 2);
			this.PathTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.PathTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PathTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.PathTable.Controls.Add(this.PathLabel, 0, 0);
			this.PathTable.Controls.Add(this.PathInput, 1, 0);
			this.PathTable.Controls.Add(this.BrowseButton, 2, 0);
			this.PathTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PathTable.Location = new System.Drawing.Point(0, 0);
			this.PathTable.Margin = new System.Windows.Forms.Padding(0);
			this.PathTable.Name = "PathTable";
			this.PathTable.RowCount = 1;
			this.PathTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.PathTable.Size = new System.Drawing.Size(371, 30);
			this.PathTable.TabIndex = 9;
			// 
			// PathLabel
			// 
			this.PathLabel.AutoSize = true;
			this.PathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PathLabel.Location = new System.Drawing.Point(3, 0);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(34, 30);
			this.PathLabel.TabIndex = 0;
			this.PathLabel.Text = "Path";
			this.PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PathInput
			// 
			this.PathInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PathInput.Location = new System.Drawing.Point(43, 3);
			this.PathInput.Name = "PathInput";
			this.PathInput.Size = new System.Drawing.Size(245, 20);
			this.PathInput.TabIndex = 1;
			// 
			// BrowseButton
			// 
			this.BrowseButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BrowseButton.Location = new System.Drawing.Point(294, 3);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(74, 24);
			this.BrowseButton.TabIndex = 2;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			// 
			// FindTable
			// 
			this.FindTable.ColumnCount = 4;
			this.MainTable.SetColumnSpan(this.FindTable, 2);
			this.FindTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.FindTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FindTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.FindTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.FindTable.Controls.Add(this.FindLabel, 0, 0);
			this.FindTable.Controls.Add(this.FindInput, 1, 0);
			this.FindTable.Controls.Add(this.PrevButton, 2, 0);
			this.FindTable.Controls.Add(this.NextButton, 3, 0);
			this.FindTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FindTable.Location = new System.Drawing.Point(0, 250);
			this.FindTable.Margin = new System.Windows.Forms.Padding(0);
			this.FindTable.Name = "FindTable";
			this.FindTable.RowCount = 1;
			this.FindTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.FindTable.Size = new System.Drawing.Size(371, 30);
			this.FindTable.TabIndex = 10;
			// 
			// FindLabel
			// 
			this.FindLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FindLabel.Location = new System.Drawing.Point(3, 0);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(34, 30);
			this.FindLabel.TabIndex = 0;
			this.FindLabel.Text = "Find";
			this.FindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FindInput
			// 
			this.FindInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FindInput.Location = new System.Drawing.Point(43, 3);
			this.FindInput.Name = "FindInput";
			this.FindInput.Size = new System.Drawing.Size(165, 20);
			this.FindInput.TabIndex = 1;
			// 
			// PrevButton
			// 
			this.PrevButton.Location = new System.Drawing.Point(214, 3);
			this.PrevButton.Name = "PrevButton";
			this.PrevButton.Size = new System.Drawing.Size(74, 23);
			this.PrevButton.TabIndex = 2;
			this.PrevButton.Text = "Prev";
			this.PrevButton.UseVisualStyleBackColor = true;
			// 
			// NextButton
			// 
			this.NextButton.Location = new System.Drawing.Point(294, 3);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(74, 23);
			this.NextButton.TabIndex = 3;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			// 
			// InformationText
			// 
			this.MainTable.SetColumnSpan(this.InformationText, 2);
			this.InformationText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InformationText.Location = new System.Drawing.Point(3, 283);
			this.InformationText.Name = "InformationText";
			this.InformationText.Size = new System.Drawing.Size(365, 24);
			this.InformationText.TabIndex = 11;
			// 
			// SliderTable
			// 
			this.SliderTable.ColumnCount = 2;
			this.MainTable.SetColumnSpan(this.SliderTable, 2);
			this.SliderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SliderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.SliderTable.Controls.Add(this.RevisionSlider, 0, 0);
			this.SliderTable.Controls.Add(this.SliderLabel, 1, 0);
			this.SliderTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderTable.Location = new System.Drawing.Point(0, 30);
			this.SliderTable.Margin = new System.Windows.Forms.Padding(0);
			this.SliderTable.Name = "SliderTable";
			this.SliderTable.RowCount = 1;
			this.SliderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SliderTable.Size = new System.Drawing.Size(371, 30);
			this.SliderTable.TabIndex = 12;
			// 
			// RevisionSlider
			// 
			this.RevisionSlider.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RevisionSlider.Location = new System.Drawing.Point(3, 3);
			this.RevisionSlider.Name = "RevisionSlider";
			this.RevisionSlider.Size = new System.Drawing.Size(305, 24);
			this.RevisionSlider.TabIndex = 2;
			this.RevisionSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// SliderLabel
			// 
			this.SliderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SliderLabel.Location = new System.Drawing.Point(314, 0);
			this.SliderLabel.Name = "SliderLabel";
			this.SliderLabel.Size = new System.Drawing.Size(54, 30);
			this.SliderLabel.TabIndex = 3;
			this.SliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SideBySide
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 310);
			this.Controls.Add(this.MainTable);
			this.MinimumSize = new System.Drawing.Size(387, 348);
			this.Name = "SideBySide";
			this.Text = "SideBySide";
			this.MainTable.ResumeLayout(false);
			this.MainTable.PerformLayout();
			this.PathTable.ResumeLayout(false);
			this.PathTable.PerformLayout();
			this.FindTable.ResumeLayout(false);
			this.FindTable.PerformLayout();
			this.SliderTable.ResumeLayout(false);
			this.SliderTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RevisionSlider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTable;
		private System.Windows.Forms.TrackBar RevisionSlider;
		private System.Windows.Forms.TextBox LeftLogBox;
		private System.Windows.Forms.TextBox RightLogBox;
		private System.Windows.Forms.RichTextBox LeftRevText;
		private System.Windows.Forms.RichTextBox RightRevText;
		private System.Windows.Forms.TableLayoutPanel PathTable;
		private System.Windows.Forms.Label PathLabel;
		private System.Windows.Forms.TextBox PathInput;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.TableLayoutPanel FindTable;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.TextBox FindInput;
		private System.Windows.Forms.Button PrevButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.StatusBar InformationText;
		private System.Windows.Forms.TableLayoutPanel SliderTable;
		private System.Windows.Forms.Label SliderLabel;

	}
}