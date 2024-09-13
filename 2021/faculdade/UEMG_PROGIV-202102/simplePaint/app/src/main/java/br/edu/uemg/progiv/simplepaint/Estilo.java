package br.edu.uemg.progiv.simplepaint;

import android.graphics.Color;
import android.graphics.Paint;

public class Estilo {

    public static Paint getEstilosParaLinha(){
        Paint estiloLinha = new Paint();
        estiloLinha.setAntiAlias(true);
        estiloLinha.setColor(Color.BLUE);
        estiloLinha.setStyle(Paint.Style.STROKE);
        estiloLinha.setStrokeWidth(4f);
        estiloLinha.setStrokeJoin(Paint.Join.ROUND);
        return estiloLinha;
    }

    public static Paint getEstilosParaLinha(int color, int strokeWidth){
        Paint estiloLinha = new Paint();
        estiloLinha.setAntiAlias(true);
        switch (color){
            case 0: estiloLinha.setColor(Color.BLUE);  break;
            case 1: estiloLinha.setColor(Color.GREEN); break;
            case 2: estiloLinha.setColor(Color.RED);   break;
        }
        estiloLinha.setStyle(Paint.Style.STROKE);
        switch (strokeWidth){
            case 0: estiloLinha.setStrokeWidth(4f); break;
            case 1: estiloLinha.setStrokeWidth(5f); break;
            case 2: estiloLinha.setStrokeWidth(8f); break;
        }
        estiloLinha.setStrokeJoin(Paint.Join.ROUND);
        return estiloLinha;
    }

    public static Paint getEstiloParaLinhaVerde(){
        Paint estiloLinha = new Paint();
        estiloLinha.setAntiAlias(true);
        estiloLinha.setColor(Color.GREEN);
        estiloLinha.setStyle(Paint.Style.STROKE);
        estiloLinha.setStrokeWidth(5f);
        estiloLinha.setStrokeJoin(Paint.Join.ROUND);
        return estiloLinha;
    }

}
