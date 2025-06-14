INSTALACION DEL PROYECTO

1. Dentro de la solucion en el archivo appsettings.json Editar la cadena de conexión con las credenciales de su base de datos
2. Inciar migracion usando
       -add-migration nombreMigracion
       -update-database
3. En la carpeta raiz, la carpeta llamada Data sql, colocar los dos archivos en Sql Server y ejecutar los queries de cliente y orden respectivamente para llenar de datos las tablas
4. dentro de la carpeta front end en la carpeta raiz, ajustar la direccion de los endpoints en el archivo index.html (estan señalizadios con comentarios)
5. ejecutar la API 
6. Ejecutar el index.html desde live server u otro servidor http
