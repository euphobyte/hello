### Debian Package Management

Package management (installation of software packages) in Debian like Linux distributions are handled by the apt-get command.
Because it is a system command the sudo prefix is needed when executing the command. The following example install the Nano Editor
package on a particular system:

```
$ sudo apt-get update
$ sudo apt-get install nano
```

It is always a good idea to first execute the update option before executing the install option

To remove the package the purge option of apt-get is used followed by autoremove and clean:

```
$ sudo apt-get purge nano
$ sudo apt-get autoremove
$ sudo clean
```

To list the installed packages on a system the dpkg command is used:

```
$ dpkg -l
```

To search for a specific package pipe the results to grep:

```
$ dpkg -l | grep nano
```
