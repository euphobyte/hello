// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Lacks error handling and sanity checks.
// Read number of tracks on CD-A 
// Per track request entry information in the TOC in MSF (Minute, Second, Frame) format of start of track
// To calculate the duration of a track the start of the next entry is also needed.  Convert the minutes and seconds to frames
// (75 frames per second). Substract the first entry from the second entry convert frames back to MSF-format, to show the duration.

#include <fcntl.h>
#include <stdio.h>
#include <string.h>
#include <sys/ioctl.h>
#include <linux/cdrom.h>

int main(){
  struct cdrom_tochdr toc;
  struct cdrom_tocentry ent;

  int fd = open("/dev/cdrom", O_RDONLY);
  ioctl(fd, CDROMREADTOCHDR, (void*) &toc);
  printf("First track: %d\n", toc.cdth_trk0);
  printf("Last track: %d\n", toc.cdth_trk1);

  memset(&ent, 0, sizeof(ent));
  ent.cdte_track = 1;
  ent.cdte_format = CDROM_MSF;
  ioctl(fd, CDROMREADTOCENTRY, &ent);
  printf("Track 1 start: %02d:%02d:%02d\n",
    ent.cdte_addr.msf.minute,
    ent.cdte_addr.msf.second,
    ent.cdte_addr.msf.frame);
  close(fd);
}
