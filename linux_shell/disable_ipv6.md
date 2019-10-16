### Disable IPV6

On modern distributions of Linux IPV6 is default active. For testing purposes it is often diserable to have this diabled and only use the older IPV4 protocol.

To disable IPV6 edit the following file:

```bash
$ sudo nano /etc/sysctl.conf
```

Add the following line to the file:

```
net.ipv6.conf.all.disable_ipv6=1
```

Restart the system:

```bash
$ sudo reboot
```
