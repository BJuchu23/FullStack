FULL STACK CHALLENGE.

Desarrollo de aplicación compuesta por API REST en .NET Core, que gestiona 
operaciones CRUD sobre un recurso sencillo de "Productos" y almacena información
en una base de datos local.
Está API se consume por una interfaz web que permite visualizar la lista de elementos,
consultar detalles, crear registros, editarlos y eliminarlos de forma interactiva desde
la aplicación web

1. Características.
   
   -Creación de productos.
   
   -Edición de productos existentes.
   
   -Detalle de productos.
   
   -Lista de productos.
   
   -Borrar productos.
   
3. Tecnologías.

   -React.
   
   -Mongo DB.
   
   -.Net Core
   
5. Capturas.
6. Bonus Implementados.

   -Documentación de la API: en este caso la documentación de la API fue implementada utilizando
   Scalar.AspNetCore, el cual genera automáticamente la especificación OpenAPI y una interfaz
   interactiva para exporar los endopoints, equivalente a SwaggerUI.

<img width="1908" height="870" alt="image" src="https://github.com/user-attachments/assets/55d27d5d-ec2e-4e5d-b92e-67f99af71610" />

// En la foto se muestra la vista de la documentación donde se listan las operaciones disponibles sobre el recurso "Product"



  -Utilizar Dependecy Injection en el controlador:Constructor del controlador. 
  
  ILogger<ProductController> también se inyecta automáticamente.

   -Utilizar Dependecy Injection: Uso dentro del controlador: 

   Todas las llamadas a _productService se hacen a través de la instancia inyectada.

  <img width="1210" height="463" alt="image" src="https://github.com/user-attachments/assets/57a7b9ce-0aa6-41be-9a1f-d346f15ec8f5" />
  // Demostración en el código. 


  
  
  

