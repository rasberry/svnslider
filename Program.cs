using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SvnSlider
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Inst = new Program();
			Inst.Init(args);
			Application.Run();
		}
		public static Program Inst;

		private SideBySide _window;
		private void Init(string[] args)
		{
			InitSvnClient();
			_window = new SideBySide();
			_window.FormClosed += window_FormClosed;
			_window.Show();
		}
		public SharpSvn.SvnClient Svn;

		private void InitSvnClient()
		{
			Svn = new SharpSvn.SvnClient();
			//Svn.Authentication.UserNameHandlers += Authentication_UserNameHandlers;
			//Svn.Authentication.UserNamePasswordHandlers += Authentication_UserNamePasswordHandlers;
		}

		void window_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
