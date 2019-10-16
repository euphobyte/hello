### Get Serial USB device Id
Retrieve serial id by executing the following command before and after plugging in an USB Serial port device:

```
$ ls -lA /dev/serial/by-id
output:
total 0
lrwxrwxrwx 1 root root 13 apr 23 11:32 usb-0000_USB2.0-Serial-if00-port0 -> ../../ttyUSB0
``` 
