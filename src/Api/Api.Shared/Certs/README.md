Keys taken from https://github.com/grpc/grpc/tree/master/src/core/tsi/test_creds so that interop server in this project is compatible with interop clients implemented in other gRPC languages.

The server1.pem and server1.key were combined into server1.pfx. The password is 1111. These certs are not secure, do not use in production.
```
openssl pkcs12 -export -out server1.pfx -inkey server1.key -in server1.pem -certfile ca.pem
```

Show validation values by following command:

```shell
cert="src/Api/Api.Shared/Certs/server.pem"
cat <<EOF
  * fingerprint(w/o colon): $(openssl x509 -in "$cert" -fingerprint -noout | sed 's/SHA1 Fingerprint=//g' | tr -d ':')
  * public key(base64): $(openssl x509 -in "$cert" -pubkey -noout | openssl rsa -pubin -RSAPublicKey_out -outform DER | base64 -w 0)
  * EKU(OID): $(openssl x509 -in "$cert" -noout -text -certopt no_aux | grep -A1 "X509v3 Extended Key Usage" | tail -n 1 | sed 's/^\s*//g')
  * Subject: $(openssl x509 -in "$cert" -subject -noout)
  * Issuer: $(openssl x509 -in "$cert" -issuer -noout)
EOF
```

```
  * fingerprint(w/o colon): 9509EF058384BD0C7AA89FF3B804823477BEEC07
  * public key(base64): MIIBCgKCAQEAsGL0oXflF0LzoM+Bh+qUU9yhqzw2w8OOX5mu/iNCyUOBrqaHi7mGHx73GD01diNzCzvlcQqdNIH6NQSL7DTpBjca66jYT9u73vZe2MDrr1nVbuLvfu9850cdxiUOInv5xf8+sTHG0C+a+VAvMhsLiRjsq+lXKRJyk5zkbbsETybqpxoJ+K7CoSy3yc/kQIY3TipwEtwkKP4hzyo6KiGd/DPexie4nBUInN3bS1BUeNZ5zeaIC2eg3bkeeW7cqT55b+Yen6CxY0TEkzBK6AKt/WUialKMgT0wbTxRZO7kUCH3Sq6e/wXeFdJ+HvdVLPlAg5TnMaNpRdQih/8nRFpsdwIDAQAB
  * EKU(OID):
  * Subject: subject=C = AU, ST = Some-State, O = Internet Widgits Pty Ltd, CN = testca
  * Issuer: issuer=C = AU, ST = Some-State, O = Internet Widgits Pty Ltd, CN = testc
```
