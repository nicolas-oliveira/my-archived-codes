package com.avishkar.listonmap.api;

import android.content.Context;
import android.util.Log;

import com.avishkar.listonmap.ResponseModel;

import java.util.List;
import java.util.concurrent.TimeUnit;

import okhttp3.Interceptor;
import okhttp3.OkHttpClient;
import okhttp3.logging.HttpLoggingInterceptor;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class ApiClinte {
    private static final String TAG = ApiClinte.class.getSimpleName();

    private static final boolean production = false;

    public static final String BASE_URL = "http://www.mocky.io";
    //public static final String BASE_URL = "http://gcol.ckmeout.com:50005/";

    public static boolean isProduction() {
        return production;
    }

    private static Retrofit retrofit = null;

    private static ApiClinte apiClient;

    public Context context;

    private static final Object mLock = new Object();

    public ApiClinte() {
    }

    public ApiClinte(Context context) {
        this.context = context;
    }

    public static ApiClinte getSingletonApiClient() {
        synchronized (mLock) {
            if (apiClient == null)
                apiClient = new ApiClinte();
            return apiClient;
        }
    }

    public static Retrofit getClient() {
        if (retrofit == null) {
            HttpLoggingInterceptor interceptor = new HttpLoggingInterceptor();
            interceptor.setLevel(HttpLoggingInterceptor.Level.BODY);

            OkHttpClient.Builder okHttpClient = new OkHttpClient().newBuilder()
                    .connectTimeout(60 * 5, TimeUnit.SECONDS)
                    .readTimeout(60 * 5, TimeUnit.SECONDS)
                    .writeTimeout(60 * 5, TimeUnit.SECONDS);

            GsonConverterFactory gsonConverterFactory = GsonConverterFactory.create();
            retrofit = new Retrofit.Builder()
                    .baseUrl(BASE_URL)
                    .client(okHttpClient.build())
                    .addConverterFactory(gsonConverterFactory)
                    .build();
        }
        return retrofit;
    }


    public void getStates(Callback<List<ResponseModel>> callback) {
        Call<List<ResponseModel>> call = null;
        try {
            ApiInterface apiService = ApiClinte.getClient().create(ApiInterface.class);
            call = apiService.getData();
            call.enqueue(callback);
        } catch (Exception e) {
            Log.e(TAG, e.toString(), e);
            callback.onFailure(call, e);
        }
    }

}