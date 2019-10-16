# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import socket;

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM);
s.bind(('', 8080));
s.listen(8);
cs = s.accept();
msg = cs.recv(20);
print msg;
cs.close();
s.close();
