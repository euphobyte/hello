### Virual Floppy Image

In Linux on can make a virtual floppy image using the following command:

```bash
$ dd if=/dev/zero bs=512 count=2880 of=floppy.img
```
