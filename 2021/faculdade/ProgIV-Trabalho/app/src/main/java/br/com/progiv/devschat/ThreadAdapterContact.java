package br.com.progiv.devschat;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.TimeZone;

public class ThreadAdapterContact extends RecyclerView.Adapter<ThreadAdapterContact.ViewHolder> {

    //ArrayList of messages object containing all the messages in the thread
    private ArrayList<Contact> contacts;

    private Context context;

    //Constructor
    public ThreadAdapterContact(Context context, ArrayList<Contact> contacts){
        this.contacts = contacts;
        this.context = context;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        //Creating view
        View itemView;

        itemView = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.contact_thread, parent, false);

        //returing the view
        return new ViewHolder(itemView);
    }

    @Override
    public void onBindViewHolder(ViewHolder holder, int position) {
        //Adding messages to the views
        Contact contact = contacts.get(position);
        holder.textViewName.setText(contact.getName());
        holder.textViewEmail.setText(contact.getEmail());
    }

    @Override
    public int getItemCount() { return contacts.size(); }

    //Initializing views
    public class ViewHolder extends RecyclerView.ViewHolder {
        public TextView textViewName;
        public TextView textViewEmail;

        public ViewHolder(View itemView) {
            super(itemView);
            textViewName = (TextView) itemView.findViewById(R.id.textViewName);
            textViewEmail = (TextView) itemView.findViewById(R.id.textViewEmail);
        }
    }
}
