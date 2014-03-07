// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Benchmark.iOS
{
	[Register ("Benchmark_iOSViewController")]
	partial class Benchmark_iOSViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton btnBenchmark { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel lblNaive { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel lblPerls { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel lblStackOverflow { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnBenchmark != null) {
				btnBenchmark.Dispose ();
				btnBenchmark = null;
			}
			if (lblNaive != null) {
				lblNaive.Dispose ();
				lblNaive = null;
			}
			if (lblPerls != null) {
				lblPerls.Dispose ();
				lblPerls = null;
			}
			if (lblStackOverflow != null) {
				lblStackOverflow.Dispose ();
				lblStackOverflow = null;
			}
		}
	}
}
