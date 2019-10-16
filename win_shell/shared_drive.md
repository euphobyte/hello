### Shared Drive

To connect to a remote server from File Explorer, type in the path to the shared directory on the server:

```
\\10.0.0.1\temp 
```

*You now have to login to the server.*

To remove this connection to the server:

```
> net use \\10.0.0.1\temp$ /delete 
```
