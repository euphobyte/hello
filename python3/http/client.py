# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

import urllib.request;

url = 'http://10.0.0.1:8080/test.html';
dat = """<Envelope xmlns="http://schemas.xmlsoap.org/soap/envelope/">
<test>
Hello World!
</test>
</Envelope>
"""
req = urllib.request.urlopen(url, bytes(dat,'ASCII'));
req.add_header('Cache-Control', 'no-cache');
st = req.read().decode('ASCII');
print(st);
