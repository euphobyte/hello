// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// For simplicity there is no error handling or sanity check.
// Linux (USB) serial port to MCU
// In termios attributes disable HUPCL (Hang up on close, else Hang up will auto reset MCU).
// An alternative to this program is: $ stty -F /dev/ttyUSB0 -hupcl

#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <termios.h>

int main(int argc, char* argv[]){
  struct termios tio;
  int fd = open("/dev/ttyUSB0", O_RDWR);
  tcgetattr(fd, &tio);
  tio.c_cflag &= ~HUPCL;                  // Clear hangup on close flag
  tcsetattr(fd, TCSANOW, &tio);
  close(fd);
  return 0;
}
