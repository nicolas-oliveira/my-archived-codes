package com.example.locationbasedapp;

import java.text.SimpleDateFormat;
import java.util.TimeZone;

import android.location.Location;

public class LogHelper {

	static final String _timestampformat= "yyyy-MM-dd'T'HH:mm:ss";
	static final String _timestampzoned="UTC";
	
	public static String FormatLocationInfo(String provider,double lat,double logn, float accuracy,long time)
	{
		SimpleDateFormat timestampformat=new SimpleDateFormat(_timestampformat);
		timestampformat.setTimeZone(TimeZone.getTimeZone(_timestampzoned));
		
		String Timestamp= timestampformat.format(time);
		
		String logmsg= String.format("%s | lat/logn=%f/%f | accuracy=%f | Time=%s", provider,lat,logn,accuracy,time);
		
		return logmsg;
	
	}
	
	public static String FormatLocationInfo(Location location)
	{
		String provider= location.getProvider();
		double lat= location.getLatitude();
		double log =location.getLongitude();
		float accuracy=location.getAccuracy();
		long time=location.getTime();
		
		return LogHelper.FormatLocationInfo(provider, lat, log, accuracy, time);
	}
}
