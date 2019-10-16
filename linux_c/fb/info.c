// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Get screen information from the Linux screen buffer.
// Basic example without any error handling.

#include <stdio.h>
#include <fcntl.h>
#include <linux/fb.h>

int main(){
  int fbfd = 0;
  struct fb_var_screeninfo vinfo;
  fbfd = open("/dev/fb0", O_RDWR);
  ioctl(fbfd, FBIOGET_VSCREENINFO, &vinfo);
  printf("Horizontal resolution : %d\n", vinfo.xres);
  printf("Vertical resolution   : %d\n", vinfo.yres);
  printf("Bits per pixel        : %d\n", vinfo.bits_per_pixel);
  close(fbfd);
}
