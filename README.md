# Challenge

### Requisitos:

```
Se debe realizar usando un rest API en .net Core (última version)
Se deben usar patrones (ejemplo: mediator pattern, etc)
Se debe desarrollar usando TDD.
Se debe usar buenos patrones para las validaciones del request
Se debe usar una estructura de proyecto de n-capas
```

### Enunciado:

```
• Actualmente se tiene la parte web de un sistema de registro de Productos y se desea hacer un servicio que soporte sus funcionalidades.
• El servicio debe permitir INSERT (post), UPDATE (put) y GETBYID (get) de un maestro / detalle de productos.
• Se debe poder loguear el tiempo de respuesta de cada servicio en un archivo de texto plano.
• Se debe poder grabar la información del producto localmente (cualquier tipo de persistencia)
    • La Lista de campos será definido por la persona evaluada (maestro y detalle).
• 2 campos del objeto maestro debe venir del Cache de la aplicación.
    • Se puede usar Cache estándar o Lazy Cache (o cualquiera que crea pertinente).
• Se debe poder traer información de un servicio externo para devolver información del producto
    • Usar https://retool.com/ u otro, para generar el mock del servicio externo
    • Se deberá enviar el id del producto y traer información complementaria del producto.
• La Lista de campos será definido por la persona evaluada.
• El objeto response del metodo GetById
    • maestro: data bd local + data cache + data servicio externo
    • detalle: data bd local.
```

*Created by Rodrigo Saraya - 2021*
