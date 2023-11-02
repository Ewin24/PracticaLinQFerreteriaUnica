# Requerimientos del proyecto

LA FERRETERIA UNICA UBICADA EN LA CIUDAD DE BUCARMANGA DESEA CONSTRUIR UN PROGRAMA
QUE LE PERMITA LLEVAR EL CONTROL DEL INVENTARIO Y SUS VENTAS. LA FERRETERIA CUENTA CON
LA SIGUIENTE INFORMACION:

    * PRODUCTOS : ID, NOMBRE, PRECIOUNIT, CANTIDAD,STOCKMIN Y STOCKMAX
    * CLIENTE : ID,NOMBRE,EMAIL
    * FACTURA : NRO FACT,FECHA,IDCLIENTE,    TOTAL FACTURA
    * DETALLEFACT : ID, NROFACT,IDPROD, CANTIDAD  Y VALOR

EL PROGRAMA DEVE PERMDITIR REALIZAR LAS SIGUIENTES CONSULTAS.

1. LISTAR LOS PRODUCTOS DEL INVENTARIO
2. LISTAR LOS PRODUCTOS QUE ESTAN A PUNTO DE AGOTARSE. CANTIDAD<STOCKMIN
3. LISTAR LOS PRODUCTOS QUE SE DEBEN COMPRAR Y QUE CANTIDAD DE DEBE COMPRAR
LA CANTIDAD A COMPRAR SE OBTIENE TENIENDO EN CUENTA LA DIFERENCIA ENTRE LA
CANTIDAD Y EL STOCKMAX.
4. LISTAR EL TOTAL DE FACTURAS DEL MES DE ENERO DEL 2023.
5. LISTAR LOS PRODUCTOS VENDIDOS EN UNA DETERMINADA FACTURA.
6. CALCULAR EL VALOR TOTAL DEL INVENTARIO.


FORMA DE ENTREGA
* COMPARTIR ENLACE DE REPOSITORIO
* NO SE ACEPTAN ENTREGAS POSTERIORES A LA FECHA


# Estructuracion del proyecto

```
FerreteriaUnica/
│
├── FerreteriaUnica.sln          (Solución)
│
├── FerreteriaUnica.ConsoleApp/  (Proyecto de Consola)
│   ├── Models/                  (Carpeta para modelos de datos)
│   │   ├── Producto.cs
│   │   ├── Cliente.cs
│   │   ├── Factura.cs
│   │   ├── DetalleFactura.cs
│   │
│   ├── Repositories/            (Carpeta para acceso a datos)
│   │   ├── ProductoRepository.cs
│   │   ├── ClienteRepository.cs
│   │   ├── FacturaRepository.cs
│   │   ├── DetalleFacturaRepository.cs
│   │
│   ├── Services/                (Carpeta para lógica de negocios)
│   │   ├── ProductoService.cs
│   │   ├── ClienteService.cs
│   │   ├── FacturaService.cs
│   │   ├── DetalleFacturaService.cs
│   │
│   ├── Controllers/             (Carpeta para la lógica de la interfaz de usuario)
│   │   ├── MenuController.cs
│   │
│   ├── Program.cs               (Clase principal del programa)
│
├── FerreteriaUnica.Tests/       (Proyecto de pruebas unitarias, opcional)
│   ├── ...
│
└── README.md                   (Documentación del proyecto)

```

