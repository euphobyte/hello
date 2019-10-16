# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import socket;
from struct import *;
import sys;

buf = "";
sck = socket.socket(socket.AF_INET, socket.SOCK_RAW, socket.IPPROTO_TCP);
buf = sck.recv(2048);
res = "";
cnt = 0;
print(len(buf));
for i in range(len(buf)):
  res += '{:02X} '.format(ord(buf[i]));
  cnt += 1;
  if cnt == 16:
    print(res);
    res = "";
    cnt = 0;
print(res);
