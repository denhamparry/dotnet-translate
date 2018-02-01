# DOTNET TRANSLATE

OpenFass proof of concept to translate some text

```bash
$ faas-cli build -f dotnet-translate.yml --parallel=1
$ faas-cli push -f dotnet-translate.yml
$ faas-cli deploy -f dotnet-translate.yml --gateway http://192.168.1.220:31112
```