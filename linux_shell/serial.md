### Serial Port
Write data to serial port from command shell, with newline (-e option):

```bash
$ echo -e "Hello World!\r" > /dev/ttyUSB0
```
Without newline (-ne option):

```bash
$ echo -ne "Hello World!\r" > /dev/ttyUSB0
```

This can be used in teletype mode to update a string at a static location.
