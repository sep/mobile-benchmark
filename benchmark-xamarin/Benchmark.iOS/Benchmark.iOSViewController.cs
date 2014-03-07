using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Benchmark.Core;
using System.Linq;

namespace Benchmark.iOS
{
    public partial class Benchmark_iOSViewController : UIViewController
    {
        public Benchmark_iOSViewController (IntPtr handle) : base (handle)
        {
        }

        #region View lifecycle

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            
            btnBenchmark.TouchUpInside += (object sender, EventArgs e) => 
            {
                var runs = new[]{
                    new{alg= (IPrime)new AlgorithmAMonoMath(), label= lblStackOverflow, text = "A: "},
                    new{alg= (IPrime)new AlgorithmB(), label= lblPerls, text = "B: "},
                };
                
                const int iterations = 100000;
                
                runs.ToList().ForEach(x =>
                {
                    var elapsed = TheBenchmark.Timed(() =>
                    {
                        for(int i=0; i<iterations; i++)
                        {
                            var p = x.alg.IsPrime(i);
                        }
                    });
                    x.label.Text = x.text + " " + elapsed.TotalMilliseconds;
                });
            };
        }


        #endregion
    }
}

