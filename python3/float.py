# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.
# Convert single precision float to 32 bits binary and back to single precsision float

import struct;

a = 3.14
print("Convert float:  {:f}".format(a));
bytes = struct.pack('f', a);
buf = "";
for i in range(4):
  buf += '{:02x} '.format(ord(bytes[i]));
print("To 32bit value: " + buf);
b = struct.unpack("f", bytes);
print("Back to float:  {:f}".format(b[0]));

# Result:
# Convert float:  3.140000
# To 32bit value: c3 f5 48 40
# Back to float:  3.140000
