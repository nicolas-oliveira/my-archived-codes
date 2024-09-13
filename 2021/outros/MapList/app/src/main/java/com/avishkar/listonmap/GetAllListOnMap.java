package com.avishkar.listonmap;

import androidx.annotation.Nullable;
import androidx.fragment.app.FragmentActivity;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.os.Bundle;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.avishkar.listonmap.api.ApiClinte;
import com.bumptech.glide.Glide;
import com.bumptech.glide.load.engine.GlideException;
import com.bumptech.glide.request.RequestListener;
import com.bumptech.glide.request.target.Target;
import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import de.hdodenhof.circleimageview.CircleImageView;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class GetAllListOnMap extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    private GPSTracker gpsTracker;
    public double lat, lng;
    public List<ResponseModel> data;
    public SupportMapFragment mapFragment;
    private boolean SearchFlag = false;
    private LatLng latLng = new LatLng(23.257979, 77.413513);
    public HashMap<String, String> map;
    public ArrayList<HashMap<String, String>> location = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_get_all_list_on_map);
        gpsTracker = new GPSTracker(GetAllListOnMap.this);
        mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);
        data = new ArrayList<>();
        getAllData();


    }

    private void getAllData() {
        data.clear();
        try {
            ApiClinte.getSingletonApiClient().getStates(new Callback<List<ResponseModel>>() {
                @Override
                public void onResponse(Call<List<ResponseModel>> call, Response<List<ResponseModel>> response) {
                    Log.e("REQUEST USER", new Gson().toJson(response));
                    if (response.isSuccessful()) {
                        for (int i = 0; i < response.body().size(); i++)
                            data.add(response.body().get(i));
                        mapFragment.getMapAsync(GetAllListOnMap.this);
                    } else {

                    }
                }

                @Override
                public void onFailure(Call<List<ResponseModel>> call, Throwable t) {
                    Log.d("Login Request", "Peeru Failed request : " + t.getMessage());
                    t.printStackTrace();
                }
            });
        } catch (Exception e) {
            Log.d("GetAllList", "Peeru Error Notifications :" + e.getMessage());
        }
    }

    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;
        mMap.clear();
        mMap.getUiSettings().setMyLocationButtonEnabled(true);
        mMap.getUiSettings().setZoomControlsEnabled(true);
       /* lat = gpsTracker.getLatitude();
        lng = gpsTracker.getLongitude();
        LatLng mylocation = new LatLng(lat, lng);
        mMap.addMarker(new MarkerOptions().position(mylocation).title("My Location"));
        mMap.moveCamera(CameraUpdateFactory.newLatLng(mylocation));*/

        mMap.setOnMapLoadedCallback(() -> {

            if (data.size() > 0) {
                try {

                    LatLng coordinate = new LatLng(gpsTracker.getLatitude(), gpsTracker.getLongitude());

                    mMap.setMapType(GoogleMap.MAP_TYPE_NORMAL);
                    if (SearchFlag) {
                        //  mMap.addMarker(new MarkerOptions().position(latLng).title("My Location"));
                        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng, 10));

                    } else {
                        // mMap.addMarker(new MarkerOptions().position(coordinate).title("My Location"));
                        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(coordinate, 10));
                    }

                    for (int i = 0; i < data.size(); i++) {
                        final int finalI = i;
                        final ResponseModel beanee = data.get(finalI);
                        map = new HashMap<>();
                        map.put("NAME", data.get(i).getName());
                        map.put("USER_ID", data.get(i).getId());
                        map.put("ADDRESS", data.get(i).getAddress());
                        location.add(map);
                        Glide.with(GetAllListOnMap.this)
                                .asBitmap().load(data.get(i).getImage())
                                .listener(new RequestListener<Bitmap>() {
                                              @Override
                                              public boolean onLoadFailed(@Nullable GlideException e, Object o, Target<Bitmap> target, boolean b) {
                                                  Toast.makeText(GetAllListOnMap.this, "User's not available in this Area !", Toast.LENGTH_SHORT).show();
                                                  return false;
                                              }

                                              @Override
                                              public boolean onResourceReady(Bitmap resource, Object model, Target<Bitmap> target, com.bumptech.glide.load.DataSource dataSource,
                                                                             boolean isFirstResource) {
                                                  try {

                                                      if (beanee.getLattitude().length() > 0 && beanee.getLongitude().length() > 0) {

                                                          double lat = Double.parseDouble(beanee.getLattitude());
                                                          double lon = Double.parseDouble(beanee.getLongitude());

                                                          mMap.addMarker(new MarkerOptions().
                                                                  title(beanee.getName()).
                                                                  position(new LatLng(lat, lon)).
                                                                  snippet(beanee.getAddress()).
                                                                  icon(BitmapDescriptorFactory.
                                                                          fromBitmap(createUserUpdateStatusCustomMarker(GetAllListOnMap.this, resource,
                                                                                  beanee.getName())))).setTag(beanee.getId());
                                                      }
                                                  } catch (Exception e) {

                                                  }
                                                  return false;
                                              }
                                          }
                                ).submit();
                    }
                } catch (NumberFormatException e) {
                    e.printStackTrace();
                }
            } else {
                //mMap.addMarker(new MarkerOptions().position(latLng).title("My Location"));
                LatLng coordinate = new LatLng(gpsTracker.getLatitude(), gpsTracker.getLongitude());
                mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(coordinate, 14));
                // Toast.makeText(GetAllListOnMap.this, "User's Data Not available !", Toast.LENGTH_LONG).show();
            }
        });
    }

    private Bitmap createUserUpdateStatusCustomMarker(GetAllListOnMap getAllListOnMap, Bitmap resource, String name) {

        View marker = ((LayoutInflater) this.getSystemService(Context.LAYOUT_INFLATER_SERVICE)).inflate(R.layout.layout_marker, null);

        CircleImageView markerImage = marker.findViewById(R.id.user_dp);
        TextView txt_name = marker.findViewById(R.id.name);

        markerImage.setImageBitmap(resource);
        txt_name.setText(name);

        DisplayMetrics displayMetrics = new DisplayMetrics();
        ((Activity) this).getWindowManager().getDefaultDisplay().getMetrics(displayMetrics);
        marker.setLayoutParams(new ViewGroup.LayoutParams(52, ViewGroup.LayoutParams.WRAP_CONTENT));
        marker.measure(displayMetrics.widthPixels, displayMetrics.heightPixels);
        marker.layout(0, 0, displayMetrics.widthPixels, displayMetrics.heightPixels);
        marker.buildDrawingCache();
        Bitmap bitmap = Bitmap.createBitmap(marker.getMeasuredWidth(), marker.getMeasuredHeight(), Bitmap.Config.ARGB_8888);
        Canvas canvas = new Canvas(bitmap);
        marker.draw(canvas);

        return bitmap;
    }
}
