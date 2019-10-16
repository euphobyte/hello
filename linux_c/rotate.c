// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
// This functionality is needed for a display routine of a display which is rotated 90 degrees.
// Compile: $ gcc -o rotate rotate.c
// Run: $ ./rotate

#include <stdio.h>
#include <stdint.h>       // needed for type uint8_t
#include <string.h>       // needed for memset()

void display(uint8_t*);   // declaration of display function # = 1, . = 0

uint8_t fnt[8] = {        // Bitmap array to be rotated
        0b11001100,
        0b11001100,
        0b11001100,
        0b11001100,
        0b11001100,
        0b11001100,
        0b11000000,
        0b11001100
};

uint8_t nfnt[8];

int main(){
  int tst = 0;
  memset(nfnt, 0, sizeof(nfnt));
  display(fnt);                       // Display original array
  for(int i = 0; i < 8; i++){         // rotate bits from source to destination array
    for(int j=0; j < 8; j++){         // source array is fnt, destination is nfnt
      tst = fnt[i] >> (7 - j) & 1;    // Check if next bit in byte is set
      nfnt[j] = (nfnt[j] << 1)| tst;  // Set next bit in new byte depending on tst value (0,1)
    }
  }
  display(nfnt);                      // Display new array (bits rotated 90 degrees)
  return 0;
}

void display(uint8_t* arr){           // Function to display bits in array of bytes
  for(int j = 0; j < 8 ; j++){
    for(int i=0; i < 8; i++){
      if((*arr >> 7 - i) & 1)
        printf("#");
      else
        printf(".");
    }
    *arr++;
    printf("\n");
  }
  printf("\n");
}
