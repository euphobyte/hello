### System shutdown

When running a server in a headless mode, sometimes located far from a persons's desktop, one wants to shut it down in a controlled 
manner. For this purpose Linux (at least a Debian style distribution) provides a special command:

```
$ sudo shutdown -P now
```

The command shuts the whole system down, that is why the sudo prefix is needed. The command "shutdown" is the actual command being 
executed by the Linux Shell. The Option -P, means poweroff and "now", means immediately.

To execute a controlled reset of the server the option -P is replaced by the option -R.  After a few minutes the reset server is 
available again. Here is the reset command:

```
$ sudo shutdown -R now
```
There is an alternative to this command which has the same functionality:

```
$ sudo reboot
```

*(Remark) When the server has been powered down, physical access is needed to the server, to reactivate it.*
