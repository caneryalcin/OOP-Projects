package com.example.caner.catchtheball;

import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Point;
import android.media.AudioAttributes;
import android.media.SoundPool;
import android.os.Build;
import android.support.annotation.RequiresApi;
import android.support.annotation.UiThread;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Display;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.media.MediaPlayer;

import java.io.IOException;
import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;

public class CatchTheBall extends AppCompatActivity {

    ImageView firstball;
    ImageView secondball;
    ImageView thirdball;
    TextView scoreText;
    long score =0;

    SoundPool soundPool;
    SoundPool.Builder soundPoolBuilder;

    AudioAttributes attributes;
    AudioAttributes.Builder attributesBuilder;

    int soundID_coin,
        soundID_gameover;

    MediaPlayer backgroundPlayer;


    @RequiresApi(api = Build.VERSION_CODES.LOLLIPOP)
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_catch_the_ball);
        scoreText = (TextView) findViewById(R.id.counters);
        firstball = (ImageView) findViewById(R.id.firstBallImage);
        secondball = (ImageView) findViewById(R.id.secondBallImage);
        thirdball = (ImageView) findViewById(R.id.redBallImage);

        attributesBuilder = new AudioAttributes.Builder();
        attributesBuilder.setUsage(AudioAttributes.USAGE_GAME);
        attributesBuilder.setContentType(AudioAttributes.CONTENT_TYPE_SONIFICATION);
        attributes = attributesBuilder.build();

        soundPoolBuilder = new SoundPool.Builder();
        soundPoolBuilder.setAudioAttributes(attributes);
        soundPool = soundPoolBuilder.build();

        soundID_coin = soundPool.load(this,R.raw.collectpoint,1);
        soundID_gameover = soundPool.load(this,R.raw.gameover,1);



        firsBlackball();
        secondBlackball();
        redBall();


    }

    public  void firsBlackball(){

        Timer timer = new Timer();
        TimerTask UpdateBallTask = new TimerTask() {
            @Override
            public void run() {

                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        //For finding screen size
                        Display display = getWindowManager().getDefaultDisplay();
                        Point size = new Point();
                        display.getSize(size);
                        int width = size.x;
                        int height = size.y;

                        //These lines generate random numbers for ball position
                        Random r = new Random();
                        int x = r.nextInt((width-200) - 0);
                        int y = r.nextInt((height-500) - 0);
                        firstball.setX(x);
                        firstball.setY(y);
                    }
                });

            }
        };

        //Speed for random ball position
        int FPS = 1;
        timer.scheduleAtFixedRate(UpdateBallTask, 0, 1000 / FPS);

        //Ball clicking event
        firstball.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                score++;
                scoreText.setText("Score: " + score);
                soundPool.play(soundID_coin,1, 1,0,0,1);

            }
        });

    }

    public void secondBlackball(){

        Timer timer = new Timer();
        TimerTask UpdateBallTask = new TimerTask() {
            @Override
            public void run() {
                //For finding screen size
                Display display = getWindowManager().getDefaultDisplay();
                Point size = new Point();
                display.getSize(size);
                int width = size.x;
                int height = size.y;

                //These lines generate random numbers for ball position
                Random r = new Random();
                int x = r.nextInt((width-200) - 0);
                int y = r.nextInt((height-500) - 0);
                secondball.setX(x);
                secondball.setY(y);

            }
        };
        //Speed for random ball position
        int FPS = 2;
        timer.scheduleAtFixedRate(UpdateBallTask, 0, 1000 / FPS);

        //Ball clicking event
        secondball.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                score++;
                scoreText.setText("Score: " + score);
                soundPool.play(soundID_coin,1, 1,0,0,1);

            }
        });


    }

    public void redBall(){
        //backgroundPlayer is working here.Because when user touch the redball  media player will stop.backgroundPlayer is stopping in onclick listener.
        backgroundPlayer = MediaPlayer.create(getApplicationContext(),R.raw.backgroundsound);
        backgroundPlayer.start();
        backgroundPlayer.setLooping(true);

        Timer timer = new Timer();
        TimerTask UpdateBallTask = new TimerTask() {
            @Override
            public void run() {

                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        //For finding screen size
                        Display display = getWindowManager().getDefaultDisplay();
                        Point size = new Point();
                        display.getSize(size);
                        int width = size.x;
                        int height = size.y;

                        //These lines generate random numbers for ball position
                        Random r = new Random();
                        int x = r.nextInt((width-200) - 0);
                        int y = r.nextInt((height-500) - 0);
                        thirdball.setX(x);
                        thirdball.setY(y);
                    }
                });



            }
        };

        //Speed for random ball position
        int FPS = 1;
        timer.scheduleAtFixedRate(UpdateBallTask, 0, 1000 / FPS);

        //Ball clicking event
        thirdball.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(final View view) {

                soundPool.play(soundID_gameover,1, 1,0,0,1);
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        backgroundPlayer.stop();
                        Intent intent =  new Intent(getApplicationContext(),FirstPage.class);
                        intent.putExtra("Score",scoreText.getText().toString());
                        startActivity(intent);
                        CatchTheBall.this.finish();
                    }
                });



            }
        });

    }


}



