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
	1. Indica el tipo de excepción que se llevó a cabo, la descripción del error y en que linea sucedió.
	2. Indica el tipo de excepción que se llevó a cabo, el mensaje de error que haya escrito el programador, la descripción del error, la linea en la que se produjo el error y la linea en la que sucedió la excepción.
	3. Indica el tipo de excepción que se llevó a cabo, el mensaje de error que haya escrito el programador y la linea en la que sucedió la excepción.
	4. Indica el tipo de excepción que se llevó a cabo, la descripción del error y la linea en la que sucedió la excepción.

- Sea el código:
	```
	FuncionLLamadoraA();

        FuncionLLamadoraB();

        void FuncionLLamadoraA()
        {
            Dividir(3, 3);
        }

        void FuncionLLamadoraB()
        {
             Dividir(3, 0);
        }

        void Dividir(int a, int b)
        {
            try
            {
                int c = a / b;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
	```
	El código indica que la excepción se causó en la linea ```FuncionLLamadoraB();```, ocasionada por la linea ```Dividir(3, 0);```, y que ésta falló debido que se ejecutó la linea ```int c = a / b;```.
