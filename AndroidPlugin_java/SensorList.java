package com.example.sensorlist;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorManager;

import java.util.ArrayList;
import java.util.List;

public class SensorList
{
    public static String getSensorNames(Context context)
    {
        SensorManager sensorManager = (SensorManager)context.getSystemService(Context.SENSOR_SERVICE);
        List<Sensor> sensorList = sensorManager.getSensorList(Sensor.TYPE_ALL);

        String sensorName = "";
        int count = 0;
        for(Sensor sensor :sensorList)
        {
            sensorName += sensor.getName();
            if(count < (sensorList.size() - 1))
            {
                sensorName += ",";
                count++;
            }
        }

        return sensorName;
    }

    public static String getSensorTypes(Context context)
    {
        SensorManager sensorManager = (SensorManager)context.getSystemService(Context.SENSOR_SERVICE);
        List<Sensor> sensorList = sensorManager.getSensorList(Sensor.TYPE_ALL);

        String sensorType = "";
        int count = 0;
        for(Sensor sensor :sensorList)
        {
            sensorType += sensor.getType();
            if(count < (sensorList.size() - 1))
            {
                sensorType += ",";
                count++;
            }
        }

        return sensorType;
    }
}
