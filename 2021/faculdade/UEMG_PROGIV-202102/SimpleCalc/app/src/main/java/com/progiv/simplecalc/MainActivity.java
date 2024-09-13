package com.progiv.simplecalc;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    int i = 0;
    int count = 0;
    int[] Result;
    int Total;
    static int INVALID = 999999;
    String operacao;

    Button btn00, btn01, btn02, btn03, btn04, btn05, btn06, btn07, btn08, btn09;
    Button btnSoma, btnSub, btnMult, btnDiv, btnIgual, btnLimpa;

    TextView RESULTSCREEN;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Result = new int[2];

        RESULTSCREEN = (TextView) findViewById(R.id.RESULTSCREEN);

        btn00 = (Button) findViewById(R.id.button0);
        btn01 = (Button) findViewById(R.id.button1);
        btn02 = (Button) findViewById(R.id.button2);
        btn03 = (Button) findViewById(R.id.button3);
        btn04 = (Button) findViewById(R.id.button4);
        btn05 = (Button) findViewById(R.id.button5);
        btn06 = (Button) findViewById(R.id.button6);
        btn07 = (Button) findViewById(R.id.button7);
        btn08 = (Button) findViewById(R.id.button8);
        btn09 = (Button) findViewById(R.id.button9);

        btnSoma = (Button) findViewById(R.id.buttonsoma);
        btnSub = (Button) findViewById(R.id.buttonsub);
        btnDiv = (Button) findViewById(R.id.buttondiv);
        btnMult = (Button) findViewById(R.id.buttonmult);
        btnLimpa = (Button) findViewById(R.id.buttonLimpar);
        btnIgual = (Button) findViewById(R.id.buttonigual);


        this.selectButton(btn00, 0);
        this.selectButton(btn01, 1);
        this.selectButton(btn02, 2);
        this.selectButton(btn03, 3);
        this.selectButton(btn04, 4);
        this.selectButton(btn05, 5);
        this.selectButton(btn06, 6);
        this.selectButton(btn07, 7);
        this.selectButton(btn08, 8);
        this.selectButton(btn09, 9);

        this.setOperation(btnSoma, "soma");
        this.setOperation(btnSub, "sub");
        this.setOperation(btnMult, "multi");
        this.setOperation(btnDiv, "div");

        btnIgual.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                calcular();
                exibirResultado();
                Total = 0;
                count = 0;
            }
        });

        btnLimpa.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                limpar();
            }
        });
    }

    private void exibirResultado() {
        String tela = "";
        if (Total != 0 && Total < INVALID) {
            tela = String.valueOf(Total);
        } else if (Total > INVALID) {
            tela = "Error";
        } else {
            tela = String.valueOf(Result[i]);
        }

        RESULTSCREEN.setText(tela);
    }

    private void proximoNumero() {
        count = 0;
        i = 1;
    }

    private void setOperation(Button opButton, String op) {
        opButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                operacao = op;
                proximoNumero();
            }
        });
    }

    private void selectButton(Button buttonChoose, int propNumber) {
        buttonChoose.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // if (count < 7) {
                    Result[i] = (Result[1] * 10) + propNumber;
                    count++;
                // }
                exibirResultado();
                Total = 0;
            }
        });
    }

    private void limpar(){
        i = 0;
        Result[0] = 0;
        Result[1] = 0;
        Total = 0;
        count = 0;
        exibirResultado();
    }

    private void calcular() {
        // double value;
        switch (operacao) {
            case "soma":
                Total = (Result[0] + Result[1]);
                break;
            case "sub":
                Total = (Result[0] - Result[1]);
                break;
            case "multi":
                Total = (Result[0] * Result[1]);
                break;
            case "div":
                Total = (Result[0] / Result[1]);
                break;
        }
        if (Total < INVALID) {
            Result[0] = Total;
            Result[1] = 0;
            i = 1;
        }
    }
}