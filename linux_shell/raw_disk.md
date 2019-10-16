### Raw Disk

Retrieve disk parameters:

```
$ sudo fdisk -l /dev/sda
```

Display sector 0 of disk:

```
$ sudo dd if=/dev/sda bs=512 seek=0 count=1 | hexdump -C
```
