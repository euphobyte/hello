### Java Service (Daemon)

Running a java program as a service in Linux:

```
$ nohup java -jar example.jar > example.log 2> example.err < /dev/null &
```
To retrieve the process id:

```
$ echo $!
```
To end the program:

```
$ kill (retrieved process id)
```
