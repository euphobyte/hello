### USB information

In order to list the USB devices of a system:

```
$ lsusb
Bus 001 Device 001: ID 1d6b:0002 Linux Foundation 2.0 root hub
```

To get detailed information for a specific USB-device:

```
$ lsusb -D /dev/bus/usb/001/001
Device Descriptor:
  bLength                18
  bDescriptorType         1
  bcdUSB               2.00
  bDeviceClass            9 Hub
  bDeviceSubClass         0 Unused
  ...
```

To retrieve the device hierarchy as tree:

```
$ lsusb -t
/:  Bus 01.Port 1: Dev 1, Class=root_hub, Driver=dwc_otg/1p, 480M
```
