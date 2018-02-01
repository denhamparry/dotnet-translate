# DOTNET TRANSLATE

OpenFass proof of concept to translate some text

### Setup

```bash
$ faas-cli build -f dotnet-translate.yml --parallel=1
$ faas-cli push -f dotnet-translate.yml
$ faas-cli deploy -f dotnet-translate.yml --gateway http://192.168.1.220:31112
$ faas-cli rm -f dotnet-translate.yml  --gateway http://192.168.1.220:31112
```

## Useage

This%20is%20some%20sample%20text