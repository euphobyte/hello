### IMAP via OpenSSL

*FOR EDUCATIONAL PURPOSES ONLY*
*Source code is provided as-is without warranty, and disclaiming liability for damages resulting from using the source code.*

Example IMAP session which retrieves a list of inboxes and then logs out:

```
$ openssl s_client -crlf -connect imap.mail.eu:993

a1 LOGIN user@mail.eu password
  a1 OK user@mail.eu authenticated (Success)
a1 LIST "" "*"
  * LIST (\HasNoChildren) "/" "INBOX"
  * LIST (\HasNoChildren) "/" "Test"
  a1 OK Success
a1 STATUS INBOX (MESSAGES)
  * STATUS INBOX (MESSAGES 5)
  a1 OK STATUS complete
a1 LOGOUT
  * BYE LOGOUT Requested
  a1 OK (Success)
  read:errno=0
```

*The indented lines are the responses from the email server.*
