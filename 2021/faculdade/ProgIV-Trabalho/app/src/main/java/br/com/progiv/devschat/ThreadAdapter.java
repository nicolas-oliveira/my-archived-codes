package br.com.progiv.devschat;

import android.content.Context;
import androidx.recyclerview.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.TimeZone;

//Class extending RecyclerviewAdapter
public class ThreadAdapter extends RecyclerView.Adapter<ThreadAdapter.ViewHolder> {

    //user id
    private int userId;
    private Context context;

    //Tag for tracking self message
    private int SELF = 786;

    //ArrayList of messages object containing all the messages in the thread
    private ArrayList<Message> messages;

    //Constructor
    public ThreadAdapter(Context context, ArrayList<Message> messages, int userId){
        this.userId = userId;
        this.messages = messages;
        this.context = context;
    }

    //IN this method we are tracking the self message
    @Override
    public int getItemViewType(int position) {
        //getting message object of current position
        Message message = messages.get(position);

        //If its owner  id is  equals to the logged in user id
        if (message.getUsersId() == userId) {
            //Returning self
            return SELF;
        }
        //else returning position
        return position;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        //Creating view
        View itemView;
        //if view type is self
        if (viewType == SELF) {
            //Inflating the layout self
            itemView = LayoutInflater.from(parent.getContext())
                    .inflate(R.layout.chat_thread, parent, false);
        } else {
            //else inflating the layout others
            itemView = LayoutInflater.from(parent.getContext())
                    .inflate(R.layout.chat_thread_other, parent, false);
        }
        //returing the view
        return new ViewHolder(itemView);
    }

    @Override
    public void onBindViewHolder(ViewHolder holder, int position) {
        //Adding messages to the views
        Message message = messages.get(position);
        holder.textViewMessage.setText(message.getMessage());
        holder.textViewTime.setText(message.getName()+", " + convertTimeStampToDay(Long.parseLong(message.getSentAt())));
    }

    private static String convertTimeStampToDay(long timeStamp){
        Calendar calendar = Calendar.getInstance();
        calendar.setTimeInMillis(timeStamp); // configura a hora
        TimeZone timeZone = TimeZone.getDefault(); // obtem o fuso horário do dispositivo
        //ajusta a hora para o fuso horário do dispositivo
        calendar.add(Calendar.MILLISECOND, timeZone.getOffset(calendar.getTimeInMillis()));
        //SimpleDateFormat que retorna o dia:
        DateFormat simpleDateFormat =  new SimpleDateFormat ("dd/MM/yyyy HH:mm");
        return simpleDateFormat.format(calendar.getTime());
    }

    @Override
    public int getItemCount() {
        return messages.size();
    }

    //Initializing views
    public class ViewHolder extends RecyclerView.ViewHolder {
        public TextView textViewMessage;
        public TextView textViewTime;

        public ViewHolder(View itemView) {
            super(itemView);
            textViewMessage = (TextView) itemView.findViewById(R.id.textViewMessage);
            textViewTime = (TextView) itemView.findViewById(R.id.textViewTime);
        }
    }
}