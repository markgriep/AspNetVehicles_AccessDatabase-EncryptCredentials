# Read Me
---


    C:\_apps.net\vehiclefinder>c:\Windows\Microsoft.NET\Framework\v4.0.30319\aspnet_regiis.exe -pef connectionStrings c:\_apps.net\vehiclefinder
    ----------------------------------------------------------------
    Microsoft (R) ASP.NET RegIIS version 4.0.30319.0
    Administration utility to install and uninstall ASP.NET on the local machine.
    Copyright (C) Microsoft Corporation.  All rights reserved.
    Encrypting configuration section...
    Succeeded!

- Above is the command and output string to encrypt

---

_You need to have your original web.config in source control. When you encrypt, your orignal will be overwritten._

---

- Below is what it looks like before and after the encryption

BEFORE

    <connectionStrings>
    <add name="Foo" providerName="System.Data.SqlClient" connectionString="Server=.\SQL;Database=VF;User Id=sa; Password=123"/>
    </connectionStrings>


AFTER

     <connectionStrings configProtectionProvider="RsaProtectedConfigurationProvider">
        <EncryptedData Type="http://www.w3.org/2001/04/xmlenc#Element"
          xmlns="http://www.w3.org/2001/04/xmlenc#">
          <EncryptionMethod Algorithm="http://www.w3.org/2001/04/xmlenc#tripledes-cbc" />
          <KeyInfo xmlns="http://www.w3.org/2000/09/xmldsig#">
            <EncryptedKey xmlns="http://www.w3.org/2001/04/xmlenc#">
              <EncryptionMethod Algorithm="http://www.w3.org/2001/04/xmlenc#rsa-1_5" />
              <KeyInfo xmlns="http://www.w3.org/2000/09/xmldsig#">
                <KeyName>Rsa Key</KeyName>
              </KeyInfo>
              <CipherData>
                <CipherValue>JKQosH8HCdsoUyad...</CipherValue>
              </CipherData>
            </EncryptedKey>
          </KeyInfo>
          <CipherData>
            <CipherValue>RXXydjzc8tnDTpHRy8fF...</CipherValue>
          </CipherData>
        </EncryptedData>
      </connectionStrings>






# Environment setup


Some Docker commands for setting envronment and doing regression testing
Will start the SQL server

     docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=BlaPassword123' -p 1433:1433 --name sql1 -d 314
     66eb85773219e5a371cb1be807ac73eca86b9a08c66c72a3b551a95dcf6e96d9

To stop the container and remove it so you can regress 
    
    docker stop 66e
    docker rm 66e

