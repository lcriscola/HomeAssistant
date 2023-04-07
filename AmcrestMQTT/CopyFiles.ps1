#Copy-Item -Path .\ -Destination \\192.168.1.5\addons\amcrest2mqtt -Exclude bin,obj -Force -Recurse 

 Copy-Item -Path C:\Projects\HomeAssitant\AmcrestMQTT -Container -Destination \\192.168.1.5\addons\amcrest2mqtt\* -Force 