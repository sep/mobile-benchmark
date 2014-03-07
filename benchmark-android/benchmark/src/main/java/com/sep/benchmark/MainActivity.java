package com.sep.benchmark;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.GregorianCalendar;

public class MainActivity extends ActionBarActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button runButton = (Button)this.findViewById(R.id.btnRun);
        final TextView lblAlgorithmA = (TextView)this.findViewById(R.id.lblAlgorithmA);
        final TextView lblAlgorithmB = (TextView)this.findViewById(R.id.lblAlgorithmB);

        runButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Prime algA = new PrimeAlgorithmA();
                Prime algB = new PrimeAlgorithmB();

                int numIterations = 100000;

                doTest(algA, numIterations, lblAlgorithmA, "A: ");
                doTest(algB, numIterations, lblAlgorithmB, "B: ");
            }
        });
    }

    public void doTest(final Prime alg, final int numIterations, TextView label, String prefix) {
        long elapsed = TimedOperation(new Runnable(){
            public void run() {
                for (int i=0; i<numIterations; i++) {
                    alg.isPrime(i);
                }
            }
        });

        label.setText(prefix + elapsed);
    }

    public long TimedOperation(Runnable toPerform) {
        long begin = GregorianCalendar.getInstance().getTimeInMillis();
        toPerform.run();
        long end = GregorianCalendar.getInstance().getTimeInMillis();

        return end - begin;
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    interface Prime {
        boolean isPrime(int candidate);
    }

    class PrimeAlgorithmA implements Prime{
        @Override
        public boolean isPrime(int candidate) {
            if (candidate == 1) return false;
            if (candidate == 2) return true;

            for (int i = 2; i <= Math.ceil(Math.sqrt(candidate)); ++i)  {
                if (candidate % i == 0)  return false;
            }

            return true;
        }
    }

    class PrimeAlgorithmB implements Prime{
        @Override
        public boolean isPrime(int candidate) {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
