// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// Convert 4 bytes to single precision float using an union.

#include <stdio.h>
#include <stdint.h>
#include <string.h>

float toFlt(uint8_t *);

union{
  float fl;
  uint8_t bt[4];
}spf;

int main(){
  uint8_t f1[4] = {0x00, 0x58, 0x9c, 0x45};
  memcpy(spf.bt, f1, sizeof(spf.bt));
  printf("%.1f\n", spf.fl);
  printf("%.1f\n", toFlt(f1));
}

float toFlt(uint8_t *buf){
  memcpy(spf.bt, buf, sizeof(spf.bt));
  return spf.fl;
}
