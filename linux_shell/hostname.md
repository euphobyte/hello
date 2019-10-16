### Network hostname

To change the hostname for a server in a network. Modify the file /etc/hosts:

```
$ sudo nano /etc/hosts
```

* edit: 127.0.0.1

Also modify the file /etc/hostname:

```
$ sudo nano /etc/hostname
```

* edit name

Apply the changes made to the current environment:

```
$ sudo /etc/init.d/hostname.sh

$ sudo reboot
```
