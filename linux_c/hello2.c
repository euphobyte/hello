/*
  Compile: gcc hello2.c
  Run: ./hello2
*/

#include <stdio.h>
#define BSIZE 10

int main(){
  char sz[BSIZE];
  printf("Your name, please: ");
  fgets(sz, BSIZE, stdin);
  printf("Hi: ");
  puts(sz);
  printf("\n");
  return 0;
}
