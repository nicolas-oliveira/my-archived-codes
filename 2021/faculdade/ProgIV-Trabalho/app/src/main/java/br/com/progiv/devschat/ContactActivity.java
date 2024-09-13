package br.com.progiv.devschat;

import android.app.ProgressDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;

import androidx.annotation.Nullable;
import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.android.volley.Request;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.UnsupportedEncodingException;
import java.util.ArrayList;

public class ContactActivity extends AppCompatActivity {

    //ArrayList of contacts to store the thread contact
    private ArrayList<Contact> contacts;

    //Recyclerview objects
    private RecyclerView recyclerView;
    private RecyclerView.LayoutManager layoutManager;
    private RecyclerView.Adapter adapter;

    //Progress dialog
    private ProgressDialog dialog;

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contacts);

        //Initializing recyclerview
        recyclerView = (RecyclerView) findViewById(R.id.recyclerViewContacts);
        recyclerView.setHasFixedSize(true);
        layoutManager = new LinearLayoutManager(this);
        recyclerView.setLayoutManager(layoutManager);

        ActionBar actionBar = getSupportActionBar();
        actionBar.setDisplayHomeAsUpEnabled(true);

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        //Initializing message arraylist
        contacts = new ArrayList<>();

        //Displaying dialog while the chat room is being ready
        dialog = new ProgressDialog(this);
        dialog.setMessage("Carregando contatos...");
        dialog.show();

        //Calling function to fetch the existing contacts on the thread
        fetchContacts();
    }

    private void fetchContacts(){
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URLs.URL_GET_CONTATS,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        try {
                            String  str = new String(response.getBytes("ISO-8859-1"), "UTF-8");
                            JSONArray thread = new JSONArray(str);
                            for (int i = 0; i < thread.length(); i++) {
                                JSONObject obj = thread.getJSONObject(i);
                                String name = obj.getString("name");
                                String email = obj.getString("email");
                                Contact contact = new Contact(name, email);
                                contacts.add(contact);
                            }

                            adapter = new ThreadAdapterContact(ContactActivity.this, contacts);

                            recyclerView.setAdapter(adapter);
                            dialog.dismiss();

                        } catch (JSONException | UnsupportedEncodingException e) {
                            e.printStackTrace();
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                    }
                });

        AppController.getInstance().addToRequestQueue(stringRequest);
    }

    public boolean onOptionsItemSelected(MenuItem item){
        Intent myIntent = new Intent(getApplicationContext(), ChatRoomActivity.class);
        startActivityForResult(myIntent, 0);
        return true;
    }
}
