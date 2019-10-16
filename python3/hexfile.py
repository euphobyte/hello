# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import os
c = '';
f = open("test.bin", 'rb');
bt = f.read(1);
while bt:
  print("%02X " % bt[0], end="");
  c += bt.decode('ASCII');
  bt = f.read(1);  
print("\r\n%s" % c);
f.close();

# Ouput:
# 48 65 6C 6C 6F 20 57 6F 72 6C 64 20 31 21 0A 48 65 6C 6C 6F 20 57 6F 72 6C 64 20 32 21 0A
# Hello World 1!
# Hello World 2!
