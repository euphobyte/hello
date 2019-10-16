/* Hello World via a USB printer in Linux*/

#include <stdio.h>

int main(){
  FILE *pr = fopen("/dev/usb/lp0", "w");
  fprintf(pr, "Hello World.\n\r");
  fprintf(pr, "\f");
  fflush(pr);
  fclose(pr);
  return 0;
}
