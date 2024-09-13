package br.com.progiv.devschat;

import android.app.ProgressDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.VolleyLog;
import com.android.volley.toolbox.StringRequest;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.UnsupportedEncodingException;
import java.util.HashMap;
import java.util.Map;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    //Views
    private EditText editTextEmail;
    private EditText editTextName;

    private Button buttonEnter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Initiailizing views
        editTextEmail = (EditText) findViewById(R.id.editTextEmail);
        editTextName = (EditText) findViewById(R.id.editTextName);

        buttonEnter = (Button) findViewById(R.id.buttonEnter);

        buttonEnter.setOnClickListener(this);

        //If the user is already logged in
        //Starting chat room
        if(AppController.getInstance().isLoggedIn()){
            finish();
            startActivity(new Intent(this, ChatRoomActivity.class));
        }
    }

    //Method to register user
    private void registerUser() throws JSONException {
        final ProgressDialog progressDialog = new ProgressDialog(this);
        progressDialog.setMessage("Aguarde...");
        progressDialog.show();

        final String nome = editTextName.getText().toString().trim();
        final String email = editTextEmail.getText().toString().trim();

        JSONObject jsonBody = new JSONObject();
        jsonBody.put("nome", nome);
        jsonBody.put("email", email);
        final String requestBody = jsonBody.toString();

       StringRequest stringRequest = new StringRequest(Request.Method.POST, URLs.URL_REGISTER,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {
                        progressDialog.dismiss();

                        try {
                            JSONObject obj = new JSONObject(response);
                            int id = obj.getInt("id");
                            String name = obj.getString("name");
                            String email = obj.getString("email");

                            //Login user
                            AppController.getInstance().loginUser(id,name,email);

                            //Starting chat room we need to create this activity
                            startActivity(new Intent(MainActivity.this, ChatRoomActivity.class));
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                    }
                }) {
           @Override
           public String getBodyContentType() {
               return "application/json; charset=utf-8";
           }
           @Override
           public byte[] getBody() throws AuthFailureError {
               try {
                   return requestBody == null ? null : requestBody.getBytes("utf-8");
               } catch (UnsupportedEncodingException uee) {
                   VolleyLog.wtf("Unsupported Encoding while trying to get the bytes of %s using %s", requestBody, "utf-8");
                   return null;
               }
           }
        };

        AppController.getInstance().addToRequestQueue(stringRequest);
    }

    @Override
    protected void onResume() {
        super.onResume();
        //Checking if user is logged in
        if(AppController.getInstance().isLoggedIn()){
            finish();
            startActivity(new Intent(this, ChatRoomActivity.class));
        }
    }

    @Override
    public void onClick(View v) {
        try {
            registerUser();
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}