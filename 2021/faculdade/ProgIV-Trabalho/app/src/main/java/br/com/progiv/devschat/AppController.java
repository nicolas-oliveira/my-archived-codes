package br.com.progiv.devschat;

import android.app.Application;
import android.content.Context;
import android.content.SharedPreferences;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.toolbox.Volley;

public class AppController extends Application {

    //Creating a volley request queue object
    private RequestQueue mRequestQueue;

    //Creatting class object
    private static AppController mInstance;

    //Creating sharedpreferences object
    //We will store the user data in sharedpreferences
    private SharedPreferences sharedPreferences;

    //class instance will be initialized on app launch
    @Override
    public void onCreate() {
        super.onCreate();
        mInstance = this;
    }

    //Public static method to get the instance of this class
    public static synchronized AppController getInstance() {
        return mInstance;
    }

    //This method would return the request queue
    public RequestQueue getRequestQueue() {
        if (mRequestQueue == null)
            mRequestQueue = Volley.newRequestQueue(getApplicationContext());
        return mRequestQueue;
    }

    //This method would add the request to the queue for execution
    public <T> void addToRequestQueue(Request<T> req) {
        //calling the method to get the request queue and adding the request the the queue
        getRequestQueue().add(req);
    }

    //Method to get sharedpreferences
    public SharedPreferences getSharedPreferences() {
        if (sharedPreferences == null)
            sharedPreferences = getSharedPreferences(Constants.SHARED_PREF_NAME, Context.MODE_PRIVATE);
        return sharedPreferences;
    }

    //This method will clear the sharedpreference
    //It will be called on logout
    public void logout() {
        SharedPreferences.Editor editor = getSharedPreferences().edit();
        editor.clear();
        editor.apply();
    }

    //This method will store the user data on sharedpreferences
    //It will be called on login
    public void loginUser(int id, String name, String email) {
        SharedPreferences.Editor editor = getSharedPreferences().edit();
        editor.putInt(Constants.USER_ID, id);
        editor.putString(Constants.USER_EMAIL, email);
        editor.putString(Constants.USER_NAME, name);
        editor.putBoolean(Constants.IS_LOGGED_IN, true);
        editor.apply();
    }

    //This method will check whether the user is logged in or not
    public boolean isLoggedIn() { return getSharedPreferences().getBoolean(Constants.IS_LOGGED_IN, false); }

    //This method will return the user id of logged in user
    public int getIdUser() { return getSharedPreferences().getInt(Constants.USER_ID, -1); }

    //This method will return the username of logged in user
    public String getUserName() { return getSharedPreferences().getString(Constants.USER_NAME, null); }
}