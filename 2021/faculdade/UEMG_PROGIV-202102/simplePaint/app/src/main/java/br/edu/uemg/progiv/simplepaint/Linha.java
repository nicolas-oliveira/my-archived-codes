package br.edu.uemg.progiv.simplepaint;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.graphics.Path;

public class Linha {
    private Path path;
    private Paint paint;

    //Construtor:
    public Linha(Context context, Path path){
        this.path = path;
        this.paint = Estilo.getEstilosParaLinha(0,0);
    }
    public Linha(Context context, Path path, Paint paint){
        this.path = path;
        this.paint = paint;
    }

    public void desenharLinha(Canvas canvas){
        canvas.drawPath(path, paint);
    }

}
