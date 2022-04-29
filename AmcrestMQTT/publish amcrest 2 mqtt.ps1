cd AmcrestMQTT
$configContent = get-content config.json -Raw
$config = ConvertFrom-Json  -InputObject $configContent
$newVersion = [System.Convert]::ToInt32($config.version)+1
$config.version = $newVersion 
$configContent = convertto-json $config -Depth 10
$newVersion
#$configContent 
Set-Content config.json -Value $configContent 
git commit * -m "Commit on Deploy"
git push