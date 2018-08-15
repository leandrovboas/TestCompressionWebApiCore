# TestCompressionWebApiCore
Teste de compressão do json no Asp .Net Core WebApi

Para usar a DLL de compressão deve installar pelo Package Manager Console
```sh
pm> Install-Package Microsoft.AspNetCore.ResponseCompression -Version 2.1.1
```
Após incluir a DLL no projeto basta adicionar no Startup.cs as linha abaixo:

No ConfigureServices deve adicionar a compressão no services
```sh
services.AddResponseCompression();
```
No Configure deve informando ao app que deve usar compressao
```sh
app.UseResponseCompression();
```

![alt text](/image/Startup.png)


### Passos para uso
- Clone este repositorio 
- Abra no Visual Studio
- Restore os packages
- Inicialize a API

### Licence
[MIT](http://opensource.org/licenses/mit-license.php).

### Autor
- [Leandro Vilas Boas](https://br.linkedin.com/in/leandro-vilas-boas-55403b2b)
