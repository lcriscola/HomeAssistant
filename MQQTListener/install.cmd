sc.exe delete MQTTListenerAppLauncher 
sc.exe create MQTTListenerAppLauncher binpath= c:\Projects\HomeAssitant\MQQTListener\bin\Release\net6.0\MQQTListener.exe type= share start= auto DisplayName= "Listen to MQTT Messages and launches applications"
sc config MQTTListenerAppLauncher obj= ".\Luciano" password= "Monitor02"
sc start MQTTListenerAppLauncher