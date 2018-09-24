rem from https://blog.jayway.com/2014/09/03/creating-self-signed-certificates-with-makecert-exe-for-development/
makecert.exe ^
-n "CN=MyTestingCARoot" ^
-r ^
-pe ^
-a sha512 ^
-len 4096 ^
-cy authority ^
-sv CARoot.pvk ^
CARoot.cer

pvk2pfx.exe ^
-pvk CARoot.pvk ^
-spc CARoot.cer ^
-pfx CARoot.pfx ^
-po ""

rem SITE cett
makecert.exe ^
-n "CN=localhost" ^
-iv CARoot.pvk ^
-ic CARoot.cer ^
-pe ^
-a sha512 ^
-len 4096 ^
-b 09/19/2018 ^
-e 12/31/2018 ^
-sky exchange ^
-eku 1.3.6.1.5.5.7.3.1 ^
-sv localhost.pvk ^
localhost.cer

pvk2pfx.exe ^
-pvk localhost.pvk ^
-spc localhost.cer ^
-pfx localhost.pfx ^
-po ""

rem CLIENT cert

makecert.exe ^
-n "CN=clientcert" ^
-iv CARoot.pvk ^
-ic CARoot.cer ^
-pe ^
-a sha512 ^
-len 4096 ^
-b 09/19/2018 ^
-e 12/31/2018 ^
-sky exchange ^
-eku 1.3.6.1.5.5.7.3.2 ^
-sv clientcert.pvk ^
clientcert.cer

pvk2pfx.exe ^
-pvk clientcert.pvk ^
-spc clientcert.cer ^
-pfx clientcert.pfx ^
-po ""