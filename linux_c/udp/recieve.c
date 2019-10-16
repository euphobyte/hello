// FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
// Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

#include<stdio.h>
#include<unistd.h>
#include<string.h>
#include<arpa/inet.h>
#include<sys/socket.h>
#define MSLEN 80

int main(void){

  struct sockaddr_in sa1;
  int sl1 = sizeof(sa1);

  char msg[MSLEN];
  
  int s1 = socket(AF_INET, SOCK_DGRAM, IPPROTO_UDP);

  memset((char *) &sa1, 0, sl1);
  sa1.sin_family = AF_INET;
  sa1.sin_port = htons(1234);
  sa1.sin_addr.s_addr = htonl(INADDR_ANY);
  bind(s1 , (struct sockaddr*)&sa1, sl1);

  recvfrom(s1, msg, MSLEN, 0, (struct sockaddr *) &sa1, &sl1);
  puts(msg);
  
  close(s1);
  return 0;
}
