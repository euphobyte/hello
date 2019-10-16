### SSH
All major operating systems now support the SSH command, in some you need to specifically activate it (manage optional features).  *In the past one had to resort to third party software.  Fortunately this is no longer needed.* 
To access a remote headless server via SSH enter the following command from the command line:

```
> ssh username@10.0.0.1
```

The server will respond by requesting the password for this user. After login the user has commandline access to the remote server.

To end the session type the following command:

```
$ exit
```

The server responds with:

```
logout
Connection to 10.0.0.1 closed.
```
