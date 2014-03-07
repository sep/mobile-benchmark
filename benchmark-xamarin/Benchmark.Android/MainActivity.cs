using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Benchmark.Core;
using System.Linq;

namespace Benchmark.Android
{
    [Activity (Label = "Benchmark", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Main);

            Button button = FindViewById<Button> (Resource.Id.btnRun);
            
            button.Click += (a, b) =>
            {
                var runs = new[]{
                    new{alg= (IPrime)new AlgorithmAJavaMath(), label= FindViewById<TextView>(Resource.Id.lblAlgAJava), text = "A (java.lang.Math): "},
                    new{alg= (IPrime)new AlgorithmAMonoMath(), label= FindViewById<TextView>(Resource.Id.lblAlgAMono), text = "A (System.Math): "},
                    new{alg= (IPrime)new AlgorithmB(), label= FindViewById<TextView>(Resource.Id.lblAlgB), text = "B: "},
                };
                
                const int iterations = 100000;
                
                runs.ToList().ForEach(x =>
                {
                    var elapsed = TheBenchmark.Timed(() =>
                    {
                        for(int i=0; i<iterations; i++)
                        {
                            x.alg.IsPrime(i);
                        }
                    });
                    x.label.Text = x.text + " " + elapsed.TotalMilliseconds;
                });
            };
        }
        
        public class AlgorithmAJavaMath : IPrime
        {
            public bool IsPrime(int candidate)
            {
                if (candidate == 1) return false;
                if (candidate == 2) return true;
            
                for (int i = 2; i <= Java.Lang.Math.Ceil(Java.Lang.Math.Sqrt(candidate)); ++i)  {
                   if (candidate % i == 0)  return false;
                }
            
                return true;
            }
        }
    }
}


