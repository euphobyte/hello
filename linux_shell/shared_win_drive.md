### Mount shared windows drive

In order to mount a shared window drive with the IP address 10.0.0.1 and a shared directory 'share', enter the following command:

```
$ sudo mount -t cifs  -o username=user //10.0.0.1/share /mnt
```

Then change the active working directory to /mnt to access the files in the shared disk and directory.
