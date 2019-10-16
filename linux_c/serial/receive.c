// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// For simplicity there is no error handling or sanity check.

#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <termios.h>
#include <string.h>

int main(){
  unsigned char buf[6];
  memset(buf, '\0', sizeof(buf));
  int fd = open("/dev/ttyUSB0", O_RDWR);
  int n = read(fd, &buf, sizeof(buf) - 1);
  printf("Bytes read: %d\n", n);
  printf("%s\n",buf);
  close(fd);
  return 0;
}
