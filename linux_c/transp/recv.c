/*  FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
    Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
    Output:
    > ./recv
    Transponder: 1203.00
    Radio Nav1:   109.10
*/

#include <stdio.h>
#include <string.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>

struct dg{
  float trans;
  float nav;
};

int main(){
  struct sockaddr_in sadr;
  struct dg msg;
  int il = sizeof(sadr);
  int ssck = socket(AF_INET, SOCK_DGRAM, IPPROTO_UDP);

  memset((char *) &sadr, 0, il);
  sadr.sin_family = AF_INET;
  sadr.sin_port = htons(5001);
  sadr.sin_addr.s_addr = htonl(INADDR_ANY);

  bind(ssck , (struct sockaddr*) &sadr, il);

  recvfrom(ssck, &msg, sizeof(msg), 0, (struct sockaddr *) &sadr, &il);
  printf("Transponder: %.2f\n", msg.trans);
  printf("Radio Nav1:    %.2f\n", msg.nav);
  return 0;
}
