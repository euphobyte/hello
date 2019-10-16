/* 
  Compile: gcc pointer.c -o pointer
   Run: ./pointer
*/

#include <stdio.h>

int main(){
  int i = 3;
  int *p;
  p = &i;
  printf("val of i: %d\n", *p);
  printf("val of p: %8X\n", p);
  *p = 8;
  printf("val of i: %d\n", i);
  printf("val of p: %08X\n", p);
  return 0;
}

/*
  Result:
    $ ./pointer
    val of i: 3
    val of p: AAA82150
    val of i: 8
    val of p: AAA82150
*/
