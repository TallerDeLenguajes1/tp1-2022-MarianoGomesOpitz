# Ejercicio 4)

- La diferencia entre las distintas maneras de realizar un throw son las siguientes:
	```
	catch(Exception ex)
	{
	   throw;
	   throw new AlgunaExcepcion("mensaje de error 1", ex);
	   throw new AlgunaExcepcion("mensaje de error 2");
	   throw ex;
	}
	```
	* Indica el tipo de excepción que se llevó a cabo, la descripción del error y en que linea sucedió.
	* Indica el tipo de excepción que se llevó a cabo, el mensaje de error que haya escrito el programador, la descripción del error, la linea en la que se produjo el error y la linea en la que sucedió la excepción.
	* Indica el tipo de excepción que se llevó a cabo, el mensaje de error que haya escrito el programador y la linea en la que sucedió la excepción.
	* Indica el tipo de excepción que se llevó a cabo, la descripción del error y la linea en la que sucedió la excepción.