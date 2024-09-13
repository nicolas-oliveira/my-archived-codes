package com.example.locationbasedapp;

import java.util.TimeZone;

import android.location.Location;
import android.location.LocationListener;
import android.os.Bundle;
import android.util.Log;

public class MyLocationListener implements LocationListener{

	public final String log_tag="mylogtag";
	@Override
	public void onLocationChanged(Location location) {
		// TODO Auto-generated method stub
		String provider= location.getProvider();
		double lat= location.getLatitude();
		double log =location.getLongitude();
		float accuracy=location.getAccuracy();
		long time=location.getTime();
		
		String logmesage=LogHelper.FormatLocationInfo(provider, lat, log, accuracy, time);
		
		Log.d(log_tag, "Monitor Location :"+logmesage);
	}

	@Override
	public void onProviderDisabled(String provider) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void onProviderEnabled(String provider) {
		// TODO Auto-generated method stub
		Log.d(log_tag, "Provider Enabled :"+ provider);
	}

	@Override
	public void onStatusChanged(String provider, int status, Bundle extras) {
		// TODO Auto-generated method stub
		Log.d(log_tag, "Provider Disabled :"+ provider);
	}

}
