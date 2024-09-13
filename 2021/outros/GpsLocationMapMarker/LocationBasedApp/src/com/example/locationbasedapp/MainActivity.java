package com.example.locationbasedapp;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.MapView;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.android.maps.MapActivity;

import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.location.LocationProvider;
import android.net.wifi.WifiManager;
import android.os.Bundle;
import android.app.Activity;
import android.app.PendingIntent;
import android.support.v4.app.FragmentActivity;
import android.util.Log;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;

public class MainActivity extends FragmentActivity {

	final String log_Tag= "Monitor Location";
	LocationListener _gpsProvider;
	LocationListener _networkProvider;
	GoogleMap map;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	
	}

	 @Override
	    public boolean onCreateOptionsMenu(Menu menu){
	        MenuInflater inflater = getMenuInflater() ;
	        inflater.inflate(R.menu.main, menu) ;
	        return true;
	    }

	public void onStartListening(MenuItem item)
	{
		Log.d(log_Tag,"Monitor - Start Listening");
		
		try {
			LocationManager lm=(LocationManager)getSystemService(LOCATION_SERVICE);
			Location loc;
			WifiManager wm = (WifiManager) getSystemService(WIFI_SERVICE);

			if (wm.isWifiEnabled()) {
			   // wm.setWifiEnabled(true);
			   //Or do what you want in disable mode
				_networkProvider = new MyLocationListener();
				lm.requestLocationUpdates(LocationManager.NETWORK_PROVIDER,0,0,_networkProvider);
				
				loc=lm.getLastKnownLocation(LocationManager.NETWORK_PROVIDER);
			
			} else {
			    // wm.setWifiEnabled(false);
			    //Or do what you want in enable mode
				_gpsProvider = new MyLocationListener();
				lm.requestLocationUpdates(LocationManager.GPS_PROVIDER,0,0,_gpsProvider);
				
				loc=lm.getLastKnownLocation(LocationManager.GPS_PROVIDER);
		
			}
				
			//Plotting marker
		   PlotMarker(loc.getLatitude(), loc.getLongitude());
		   
		   //Zooming in the marker
		   LatLng ltlng=new LatLng(loc.getLatitude(), loc.getLongitude());
		   moveToCurrentLocation(ltlng);
			
			
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void onStopListening(MenuItem item)
	{
		Log.d(log_Tag,"Monitor - Stop Listening");
		DoStopListening();
	}
	
	public void onRecentLocation(MenuItem item)
	{
		Log.d(log_Tag,"Monitor - Recent Location");
	}
	
	 public void onSingleLocation(MenuItem item) {
	        Log.d(log_Tag, "Monitor - Single Location");

	    }
	 
	public void onExit(MenuItem item)
	{
		DoStopListening();
		finish();
	}
	
	void DoStopListening()
	{
		LocationManager lm=(LocationManager)getSystemService(LOCATION_SERVICE);
		
		  if (_networkProvider != null) {
	            lm.removeUpdates(_networkProvider);
	            _networkProvider = null;
	        }
	        if (_gpsProvider != null) {
	            lm.removeUpdates(_gpsProvider);
	            _gpsProvider = null;
	        }
		
	}

	void PlotMarker(double lat, double lang)
	{
		SupportMapFragment smf = (SupportMapFragment)getSupportFragmentManager().findFragmentById(R.id.map);
        if (smf != null) {
            map = smf.getMap();
        }
        
        if(map!=null)
        {
        Marker marker = map.addMarker(new MarkerOptions()
        .position(new LatLng(lat, lang))
        .title("Home")
        .snippet("G-6/4")
        .icon(BitmapDescriptorFactory.fromResource(R.drawable.marker)));
        
      
        
        }
        
        
        
        
		
	}
	
	public void moveToCurrentLocation(LatLng currentLocation)
    {   
        map.moveCamera(CameraUpdateFactory.newLatLngZoom(currentLocation,15));
        // Zoom in, animating the camera.
        map.animateCamera(CameraUpdateFactory.zoomIn());
        // Zoom out to zoom level 10, animating with a duration of 2 seconds.
        map.animateCamera(CameraUpdateFactory.zoomTo(15), 2000, null);


    }
	
}
