# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import socket;

sck = socket.socket(socket.AF_INET, socket.SOCK_DGRAM);
sck.bind(('', 9012));
res = "";
asc = "";
cnt = 0;
(msg, sa) = sck.recvfrom(512);
for b in msg:
  res += b.encode("HEX") + " ";
  bt = 0;
  bt = ord(b);
  if(bt > 32 and bt < 128):
    asc += chr(bt);
  else:
    asc += ".";
  cnt+=1;
  if(cnt == 16):
    res += asc + "\r\n";
    asc = "";
    cnt = 0;
print(res);
