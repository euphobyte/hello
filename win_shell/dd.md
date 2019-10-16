### dd for Windows

Syntax for Win version of the dd command, to write a boot sector to a floppy disk:

```
> dd if=test.bin of=\\.\a: seek=0 count=1 bs=512
```
