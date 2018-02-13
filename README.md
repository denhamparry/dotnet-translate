# DOTNET TRANSLATE

OpenFass proof of concept to translate some text

### Setup

* Build the code on Mac or PC:

```sh
$ faas-cli build -f dotnet-translate.yml --parallel=1
$ faas-cli push -f dotnet-translate.yml
```

* Execute command when connected to OpenFaaS:

```sh
$ faas-cli deploy -f dotnet-translate.yml --gateway http://192.168.123.200:31112
$ faas-cli rm -f dotnet-translate.yml  --gateway http://192.168.123.200:31112
```
