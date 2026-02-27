//A - O código A , pois ele checa primeiro o numero digitado para depois imprimir, no código B, a checagem ocorre só depois da impressão

using System; 
public class Codigo { 
    public static void main(String[] args) { 

      Scanner teclado = new Scanner(); 

       int codigo; 

    Console.WriteLine("Informe o código: "); 
    codigo = teclado.nextInt(); 

        while (codigo != -1) { // a checagem é feita antes da impressão dos dados

    Console.WriteLine("Código: " + codigo); 
    Console.WriteLine("Informe o código: "); 

    codigo = teclado.nextInt(); 
} 
} 
}	   

    /*Programa	B	
    using System; 
        public class Codigo { 
        public static void main(String[] args) { 

            Scanner teclado = new Scanner(); 
            int codigo; 
        
    do {    
        Console.WriteLine("Informe o código: "); 
        codigo = teclado.nextInt(); 

        Console.WriteLine("Código: " + codigo); 

} while (codigo != -1); ( A checagem é feita após a impressão)
} 
} 
*/

//B- Basta retirar o DO do código B