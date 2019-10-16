### User Management

User information in Linux can be listed using this command:

``` 
$ cat /etc/passwd
```

List group information:

```
$ cat /etc/group
```

To add a new user to the system execute:

```
$ sudo useradd testuser
```

To set a new password:

```
$ sudo passwd testuser
```

To remove the user and the user's home directory

```
$ sudo userdel -r testuser
```

Add new user to the sudo group:

```
$ sudo adduser testuser sudo
```

Add user to other groups:

```
$ sudo usermod -aG audio,video testuser
```
