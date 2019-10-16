// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Presumed screen resolution is 1280 x 1024, 16 bits per pixel
// Tiny example which fills the to of the screen with 3 lines (8 lines high): white, red, green
// To activate the keyboard echo again: $ stty echo
// To activate the cursor again: $ setterm -cursor on

#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <unistd.h>
#include <linux/fb.h>
#include <sys/mman.h>
#include <string.h>
#include <termios.h>

int main(){
  // turn off cursor and keyboard echo
  struct termios t;
  tcgetattr(STDIN_FILENO, &t);
  t.c_lflag &= ~ECHO;
  tcsetattr(STDIN_FILENO, TCSANOW, &t);
  printf("\e[?25l");                      // ?25h cursor on
  fflush(stdout);

  // Write values to framebuffer
  struct fb_fix_screeninfo fi;
  int fd = open("/dev/fb0", O_RDWR);
  ioctl(fd, FBIOGET_FSCREENINFO, &fi);
  long scr = fi.smem_len;
  char *fp = (char *)mmap(0, scr, PROT_WRITE | PROT_READ, MAP_SHARED, fd, 0);
  memset((fp + 2560), 0xFF ,(2560 * 8));
  memset((fp + (2560*8)), 0xF0 ,(2560 * 8));
  memset((fp + (2560 *16)), 0x0F ,(2560 * 8));
  munmap(fp, scr);
  close(fd);
}
