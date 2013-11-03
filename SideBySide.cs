using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvnSlider
{
	public partial class SideBySide : Form
	{
		public SideBySide()
		{
			InitializeComponent();

			_status = new ThreadControlAccessor<StatusBar, Form>(InformationText,this);

			BrowseButton.Click += BrowseButton_Click;
			PathInput.Leave += PathInput_Leave;
			RevisionSlider.ValueChanged += RevisionSlider_ValueChanged;
		}

		private ThreadControlAccessor<StatusBar, Form> _status;

		public string StatusText { get {
			if (_status == null) { return ""; }
			StatusBar ss = _status.Get();
			return ss == null ? "" : ss.Text;
		} set {
			if (_status == null) { return; }
			StatusBar ss = _status.Get();
			if (ss != null) { ss.Text = value; }
		}}

		private void LoadRepo(string path)
		{
			var task = Extensions.RunInThread(() => {
				SvnUtils.PopLog(path,(object sender, SharpSvn.SvnProgressEventArgs args) => {
					double pct = args.Progress / args.TotalProgress;
					StatusText = "Loading Repo "+pct.ToString("p");
				});
				FinishLoadRepo();
			},null,true);
		}

		private void FinishLoadRepo()
		{
			if (SvnUtils.Revs == null) {
				StatusText = "Loading failed";
				return;
			}
			StatusText = "Loaded "+SvnUtils.Revs.Count+" Revisions";
			RevisionSlider.Minimum = 1;
			RevisionSlider.Maximum = SvnUtils.Revs.Count-1;
			UpdateLogRev();
		}

		private void UpdateLogRev()
		{
			int count = SvnUtils.Revs.Count;
			if (count > 0) {
				PopLogBoxes(RevisionSlider.Value,RightLogBox,RightRevText);
			}
			if (count > 1) {
				PopLogBoxes(RevisionSlider.Value-1,LeftLogBox,LeftRevText);
			}
		}

		private void PopLogBoxes(int revnum, TextBox logbox, RichTextBox contentbox)
		{
			var rev = SvnUtils.Revs[revnum];
			logbox.Text = rev.Revision+" "+rev.Author
				+"\r\n"+rev.Date.ToString("o")
				+"\r\n"+rev.Log
			;
			contentbox.Text = rev.Content;
		}

		private string folderPath;
		private void BrowseButton_Click(object sender, EventArgs e)
		{
			var task = Extensions.RunInThread(() => {
				folderPath = "";
				var dialog = new System.Windows.Forms.OpenFileDialog();
				dialog.Multiselect = false;
				dialog.CheckFileExists = false;
				dialog.Title = "Select file from working copy";
				if (dialog.ShowDialog() == DialogResult.OK) {
					folderPath = dialog.FileName;
				}
			},System.Threading.ApartmentState.STA);
			task.Join();
			PathInput.Text = folderPath;
			PathInput_Leave(sender,e);
		}

		private void PathInput_Leave(object sender, EventArgs e)
		{
			string path = PathInput.Text;
			StatusText = "Loading Repo "+path;
			if (!String.IsNullOrEmpty(path)) {
				LoadRepo(path);
			}
		}

		void RevisionSlider_ValueChanged(object sender, EventArgs e)
		{
			SliderLabel.Text = RevisionSlider.Value.ToString();
			UpdateLogRev();
		}
	}
}

