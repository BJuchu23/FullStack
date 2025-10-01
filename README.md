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
   
   -Lista de Productos / Vista Principal.
   <img width="1255" height="632" alt="image" src="https://github.com/user-attachments/assets/04f3cfc6-4259-44e2-b72b-4330e219a74f" />

   -Creación de Producto.
   <img width="1600" height="336" alt="image" src="https://github.com/user-attachments/assets/c328444c-036b-4cb2-8974-996da500befa" />


   -Editar Producto.
   <img width="1600" height="461" alt="image" src="https://github.com/user-attachments/assets/7e31d38e-aa4d-4fd3-a756-a055c6c152b6" />


   -Detalle de Producto.
   <img width="907" height="424" alt="image" src="https://github.com/user-attachments/assets/a57ad7ca-3664-4084-aa3c-512e4ab11f0c" />


   -Borrar productos.
   
   <img width="580" height="329" alt="image" src="https://github.com/user-attachments/assets/32f1c006-ec71-415e-bdb2-d7bcfc23e19e" />

Nota Importante: Durante el desarrollo de la interfaz se consideró la incorporación de TailwindCSS como framework de estilos con el fin de mejorar la presentación visual. Sin embargo, debido a limitaciones en la configuración del entorno, la integración no se mantuvo activa en la versión final del proyecto.

A pesar de ello, la aplicación en React cumple plenamente con los requerimientos funcionales solicitados, y se deja planteada la posibilidad de integrar un framework de estilos en futuras versiones para optimizar la experiencia visual.

   
7. Bonus Implementados.

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


  
  
  

