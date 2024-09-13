package com.avishkar.listonmap.api;

import com.avishkar.listonmap.ResponseModel;

import java.util.List;

import retrofit2.Call;
import retrofit2.Response;
import retrofit2.http.GET;
import retrofit2.http.Headers;

public interface ApiInterface {

    @Headers("Content-Type: application/json")
    @GET("/v2/5e11ef233100005a37593fa2")
    Call<List<ResponseModel>> getData();
}

