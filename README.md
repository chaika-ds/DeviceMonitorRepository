1. Run DevicesMonitor. 
2. The monitor will send GET reqests to EatonTest service three times for each types of device.
3. On success it will write to consol Device "type of device" get meassurements data: "device measurement"
4. If there is no measurements to current device in Devices measurements service, the request returns "NotFound" catch this Exception and pass to console - Device "type of device" measurements: NotFound
