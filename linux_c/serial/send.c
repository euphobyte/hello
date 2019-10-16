// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// For simplicity there is no error handling or sanity check.
// Linux (USB) serial port to MCU

#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <termios.h>
#include <string.h>

int main(int argc, char* argv[]){
  struct termios tio;
  int fd = open("/dev/ttyUSB0", O_RDWR | O_NOCTTY);
  memset(&tio, 0, sizeof(tio));
  tcgetattr(fd, &tio);
  cfsetispeed(&tio, B9600);
  cfsetospeed(&tio, B9600);
  tio.c_cflag = tio.c_cflag & ~CSIZE |  CS8 & ~CSTOPB & ~PARENB;
  tcsetattr(fd, TCSANOW, &tio);
  if(argc > 1){
    write(fd, "\n", 1);
    write(fd, argv[1], strlen(argv[1]));
  }else{
    char buf[] = "\nHello World!";
    write(fd, buf, sizeof(buf));
  }
  close(fd);
  return 0;
}
