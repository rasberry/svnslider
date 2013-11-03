using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvnSlider
{
	public static class SvnUtils
	{
		public static List<Thing> Revs = null;
		private static string _fileuri;
		public class Thing
		{
			public string Content;
			public string Author;
			public long Revision;
			public DateTime Date;
			public string Log;
		}

		public static bool TryGetUri(string path, out Uri uri)
		{
			uri = default(Uri);
			if (String.IsNullOrEmpty(path)) {
				return false;
			}
			if (Uri.TryCreate(path,UriKind.RelativeOrAbsolute,out uri)) {
				return true;
			}
			return false;
		}

		public static void PopLog(string path, EventHandler<SharpSvn.SvnProgressEventArgs> progress = null)
		{
			if (Revs != null && _fileuri == path) { return; }
			_fileuri = path;
			var args = new SharpSvn.SvnFileVersionsArgs {
				Start = SharpSvn.SvnRevision.Zero
				,End = SharpSvn.SvnRevision.Head
			};
			var target = SharpSvn.SvnTarget.FromString(path);
			if (progress != null) { args.Progress += progress; }
			Revs = new List<Thing>();

			try {
				Program.Inst.Svn.FileVersions(target,args,PopLogCallback);
			} catch(Exception e) {
				MessageBox.Show(e.Message);
			}
			if (Revs.Count > 0) {
				Revs.Sort((Thing a, Thing b) => { return (int)(a.Revision - b.Revision); });
			}
		}

		private static void PopLogCallback(object sender, SharpSvn.SvnFileVersionEventArgs e)
		{
			StreamReader sr = new StreamReader(e.GetContentStream());
			Revs.Add(new Thing {
				Author = e.Author
				,Revision = e.Revision
				,Date = e.Time
				,Log = e.LogMessage
				,Content = sr.ReadToEnd()
			});
		}
	}
}
