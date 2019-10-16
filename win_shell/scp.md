### SCP Secure Copy

To copy a file from the remote server to the local computer, enter the following command:
```
> scp username@10.0.0.1:~/subdir/source/test.txt .
```
The file test.txt is now securely copied from the home directory of user username to the current directory on the local computer.

To copy a local file test.txt to the home directory of the user on the remote server, execute the following command:
```
> scp test.txt username@10.0.0.1:~
```
