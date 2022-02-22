# Design-Patterns
Design patterns are solutions to software design problems you find again and again in real-world application development. Patterns are about reusable designs and interactions of objects.

# App's structure
Pick-Up App

Moodulo de configuracion: [Setting's module]

	-Mantenimiento de categorias. [Product's type maintenance]
	-Mantenimiento de productos. [Product's maintenance]


Modulo principal: [Principal module]

	-Hacer pick up list. [Pick-Up List Recorder]
		*Selecciona segun la categoria, los productos y se agreguen al carrito*
		*[Choose one by one depending on the category of the product, and then, it is add to the buying list]*
	-Filtrar productos por categoria. [Product's category filter]

Mudulo secundario: [Secundary module]

	-Ver/Editar carrito. [Go to/Edit buying list]
	-Pagar/Limpiar carrito. [Buy/clean buying list]

Patrones de diseño implementados: [design-patterns implemented]

	-Facade
	-Factory
	-Singleton
