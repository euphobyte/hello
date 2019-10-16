// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

#include<stdio.h>
#include<unistd.h>
#include<string.h>
#include<arpa/inet.h>
#include<sys/socket.h>
#define ADLEN 15
#define MSLEN 80

int main(void){

  struct sockaddr_in si1;
  struct in_addr ia1;

  char addr[ADLEN];
  char msg[MSLEN];
  
  memset((char *) &si1, 0, sizeof(si1));
  si1.sin_family = AF_INET;
  si1.sin_port = htons(1234);
  strcpy(addr, "10.0.0.1");
  puts(addr);
  inet_pton(AF_INET, addr, &ia1);
  printf("address: %08X\n", ia1);
  si1.sin_addr = ia1;

  int s1 = socket(AF_INET, SOCK_DGRAM, IPPROTO_UDP);
  printf("socket: %d\n", s1);
  strcpy(msg, "Hello World!");
  int res1 = sendto(s1, msg, strlen(msg) , 0 , (struct sockaddr *) &si1,  sizeof(si1));
  printf("Sent result: %d\n", res1);

  close(s1);
  return 0;
}
