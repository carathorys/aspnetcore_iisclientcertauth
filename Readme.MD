# ASP.NET Core IIS Client Certificate Authentication module

To set up, please modify the [web.config](IISClientCertAuthProject/web.config) file before publishing the project, as I added some placeholders, like 
`__COMPANYDOMAIN__`
`__USERNAME__`
`__PASSWORD__`

Without setting these parameters, it won't try to authenticate a valid AD user.

The client certificate which I used is just a development certificate, it's in the [dev_certs](dev_certs) folder, 
so you can try it, or generate a new one (it has no password).
