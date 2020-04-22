# Run: python hello.py
# Result:
# Hello World! 0
#
# Hello World! 1
# 
# Hello World! 2
# To have only a single newline remove '\n' from print statement
# Variable at the end adds an automatic newline
# To print everything on one line add a ',' after the variable at the end of the print statement

for x in range(0, 3):
  print "Hello World! %d\n" % (x)
