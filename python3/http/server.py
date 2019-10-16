# FOR EDUCATIONAL PURPOSES ONLY, DO NOT USE IN PRODUCTION
# Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.

from http.server import BaseHTTPRequestHandler,HTTPServer

class MyHandler(BaseHTTPRequestHandler):
    def do_GET(self):
        if self.path.endswith('.html'):
            self.send_response(200);
            self.send_header('Content-type', 'text/html')
            msg = "<h1>Hello World!</h1>";
        else:
            self.send_response(404);   
            msg = "";
        self.end_headers();
        self.wfile.write(bytes(msg, 'ASCII'));
    
print('Hello Server is running ...');
serv = HTTPServer(('', 8080), MyHandler);
serv.serve_forever();
