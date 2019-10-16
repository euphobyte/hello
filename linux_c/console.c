/*
  Simple Linux color console program using ANSI Escape sequences
  Compile: gcc console.c -o console
  Run: ./console
  keyboard input without 'enter' thanks to stty raw, ssty cooked restores original console status.
*/

#include <stdio.h>

#define FRED  "\x1B[31m"
#define FYEL  "\x1B[33m"
#define FBLU  "\x1B[34m"
#define BCYN  "\x1B[46m"
#define RESET "\x1B[0m"
#define CLEAR "\x1B[2J"
#define HOME  "\x1B[1;1H"
#define CRON  "\x1B[?25h"
#define CROFF "\x1B[?25l"

int main(){
  int val = -1;
  printf(HOME);
  printf(BCYN);
  printf(CLEAR);
  printf(FRED "Red line\n");
  printf(FBLU "Blue line\n");
  printf(FYEL "Yellow line, enter key: ");
  system("/bin/stty raw");
  val = getchar();
  system("/bin/stty cooked");
  printf(HOME);
  printf(RESET);
  printf(CLEAR);
  return 0;
}
