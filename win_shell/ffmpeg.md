### Convert to MP4

Convert a .ts captured stream to an MP4 file, skipping specific parts:

* -i  - input file
* -c  - :v (video) libx264 :a (audio) aac
* -ss - start (hh:mm:ss)
* -t  - duration (hh:mm:ss)

```
ffmpeg -i input1.ts -c:v libx264 -c:a aac -ss 00:05:00 -t 01:35:20 -async 1 output1.mp4
```

As above without reencoding just muxing to mp4:

```
ffmpeg -i input2.ts -c:v copy -c:a copy ss 00:05:00 -t 01:35:20 -async 1 output2.mp4
```
