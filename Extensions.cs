using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SvnSlider
{
	public static class Extensions
	{
		public static Thread RunInThread(this Action func,ApartmentState? model = null,bool isBackground = true)
		{
			Thread thread = new Thread(new ThreadStart(func));
			if (model.HasValue) {
				thread.SetApartmentState(model.Value);
			}
			thread.IsBackground = isBackground;
			thread.Start();
			return thread;
		}

		//public static Task StartThread(this Action func, ApartmentState? model = null,bool isBackground = false)
		//{
		//	var tcs = new TaskCompletionSource<object>();
		//	Thread thread = new Thread(() => {
		//		try {
		//			func();
		//			tcs.SetResult(null);
		//		} catch (Exception e) {
		//			tcs.SetException(e);
		//		}
		//	});
		//	if (model.HasValue) {
		//		thread.SetApartmentState(model.Value);
		//	}
		//	thread.IsBackground = isBackground;
		//	thread.Start();
		//	return tcs.Task;
		//}

		////http://stackoverflow.com/questions/16720496/set-apartmentstate-on-a-task
		//public static Task<T> StartTask<T>(this Func<T> func,ApartmentState? model = null,bool isBackground = false)
		//{
		//	var tcs = new TaskCompletionSource<T>();
		//	Thread thread = new Thread(() => {
		//		try {
		//			tcs.SetResult(func());
		//		} catch (Exception e) {
		//			tcs.SetException(e);
		//		}
		//	});
		//	if (model.HasValue) {
		//		thread.SetApartmentState(model.Value);
		//	}
		//	thread.IsBackground = isBackground;
		//	thread.Start();
		//	return tcs.Task;
		//}
	}
}
