# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import socket;

s = socket.socket(socket.AF_INT, socket.SOCK_STREAM);
s.connect(('10.0.0.1', 8080));
s.sendall("Hello World!");
s.close();
