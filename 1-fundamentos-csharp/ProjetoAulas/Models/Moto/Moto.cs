namespace ProjetoAulas.Models.Moto
{ 

    abstract class Moto
    { 
        // Qualquer um pode chamar um método public
        public void IniciarPartida()  
        { 

            /* Instruções do método aqui */  
        } 

        // Somente classes derivadas podem chamar um método protected 
        protected void AdicionarGasolina(int litros)  
        {  

            /* Instruções de método aqui */              

        }  

        // As classes derivadas podem substituir a implementação da classe base 
        public virtual int Dirigir(int quilometros, int velocidade)  
        {  

            /* Instruções de método aqui*/  

            return 1;  
        } 
 

        // As classes derivadas podem substituir a implementação da classe base 
        public virtual int Dirigir(TimeSpan tempo, int velocidade)
        {  

            /* Declarações de método aqui */               

            return 0;  
        }  

        // As classes derivadas devem implementar isso 
        public abstract double VerificarVelocidadeMaxima(); 

    } 
} 
