using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvnSlider
{
	public class ThreadControlAccessor<C,F> where C : Control where F : Form
	{
		public delegate T GetDelegate<T>();
		public delegate void SetDelegate<T>(T s);
	
		public ThreadControlAccessor(C c,F f)
		{
			_c = c;
			_f = f;
		}
		private C _c;
		private F _f;
		
		public C Get()
		{
			if (_c.InvokeRequired)
			{
				GetDelegate<C> d = new GetDelegate<C>(Get);
				return (C)_f.Invoke(d);
			}
			else
			{
				return _c;
			}
		}
		
		public void Set(C c)
		{
			if (_c != null && _c.InvokeRequired)
			{
				SetDelegate<C> d = new SetDelegate<C>(Set);
				_f.Invoke(d,c);
			}
			else
			{
				_c = c;
			}
		}
	}
}
