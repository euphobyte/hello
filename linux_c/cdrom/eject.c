// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Lacks error handling and sanity checks.
// Minimal example, without error checking, to eject CD using Linux IOCTL.
// Comparabel examples can be made for the commands: CDROMPAUSE, CDROMRESUME, CDROMSTOP, CDROMSTART

#include <stdio.h>
#include <fcntl.h>
#include <sys/ioctl.h>
#include <linux/cdrom.h>
int main(){
  printf("Ejecting ...");
  int fd = open("/dev/cdrom", O_RDONLY | O_NONBLOCK);
  ioctl(fd, CDROMEJECT, 0);
  close(fd);
}
